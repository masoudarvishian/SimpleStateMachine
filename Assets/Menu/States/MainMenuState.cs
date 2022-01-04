public class MainMenuState : IState
{
    private MenuController _owner;

    public MainMenuState(MenuController owner)
    {
        _owner = owner;
    }

    public void Enter()
    {
        _owner.mainMenu.SetActive(true);
    }

    public void Execute()
    {
    }

    public void Exit()
    {
        _owner.mainMenu.SetActive(false);
    }
}
