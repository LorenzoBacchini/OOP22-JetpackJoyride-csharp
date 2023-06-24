using BurreliMattia.JetpackJoyride.Impl;

namespace BurreliMattia.JetpackJoyride.Api;

/// <summary>
///   Represents a queue of input commands.
/// </summary>
public interface IInputQueue
{
    /// <summary>
    ///  Add an input to the queue.
    /// </summary>
    /// <param name="input"></param>
    void AddInput(InputImpl input);

    /// <summary>
    ///  Get the input queue.
    /// </summary>
    /// <returns>The input queue.</returns>
    List<InputImpl> GetInputQueue();
    
    /// <summary>
    ///  Clear the input queue and return it.
    /// </summary>
    /// <returns> The InputQueue.</returns>
    bool IsEmpty();
}