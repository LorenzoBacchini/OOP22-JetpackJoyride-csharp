namespace BurreliMattia.JetpackJoyride.Api;

/// <summary>
///  Basic interface for the hitbox.
/// </summary>
public interface IHitbox
{
    public Point2d UpLeftPoint { get; }
    public Point2d DownRightPoint { get; }
    public bool HitBoxActive { get; set; }
    public double Width { get; }
    public double Height { get; }

    /// <summary>
    ///  Update the hitbox position.
    /// </summary>
    /// <param name="posObject"></param>
    void UpdateHitbox(Point2d posObject);
    
    /// <summary>
    ///  Check if the hitbox is colliding with another hitbox.
    /// </summary>
    /// <param name="hitbox"></param>
    /// <returns></returns>
    bool CheckCollision(IHitbox hitbox);
    
}