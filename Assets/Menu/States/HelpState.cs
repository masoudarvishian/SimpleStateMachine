public class HelpState : IState
{
    private MenuController _owner;

    public HelpState(MenuController owner)
    {
        _owner = owner;
    }

    public void Enter()
    {
        _owner.helpMenu.SetActive(true);
    }

    public void Execute()
    {
    }

    public void Exit()
    {
        _owner.helpMenu.SetActive(false);
    }
}
