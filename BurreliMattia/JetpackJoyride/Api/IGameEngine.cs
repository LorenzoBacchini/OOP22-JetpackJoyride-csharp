namespace BurreliMattia.JetpackJoyride.Api;

/// <summary>
/// Basic interface for the game engine.
/// </summary>
public interface IGameEngine
{
    /// <summary>
    ///  List of all the possible game states.
    /// </summary>
    public enum GameState
    {
        MainMenu,
        Game,
        GameOver,
        ShopMenu,
        StatisticsMenu,
        SettingsMenu
    }
    
    /// <summary>
    /// Start the game engine loop.
    /// </summary>
    void LoopState();
}