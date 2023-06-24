using System;
using AnnibaliniLorenzo.JetpackJoyride;
using BurreliMattia.JetpackJoyride.Api;

namespace BacchiniLorenzo.JetpackJoyride.Impl;

/// <summary>
/// Abstract class to model an ObstacleActivable, 
/// a particular obstacle that can activate itself 
/// after a time called changeStateTime. 
/// </summary>
public abstract class ObstacleActivable : ObstacleImpl
{
    private readonly long _creationTime;
    private long _activationTime;
    private const long ChangeStateTime = 4000;
    
    public bool End { get; private set; }

    /// <summary>
    /// Constructor of the class ObstacleActivable
    /// </summary>
    public ObstacleActivable(Point2d pos, Vector2d vel, IHitbox hitbox) : base(pos, vel, hitbox)
    {
        SetActiveOff();
        End = false;
        _creationTime = Environment.TickCount & Int32.MaxValue;
    }
    
    /// <summary>
    /// Update the state of an ObstacleActivable by
    /// activating/deactivating the obstacle if a
    /// changeStateTime is elapsed.
    /// </summary>
    /// <param name="dt">
    /// time elapsed
    /// </param>
    public void CheckState(long dt)
    {
        if (((Environment.TickCount & Int32.MaxValue) - _creationTime) > ChangeStateTime && !End)
        {
            _activationTime = Environment.TickCount & Int32.MaxValue;
            SetActiveOn();
        }

        if (Active && ((Environment.TickCount & Int32.MaxValue) - _activationTime) > ChangeStateTime)
        {
            SetActiveOff();
            SetEndOn();
        }
    }

    /// <summary>
    /// Set the end state of the ObstacleActivable to true.
    /// </summary>
    private void SetEndOn()
    {
        End = true;
    }
}