using AnnibaliniLorenzo.JetpackJoyride.Point2d;
using AnnibaliniLorenzo.JetpackJoyride.Vector2d;
using BurreliMattia.JetpackJoyride.Api.Hitbox;

namespace BacchiniLorenzo.JetpackJoyride.Impl;

/// <summary>
/// Class to model a LaserRay obstacle.
/// @author lorenzo.bacchini4@studio.unibo.it
/// </summary>
public class LaserRay : ObstacleActivable
{
    /// <summary>
    /// Constructore to create a LaserRay obstacle.
    /// </summary>
    public LaserRay(Point2d pos, Vector2d vel, Hitbox hitbox) : base(pos, vel, hitbox){}
}