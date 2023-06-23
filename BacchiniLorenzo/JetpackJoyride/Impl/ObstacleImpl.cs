using BacchiniLorenzo.JetpackJoyride.Api;
using BacchiniLorenzo.JetpackJoyride.Impl;
using AnnibaliniLorenzo.JetpackJoyride.Point2d;
using AnnibaliniLorenzo.JetpackJoyride.Vector2d;
using BurreliMattia.JetpackJoyride.Api.Hitbox;

namespace BacchiniLorenzo.JetpackJoyride.Impl;

/// <summary>
/// This is a class to model a generic obstacle
/// @author lorenzo.bacchini4@studio.unibo.it
/// </summary>
public abstract class ObstacleImpl : GameObjectImpl, IObstacle
{
    
    public bool Active { get; private set; }

    public ObstacleImpl(Point2d pos, Vector2d vel, Hitbox hitbox) : base(pos, vel, hitbox)
    {
        SetActiveOn();
    }

    public void SetActiveOn()
    {
        Active = true;
        GetHitbox().SetHitboxActive();
    }
    
    public void SetActiveOff()
    {
        Active = false;
        GetHitbox().SetHitboxDisable();
    }
}