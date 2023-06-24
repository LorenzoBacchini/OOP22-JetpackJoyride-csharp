using System.Runtime.InteropServices.JavaScript;
using OOP22_JetpackJoyride_csharp.AnnibaliniLorenzo.Api;
namespace AnnibaliniLorenzo.JetpackJoyride.Api;

/// <summary>
/// Interface for the scientist.
/// </summary>

public interface IScientist
{
    /// <summary>
    /// Method to get the Scientist's direction.
    /// </summary>
    /// <return> the current direction of the scientist </return>
    Direction GetDirection();

    /// <summary>
    /// Method to get if the scientist is alive.
    /// </summary>
    /// <return> true if the scientist is alive, false otherwise</return>
    JSType.Boolean IsAlive();

    /// <summary>
    /// Method to kill the Scientist's.
    /// Set the life of the scientist to false.
    /// </summary>
    /// <return> true if the scientist is alive, false otherwise</return>
    void KillScientist();

    /// <summary>
    /// Method to update the position of the scientist based on his direction.
    /// </summary>
    /// <return> true if the scientist is alive, false otherwise</return>
    void NextPosition();

}
