namespace BacchiniLorenzo.JetpackJoyride.Api;

/// <summary>
/// Interface to model a generic Obstacle.
/// @author lorenzo.bacchini4@studio.unibo.it
/// </summary>
public interface IObstacle
{
    /// <summary>
    /// Set the obstacle active = true.
    /// </summary>
    /// <returns></returns>
    void SetActiveOn();

    /// <summary>
    /// Set the obstacle active = false.
    /// </summary>
    /// <returns></returns>
    void SetActiveOff();
    
    /// <summary>
    /// Return true if the obstacle is active false otherwise.
    /// </summary>
    /// <returns>
    /// true if the obstacle is active false otherwise
    /// </returns>
    bool Active { get; }
}