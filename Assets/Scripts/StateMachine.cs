public class StateMachine
{
    private IState _currentState = null;

    public void ChangeState(IState newState)
    {
        _currentState?.Exit();
        _currentState = newState;
        _currentState.Enter();
    }

    public void Execute()
    {
        _currentState?.Execute();
    }
}
