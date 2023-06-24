using AnnibaliniLorenzo.JetpackJoyride;
using BurreliMattia.JetpackJoyride.Api;

namespace BacchiniLorenzo.JetpackJoyride.Api;

/// <summary>
/// Interface to model a generic GameObject.
///@author lorenzo.bacchini4@studio.unibo.it
/// </summary>
public interface IGameObject
{
    /// <summary>
    /// position of the GameObject.
    /// </summary>
    /// <returns>the current position</returns>
    Point2d Pos { get; set; }
    
    /// <summary>
    /// velocity of the GameObject.
    /// </summary>
    /// <returns>the current velocity</returns>>
    Vector2d Vel { get; set; }

    /// <summary>
    /// flip the velocity of the game object on the y axis.
    /// </summary>
    /// <returns></returns>
    void FlipVelOnY();

    /// <summary>
    /// flip the velocity of the game object on the x axis.
    /// </summary>
    /// <returns></returns>
    void FlipVelOnX();

    /// <summary>
    /// update the state of a GameObject recalculating its position
    /// from is current position plus
    /// (the velocity of the object multiplied by a factor dt).
    /// dt example: dt can be the time elapsed between two frames.
    /// </summary>
    /// <param name="dt">the time elapsed</param>
    void UpdateState(long dt);
    
    /// <summary>
    ///  get the current hitbox of the GameObject
    /// </summary>
    /// <returns>the GameObject's hitbox</returns>>
    IHitbox Hitbox { get; }
}