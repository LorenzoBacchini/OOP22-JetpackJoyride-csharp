using AnnibaliniLorenzo.JetpackJoyride;
using BurreliMattia.JetpackJoyride.Api;

namespace BacchiniLorenzo.JetpackJoyride.Impl;

/// <summary>
/// A class to model an in-game money.
/// @author lorenzo.bacchini4@studio.unibo.it
/// </summary>
public class Money : GameObjectImpl
{
    /// <summary>
    /// Constructor of the class Money.
    /// </summary>
    /// <param name="pos">
    /// position of the money.
    /// </param>>
    /// <param name="vel">
    /// velocity of the money
    /// </param>>
    /// <param name="hitbox">
    /// the hitbox of the money
    /// </param>>
    public Money(Point2d pos, Vector2d vel, IHitbox hitbox) : base(pos, vel, hitbox){}
}