using BurreliMattia.JetpackJoyride.Api;
using AnnibaliniLorenzo.JetpackJoyride.Point2d;
using AnnibaliniLorenzo.JetpackJoyride.Vector2d;

namespace BurreliMattia.JetpackJoyride.Impl;

public class HitboxImpl : IHitbox
{
    private double _width;
    private double _height;
    private bool _hitBoxActive;
    private Point2d _upLeftPoint;
    private Point2d _downRightPoint;
    
public double Width => this._width;

public double Height => this._height;

    public bool HitBoxActive
    {
        get => this._hitBoxActive;
        set {
            if (_hitBoxActive)
            {
                _hitBoxActive = false;
            }
            else
            {
                _hitBoxActive = true;
            }
        }
    }
    
    public Point2d UpLeftPoint => this._upLeftPoint;

    public Point2d DownRightPoint => this._downRightPoint;

    
    /// <summary>
    /// Constructor of the hitbox.
    /// </summary>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <param name="posObject"></param>
    public HitboxImpl(double width, double height, Point2d posObject)
    {
        this._width = width;
        this._height = height;
        this._hitBoxActive = true;
        
    }

    /// <summary>
    ///  Update the hitbox position.
    /// </summary>
    /// <param name="posObject"></param>
    public void UpdateHitbox(Point2d posObject)
    {
        this.CalcPointPosition(posObject);
    }
    
    /// <summary>
    ///  Calculate the position of the hitbox.
    /// </summary>
    /// <param name="posObject"></param>
    private void CalcPointPosition(Point2d posObject) {
        this._upLeftPoint = new Point2d(posObject.getX() - this._width / 2.0, posObject.getY() - this._height / 2.0);
        this._downRightPoint = new Point2d(posObject.getX() + this._width / 2.0, posObject.getY() + this._height / 2.0);
    }
    
    public bool CheckCollision(IHitbox hitbox)
    {
        return (this.CheckCollisionHitboxAndPoint(hitbox.UpLeftPoint)
                || this.CheckCollisionHitboxAndPoint(hitbox.DownRightPoint)
                || this.CheckCollisionHitboxAndPoint(
                    new Point2d(hitbox.UpLeftPoint.getX(), hitbox.DownRightPoint.getY()))
                || this.CheckCollisionHitboxAndPoint(
                    new Point2d(hitbox.DownRightPoint.getX(), hitbox.UpLeftPoint.getY())))
               && hitbox.HitBoxActive && this.HitBoxActive;
    }
    
    private bool CheckCollisionHitboxAndPoint( Point2d point) {
        return point.getX() >= this.UpLeftPoint.getX() && point.getX() <= this.DownRightPoint.getX()
                                                       && point.getY() >= this.UpLeftPoint.getY() && point.getY() <= this.DownRightPoint.getY();
    }
}