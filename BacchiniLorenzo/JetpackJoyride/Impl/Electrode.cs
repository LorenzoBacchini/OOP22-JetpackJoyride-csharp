using AnnibaliniLorenzo.JetpackJoyride.Point2d;
using AnnibaliniLorenzo.JetpackJoyride.Vector2d;
using BurreliMattia.JetpackJoyride.Api.Hitbox;
using BacchiniLorenzo.JetpackJoyride.Api;

namespace BacchiniLorenzo.JetpackJoyride.Impl;
    
/// <summary>
/// Class to model an Electrode obstacle
/// @author lorenzo.bacchini4@studio.unibo.it
/// </summary>
public class Electrode : ObstacleImpl
{

    public Orientation Orientation { get; private set; }

    /// <summary>
    /// Constructor to create an Electrode obstacle.
    /// </summary>
    public Electrode(Point2d pos, Vector2d vel, Orientation orientation, Hitbox hitbox) : base(
        pos, vel, hitbox)
    {
        Orientation = orientation;
    }
}