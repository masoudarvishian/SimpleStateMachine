using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject gameMenu, helpMenu, settingsMenu, mainMenu;

    private StateMachine _stateMachine;

    private void Start()
    {
        _stateMachine = new StateMachine();

        _stateMachine.ChangeState(new MainMenuState(this));
    }

    public void OnClickHelp()
    {
        _stateMachine.ChangeState(new HelpState(this));
    }

    public void OnClickSettings()
    {
        _stateMachine.ChangeState(new SettingsState(this));
    }

    public void OnClickResume()
    {
        _stateMachine.ChangeState(new GameState(this));
    }

    public void OnReturn()
    {
        _stateMachine.ChangeState(new MainMenuState(this));
    }

    public void OnQuit()
    {
        _stateMachine.ChangeState(new QuitState(this));
    }

    public void OnPause()
    {
        _stateMachine.ChangeState(new MainMenuState(this));
    }
}
