using AnnibaliniLorenzo.JetpackJoyride;
using AnnibaliniLorenzo.JetpackJoyride.Api;
using AnnibaliniLorenzo.JetpackJoyride.Impl;
using BurreliMattia.JetpackJoyride.Api;
using BurreliMattia.JetpackJoyride.Impl;

namespace AnnibaliniLorenzoTest;
    
[TestClass]
    
public class ScientistTest
{
    private ScientistImpl scientist;
    private static Point2d point = new Point2d(0, 0);
    private Vector2d vector = new Vector2d(1, 0);
    private IHitbox hitbox = new HitboxImpl(1, 1, point);

    [TestInitialize]
    public void init()
    {
        scientist = new ScientistImpl(IDirection.Right, point, vector, hitbox);
    }

    [TestMethod]
    public void testGetDirection()
    {
        Assert.AreEqual(IDirection.Right, scientist.GetDirection());
    }

    [TestMethod]
    public void testIsAlive()
    {
        Assert.IsTrue(scientist.IsAlive());
    }

    [TestMethod]
    public void testKillScientist()
    {
        scientist.KillScientist();
        Assert.IsFalse(scientist.IsAlive());
    }

    [TestMethod]
    public void testNextPosition()
    {
        scientist.NextPosition();
        Assert.AreEqual(1, scientist.Pos.GetX());
        Assert.AreEqual(0, scientist.Pos.GetY());
    }
}