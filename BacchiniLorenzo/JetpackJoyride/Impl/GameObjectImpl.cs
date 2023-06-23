using AnnibaliniLorenzo.JetpackJoyride.Point2d;
using AnnibaliniLorenzo.JetpackJoyride.Vector2d;
using BurreliMattia.JetpackJoyride.Api.Hitbox;
using BurreliMattia.JetpackJoyride.Impl.HitboxImpl;
using BacchiniLorenzo.JetpackJoyride.Api;

namespace BacchiniLorenzo.JetpackJoyride.Impl;

public class GameObjectImpl : IGameObject
{
    private Point2d _pos;
    private Vector2d _vel;
    private const double DeltaTimeMultiplier = 0.001;

    public Point2d Pos
    {
        get => new Point2d(_pos.GetX(), _pos.GetY());
        set => _pos = new Point2d(value.GetX(), value.GetY());
    }

    public Vector2d Vel
    {
        get => new Vector2d(_vel.GetX(), _vel.GetY());
        set => _vel = new Vector2d(value.GetX(), value.GetY());
    }

    public void UpdateState(long dt)
    {
        Pos = Pos.Sum(Vel.Mul(DeltaTimeMultiplier * dt));
    }

    public Hitbox Hitbox { get; }

    /// <summary>
    /// Constructor to create a GameObject
    /// </summary>

    public GameObjectImpl(Point2d pos, Vector2d vel, Hitbox hitbox)
    {
        Pos = new Point2d(pos.GetX(), pos.GetY());
        Vel = new Vector2d(vel.GetX(), vel.GetY());
        Hitbox = new HitboxImpl(hitbox.GetHeigthHitbox(), hitbox.GetWidthHitbox(), pos);
    }

    public void FlipVelOnY()
    {
        Vel = new Vector2d(Vel.GetX(), -Vel.GetY());
    }

    public void FlipVelOnX()
    {
        Vel = new Vector2d(-Vel.GetX(), Vel.GetY());
    }
}