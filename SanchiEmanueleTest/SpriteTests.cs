using System.Drawing;
using SanchiEmanuele.JetpackJoyride;
using SanchiEmanuele.JetpackJoyride.Impl;

namespace SanchiEmanueleTest;

public class SpriteTests
{
    [SetUp]
    public void Setup()
    {
    }

    /// <summary>
    /// Test for class Sprite
    /// </summary>
    [Test]
    public void SpriteTest()
    {
        //Create a new sprite
        Sprite sprite = new Sprite(100, 200, new Bitmap(50, 200));
        //Check if dimensions are right and scaledimage is null, because method Scale() was not called
        Assert.AreEqual(new Pair<int,int>(100, 200), sprite.ScaledDimension);
        Assert.AreEqual(new Pair<int, int>(50, 200), new Pair<int, int>(sprite.OriginalImage.Width, sprite.OriginalImage.Height));
        Assert.IsNull(sprite.ScaledImage);
        sprite.Scale();
        // Check is dimension of scaeld image is right and scaled image is not null
        Assert.AreEqual(sprite.ScaledDimension, new Pair<int, int>(sprite.ScaledImage.Width, sprite.ScaledImage.Height));
        Assert.IsNotNull(sprite.ScaledImage);
    }
}