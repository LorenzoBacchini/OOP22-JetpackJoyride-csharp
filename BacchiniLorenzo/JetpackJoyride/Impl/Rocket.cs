using AnnibaliniLorenzo.JetpackJoyride;
using BurreliMattia.JetpackJoyride.Api;

namespace BacchiniLorenzo.JetpackJoyride.Impl;

/// <summary>
/// Class to model a Rocket obstacle.
/// @author lorenzo.bacchini4@studio.unibo.it
/// </summary>
public class Rocket : ObstacleActivable
{
    /// <summary>
    /// Constructor to create a Rocket obstacle.
    /// </summary>
    public Rocket(Point2d pos, Vector2d vel, IHitbox hitbox) : base(pos, vel, hitbox){}
}