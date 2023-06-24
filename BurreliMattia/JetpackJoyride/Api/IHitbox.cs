namespace BurreliMattia.JetpackJoyride.Api;
using AnnibaliniLorenzo.JetpackJoyride.Point2d;
using AnnibaliniLorenzo.JetpackJoyride.Vector2d;

/// <summary>
///  Basic interface for the hitbox.
/// </summary>
public interface IHitbox
{
    public point2d UpLeftPoint { get; }
    public point2d DownRightPoint { get; }
    public bool HitBoxActive { get; set; }
    public double Width { get; }
    public double Height { get; }

    /// <summary>
    ///  Update the hitbox position.
    /// </summary>
    /// <param name="posObject"></param>
    void UpdateHitbox(point2d posObject);
    
    /// <summary>
    ///  Check if the hitbox is colliding with another hitbox.
    /// </summary>
    /// <param name="hitbox"></param>
    /// <returns></returns>
    bool CheckCollision(IHitbox hitbox);
    
}