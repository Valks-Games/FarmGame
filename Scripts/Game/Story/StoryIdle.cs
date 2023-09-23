namespace FarmGame;

public partial class Story
{
    State Idle(double delay)
    {
        State state = new("Idle");

        state.Enter += () =>
        {
            parent.GetTree().CreateTimer(delay).Timeout += () => SwitchToNextState();
        };

        return state;
    }
}
