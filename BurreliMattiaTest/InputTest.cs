using BurreliMattia.JetpackJoyride.Api;
using BurreliMattia.JetpackJoyride.Impl;

namespace BurreliMattiaTest;


[TestClass]
public class InputTest
{

    [TestMethod]
    public void TestInput() {

        InputQueueImpl inputQueue = new InputQueueImpl();
        int dimension = 5;
        inputQueue.AddInput(new InputImpl(IInput.TypeInput.Menu, "menu"));
        inputQueue.AddInput(new InputImpl(IInput.TypeInput.UpPressed, "up"));
        inputQueue.AddInput(new InputImpl(IInput.TypeInput.UpReleased, "endUp"));
        inputQueue.AddInput(new InputImpl(IInput.TypeInput.Exit, "exit"));
        inputQueue.AddInput(new InputImpl(IInput.TypeInput.Shop, "shop"));
        List<InputImpl> inputList = inputQueue.GetInputQueue();
        Assert.AreEqual(dimension, inputList.Count);
        Assert.IsTrue(inputQueue.IsEmpty());
    }
}