namespace FarmGame;

public class Route
{
    int targetIndex = 0;

    readonly List<float> targetProgresses = new();
    readonly List<Route> routes;
    readonly PathFollow2D pathFollow;
    readonly Curve2D curve;
    readonly Node parent;

    public Route(Node parent, Sprite2D npc, List<Route> routes)
    {
        this.parent = parent;
        this.routes = routes;

        // Create the path
        curve = new Curve2D();
        Path2D path = new()
        {
            Curve = curve
        };

        pathFollow = new PathFollow2D
        {
            Rotates = false
        };

        path.AddChild(pathFollow);

        this.parent.AddChild(path);

        // Reassign the NPC to the path node
        this.parent.RemoveChild(npc);
        pathFollow.AddChild(npc);

        // The npc position should be (0, 0)
        npc.Position = Vector2.Zero;
    }

    public Route Start()
    {
        routes.Add(this);
        pathFollow.ProgressRatio = 0;
        return this;
    }

    public void Update()
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

            if (ReachedLastTarget())
                routes.Remove(this);
        }
    }

    public Route MoveTo(int x, int y)
    {
        // Calculate the grid point
        Vector2 gridPos = Utils.GetGridPosition(x, y);

        // Add the point to the curve
        curve.AddPoint(gridPos);

        // Get the final Progress value when ProgressRatio is set to max
        // for this newly added point
        pathFollow.ProgressRatio = 1;
        targetProgresses.Add(pathFollow.Progress);

        return this;
    }

    bool ReachedLastTarget() => 
        targetIndex > curve.PointCount - 1;
}
