namespace BurreliMattia.JetpackJoyride.Api;

/// <summary>
///  Basic interface for the input.
/// </summary>
public interface IInput
{
    public enum TypeInput
    {
        UpPressed,
        UpReleased,
        Menu,
        Shop,
        Statistics,
        Exit,
        EndGame,
        Enable,
        Disable,
        Buy,
        SelectSkin,
        BuySkin,
        StartGame,
        Settings,
        Error
    }

    public TypeInput Type { get; }
    public string Name { get; }

}