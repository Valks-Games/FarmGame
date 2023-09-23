namespace FarmGame;

public partial class Level : Node
{
    readonly List<Story> stories = new();

    public override void _Ready()
    {
        Sprite2D npc = CreateNPC(Colors.Red);

        new Story(this, npc, stories)
            .MoveTo(0, 0)
            .MoveTo(3, 0)
            .MoveTo(3, 3)
            .MoveTo(0, 3)
            .MoveTo(0, 0)
            .Start();
    }

    public override void _PhysicsProcess(double delta)
    {
        for (int i = 0; i < stories.Count; i++)
        {
            stories[i].Update();
        }
    }

    Sprite2D CreateNPC(Color color)
    {
        Sprite2D npc = GD.Load<PackedScene>("res://Scenes/Prefabs/npc.tscn")
            .Instantiate<Sprite2D>();
        
        npc.SelfModulate = color;
        npc.Position = Utils.GetGridPosition(0, 0);
        AddChild(npc);

        return npc;
    }
}
