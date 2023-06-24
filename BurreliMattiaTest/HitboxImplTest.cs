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
        Point2d positionEntity = new Point2d(xPlayer - 10, heightPositionEntity);
        long dt = 2;
        int y = 0;
        Point2d positionPlayer = new Point2d(xPlayer - 10, heightPositionPlayer);
        IHitbox hitboxPlayer = new HitboxImpl(xPlayer, yPlayer, positionPlayer);
        IHitbox hitbox = new HitboxImpl(xPlayer, yPlayer, positionEntity);
        GameObjectImpl entity = new GameObjectImpl(positionEntity, new Vector2d(positionPlayer, positionEntity),
            hitbox);

        while (y >= -xPlayer) {
            entity.UpdateState(dt);
            entity.Hitbox.updateHitbox(entity.Pos);
            if (entity.Hitbox.checkCollision(hitboxPlayer)) {
                y--;
                entity.Pos= new Point2d(positionEntity.getX(), positionEntity.getY() + y);
                break;
            } else if (entity.Pos.getX() < 0) {
                Assert.Fail("Collision not detected");
                break;
            }
        }
    }
    
}