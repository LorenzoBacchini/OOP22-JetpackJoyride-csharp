using AnnibaliniLorenzo.JetpackJoyride.Point2d;
using AnnibaliniLorenzo.JetpackJoyride.Vector2d;
using BurreliMattia.JetpackJoyride.Api.Hitbox;

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
    public Rocket(Point2d pos, Vector2d vel, Hitbox hitbox) : base(pos, vel, hitbox){}
}