using UnityEngine;

public class QuitState : IState
{
    private MenuController _owner;

    public QuitState(MenuController owner)
    {
        _owner = owner;
    }

    public void Enter()
    {
        Debug.Log("Quiting...");
    }

    public void Execute()
    {
    }

    public void Exit()
    {
    }
}
