using AnnibaliniLorenzo.JetpackJoyride;
using BacchiniLorenzo.JetpackJoyride.Impl;
using BurreliMattia.JetpackJoyride.Api;
using BurreliMattia.JetpackJoyride.Impl;

namespace BurreliMattiaTest;

[TestClass]
public class HitboxImplTest
{
 
    [TestMethod]
    public void TestHitboxCollision() {
        double xPlayer = 30.0;
        double yPlayer = 15.0;
        int heightPositionEntity = 380;
        int heightPositionPlayer = 350;
        Point2d positionEntity = new Point2d(40, heightPositionEntity);
        long dt = 10;
        int y = 0;
        Point2d positionPlayer = new Point2d(xPlayer - 10, heightPositionPlayer);
        IHitbox hitboxPlayer = new HitboxImpl(xPlayer, yPlayer, positionPlayer);
        IHitbox hitbox = new HitboxImpl(xPlayer, yPlayer, positionEntity);
        GameObjectImpl entity = new GameObjectImpl(positionEntity, new Vector2d(positionPlayer, positionEntity),
            hitbox);

        while (y>=-30) {
            entity.UpdateState(dt);
            entity.Hitbox.UpdateHitbox(entity.Pos);
            if (entity.Hitbox.CheckCollision(hitboxPlayer)) {
                y--;
                entity.Pos= new Point2d(positionEntity.GetX(), positionEntity.GetY() + y);
            } else if (entity.Pos.GetX() < 0) {
                Assert.Fail("Collision not detected");
                break;
            }
        }
    }
    
}