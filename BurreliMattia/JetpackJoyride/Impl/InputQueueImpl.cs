using BurreliMattia.JetpackJoyride.Api;

namespace BurreliMattia.JetpackJoyride.Impl;

public class InputQueueImpl : IInputQueue
{
    private readonly List<InputImpl> inputQueue;
    
    public InputQueueImpl()
    {
        this.inputQueue = new List<InputImpl>();
    }
    
    public void AddInput(InputImpl input)
    {
        this.inputQueue.Add(input);
    }

    public List<InputImpl> GetInputQueue()
    { 
        List<InputImpl> inputQueueTemp= new List<InputImpl>(this.inputQueue);
       this.inputQueue.Clear();
         return inputQueueTemp;
    }

    public bool IsEmpty()
    {
        return this.inputQueue.Count == 0;
    }
}