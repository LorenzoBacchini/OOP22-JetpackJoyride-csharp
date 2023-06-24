using SanchiEmanuele.JetpackJoyride.Api;
using SanchiEmanuele.JetpackJoyride.Impl;

namespace SanchiEmanueleTest;

using System.Security.AccessControl;

/// <summary>
/// Class to test right increment of a variable with a thread
/// </summary>
public class SliderTests
{
    [SetUp]
    public void Setup()
    {
    }

    /// <summary>
    /// That is not a real test but it shows how slider increment (10 by 10)
    /// </summary>
    [Test]
    public void SliderTest()
    {
        //Create a slider
        ISlider slider = new SliderImpl(100);
        //Start slider until position is 50
        slider.Run();
        while (slider.Pos < 50)
        {
            Console.Write(" " + slider.Pos + " ");
        }

        slider.Interrupt();
    }
}