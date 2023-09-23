namespace FarmGame;

public partial class Story
{
    State Move()
    {
        State state = new("Move");

        state.Update += () =>
        {
            float speed = 2.0f;

            if (pathFollow.Progress <= targetProgresses[targetIndex] - speed)
            {
                // Move the npc along the path
                pathFollow.Progress += speed;
            }
            else
            {
                // The npc reached a path target
                targetIndex++;

                SwitchToNextState();
            }
        };

        return state;
    }
}
