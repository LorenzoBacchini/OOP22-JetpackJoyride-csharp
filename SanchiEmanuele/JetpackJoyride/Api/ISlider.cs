namespace SanchiEmanuele.JetpackJoyride.Api;

/// <summary>
/// A basic interface for a slider thread
/// </summary>
public interface ISlider
{
    public int Pos { get; }
    
    /// <summary>
    /// Method to reset the position of the slider
    /// </summary>
    void ResetPos();

    /// <summary>
    /// Method to run the thread
    /// </summary>
    void Run();

    /// <summary>
    /// Method to interrupt the thread
    /// </summary>
    void Interrupt();
}