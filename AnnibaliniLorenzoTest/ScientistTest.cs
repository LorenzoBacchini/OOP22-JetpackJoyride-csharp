using OOP22_JetpackJoyride_csharp.OOP22_JetpackJoyride_csharp.AnnibaliniLorenzo.Api.Scientist;
using OOP22_JetpackJoyride_csharp.OOP22_JetpackJoyride_csharp.AnnibaliniLorenzo.Api.Direction;
using OOP22_JetpackJoyride_csharp.OOP22_JetpackJoyride_csharp.AnnibaliniLorenzo.Impl.ScientistImpl;
using OOP22_JetpackJoyride_csharp.OOP22_JetpackJoyride_csharp.AnnibaliniLorenzo.Point2d;
using OOP22_JetpackJoyride_csharp.OOP22_JetpackJoyride_csharp.AnnibaliniLorenzo.Vector2d;
using OOP22_JetpackJoyride_csharp.OOP22_JetpackJoyride_csharp.BurelliMattia.api.Hitbox;
using OOP22_JetpackJoyride_csharp.OOP22_JetpackJoyride_csharp.BurelliMattia.Impl.HitboxImpl;

namespace OOP22_JetpackJoyride_csharp.OOP22_JetpackJoyride_csharp.AnnibaliniLorenzoTest
{
    [TestClass]
    public class ScientistTest
    {
        private Scientist scientist;
        private Point2d point = new Point2dImpl(0, 0);
        private Vector2d vector = new Vector2dImpl(1, 0);
        private Hitbox hitbox = new HitboxImpl(1, 1);

        [TestInitialize]
        public void init()
        {
            scientist = new ScientistImpl(Direction.RIGHT, point, vector, hitbox);
        }

        [TestMethod]
        public void testGetDirection()
        {
            Assert.AreEqual(Direction.RIGHT, scientist.getDirection());
        }

        [TestMethod]
        public void testIsAlive()
        {
            Assert.IsTrue(scientist.isAlive());
        }

        [TestMethod]
        public void testKillScientist()
        {
            scientist.killScientist();
            Assert.IsFalse(scientist.isAlive());
        }

        [TestMethod]
        public void testNextPosition()
        {
            scientist.nextPosition();
            Assert.AreEqual(1, scientist.getPosition().getX());
            Assert.AreEqual(0, scientist.getPosition().getY());
        }
    }
}