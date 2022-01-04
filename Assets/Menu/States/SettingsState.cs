public class SettingsState : IState
{
    private MenuController _owner;

    public SettingsState(MenuController owner)
    {
        _owner = owner;
    }

    public void Enter()
    {
        _owner.settingsMenu.SetActive(true);
    }

    public void Execute()
    {
        
    }

    public void Exit()
    {
        _owner.settingsMenu.SetActive(false);
    }
}
