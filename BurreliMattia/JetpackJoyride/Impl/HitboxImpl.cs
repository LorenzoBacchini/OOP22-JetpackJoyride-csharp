using BurreliMattia.JetpackJoyride.Api;

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
    
    public Point2d UpLeftPoint => new Point2d(_upLeftPoint.GetX(), _upLeftPoint.GetY());

    public Point2d DownRightPoint => new Point2d(_downRightPoint.GetX(), _downRightPoint.GetY());

    
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
        this.CalcPointPosition(posObject);

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
        this._upLeftPoint = new Point2d(posObject.GetX() - this._width / 2.0, posObject.GetY() - this._height / 2.0);
        this._downRightPoint = new Point2d(posObject.GetX() + this._width / 2.0, posObject.GetY() + this._height / 2.0);
    }
    
    public bool CheckCollision(IHitbox hitbox)
    {
        return (this.CheckCollisionHitboxAndPoint(hitbox.UpLeftPoint)
                || this.CheckCollisionHitboxAndPoint(hitbox.DownRightPoint)
                || this.CheckCollisionHitboxAndPoint(
                    new Point2d(hitbox.UpLeftPoint.GetX(), hitbox.DownRightPoint.GetY()))
                || this.CheckCollisionHitboxAndPoint(
                    new Point2d(hitbox.DownRightPoint.GetX(), hitbox.UpLeftPoint.GetY())))
               && hitbox.HitBoxActive && this.HitBoxActive;
    }
    
    private bool CheckCollisionHitboxAndPoint( Point2d point) {
        return point.GetX() >= this.UpLeftPoint.GetX() && point.GetX() <= this.DownRightPoint.GetX()
                                                       && point.GetY() >= this.UpLeftPoint.GetY() && point.GetY() <= this.DownRightPoint.GetY();
    }
}