public class GameState : IState
{
    private MenuController _owner;

    public GameState(MenuController owner)
    {
        _owner = owner;
    }
    
    public void Enter()
    {
        _owner.gameMenu.SetActive(true);
    }

    public void Execute()
    {
    }

    public void Exit()
    {
        _owner.gameMenu.SetActive(false);
    }
}
