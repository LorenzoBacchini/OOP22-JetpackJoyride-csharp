using BurreliMattia.JetpackJoyride.Api;
using System;
using static BurreliMattia.JetpackJoyride.Api.IInput.TypeInput;

namespace BurreliMattia.JetpackJoyride.Impl;


/// <summary>
///  Implementation of the IGameEngine interface.
/// </summary>
public class GameEngineImpl : IGameEngine
{
    private readonly InputQueueImpl InputHandler;
    private readonly View View;
    private static readonly long FramePeriod = 20;
    private readonly WorldGameStateImpl WorldGameState;
    private IGameEngine.GameState CurrentState;
    private bool IsRunning;
    private readonly SkinInfoLoaderImpl SkinInfoLoader;
    private readonly GadgetLoaderImpl GadgetLoader;
    private readonly GameEconomy GameEconomy;

    /// <summary>
    ///   Constructor for the GameEngineImpl class.
    /// </summary>
    /// <param name="inputHandler"></param>
    /// <param name="view"></param>
    /// <param name="worldGameState"></param>
    public GameEngineImpl(InputQueueImpl inputHandler, View view, WorldGameStateImpl worldGameState)
    {
        this.InputHandler = inputHandler;
        this.View = view;
        this.WorldGameState = worldGameState;
        this.IsRunning = true;
        this.CurrentState= IGameEngine.GameState.MainMenu;
        this.SkinInfoLoader = new SkinInfoLoaderImpl();
        this.GadgetLoader = new GadgetLoaderImpl();
        this.GameEconomy = new GameEconomy();
    }

    /// <summary>
    ///  Function for stard a new game and set the current state to Game and start the world game state.
    /// </summary>
    private void WorldGameStateStart()
    {
        if (this.CurrentState != IGameEngine.GameState.MainMenu &&
            this.CurrentState != IGameEngine.GameState.GameOver) return;
        this.WorldGameState.newGame();
        this.View.getGamePanel().setMoney(this.WorldGameState.getMoney());
        this.View.getGamePanel().setEntities(this.WorldGameState.getWorldEntities());
        this.View.getGamePanel().setPlayer(this.WorldGameState.getPlayer());
        this.CurrentState = IGameEngine.GameState.Game;
    }
    
    public void LoopState()
    {
        long previousCycleStartTime = Environment.TickCount & Int32.MaxValue;
        while (this.IsRunning) {
            long currentCycleStartTime = Environment.TickCount & Int32.MaxValue;
            long elapsedTime = currentCycleStartTime - previousCycleStartTime;
            this.ProcessInput();
            this.UpdateWorldGameState(elapsedTime);
            this.RenderView();
            this.WaitNextFrame(currentCycleStartTime);
            previousCycleStartTime = currentCycleStartTime;
        }
    }
    
    /// <summary>
    ///  Function for process the input.
    /// </summary>
    private void ProcessInput() {
        List<InputImpl> inputQueue = this.InputHandler.GetInputQueue();
        foreach (InputImpl inputElem in inputQueue) {
            switch (inputElem.Type) {

                case Shop:
                    if (this.CurrentState == IGameEngine.GameState.MainMenu)
                    {
                        this.CurrentState = IGameEngine.GameState.ShopMenu;
                    }

                    break;

                case Menu:
                    this.CurrentState = IGameEngine.GameState.MainMenu;
                    break;

                case Statistics:
                    if (this.CurrentState == IGameEngine.GameState.MainMenu) {
                        this.CurrentState = IGameEngine.GameState.StatisticsMenu;
                    }
                    break;

                case Settings:
                    if (this.CurrentState == IGameEngine.GameState.MainMenu) {
                        this.CurrentState = IGameEngine.GameState.SettingsMenu;
                    }
                    break;

                case UpPressed:
                    if (this.CurrentState == IGameEngine.GameState.Game) {
                        this.WorldGameState.moveUp();
                    }
                    break;

                case UpReleased:
                    if (this.CurrentState == IGameEngine.GameState.Game) {
                        this.WorldGameState.moveStatic();
                    }
                    break;

                case Exit:
                    if (this.CurrentState == IGameEngine.GameState.MainMenu || this.CurrentState == IGameEngine.GameState.GameOver) {
                        this.GadgetLoader.uploadGadget(new GadgetImpl().getAll());
                        this.SkinInfoLoader.uploadSkin(new SkinInfoImpl().getAll());
                        this.IsRunning = false;
                        this.View.close();
                    }
                    break;

                case EndGame:
                    if (this.CurrentState == IGameEngine.GameState.Game) {
                        this.CurrentState = IGameEngine.GameState.GameOver;
                    }
                    break;

                case Enable:
                    this.GameEconomy.enableGadget(inputElem.Name);
                    break;

                case Disable:
                    this.GameEconomy.disableGadget(inputElem.Name);
                    break;

                case Buy:
                    this.GameEconomy.buyGadget(inputElem.Name);
                    break;

                case BuySkin:
                    this.GameEconomy.buySkin(inputElem.Name);
                    break;

                case SelectSkin:
                    this.GameEconomy.selectSkin(inputElem.Name);
                    break;

                case StartGame:
                    if (this.CurrentState == IGameEngine.GameState.MainMenu || this.CurrentState == IGameEngine.GameState.GameOver) {
                        this.WorldGameStateStart();
                    }
                    break;

                case Error:
                    this.View.launchError(inputElem.Name);
                    break;

                default:
                    break;

            }
        }
    }
    
    /// <summary>
    ///  Function for update the world game state.
    /// </summary>
    /// <param name="elapsedTime"></param>
    private void UpdateWorldGameState(long elapsedTime){
        if (this.CurrentState == IGameEngine.GameState.Game) {
            this.WorldGameState.updateState(elapsedTime);
        }
    }

    /// <summary>
    ///  Function for render the view.
    /// </summary>
    private void RenderView() {
        switch (this.CurrentState) {
            case IGameEngine.GameState.MainMenu:
                this.View.renderMenu();
                break;
            case IGameEngine.GameState.Game:
                this.View.renderGame();
                break;
            case IGameEngine.GameState.ShopMenu:
                this.View.renderShop();
                break;
            case IGameEngine.GameState.StatisticsMenu:
                this.View.renderStatistics();
                break;
            case IGameEngine.GameState.GameOver:
                this.View.renderEndGame();
                break;
            case IGameEngine.GameState.SettingsMenu:
                // this.view.renderSettings();
                break;
            default:
                break;
        }

    }

/// <summary>
///  Function for wait the next frame.
/// </summary>
/// <param name="cycleStartTime"></param>
    private void WaitNextFrame(long cycleStartTime) {
        long dt = Environment.TickCount & Int32.MaxValue - cycleStartTime;
        if (dt < FramePeriod) {
            Thread.Sleep((int)(FramePeriod - dt));
        }
    }
    
    
    
}