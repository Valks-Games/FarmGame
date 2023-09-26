namespace FarmGame;

public partial class Player : CharacterBody2D
{
    [Export] GameState gameState;

    float speed = 100;
    float friction = 0.15f;

    // Placeholder, will be moved to world logic class later
    TileMap tileMap; 

    public override void _Ready()
    {
        // Placeholder, will be moved to world logic class later
        tileMap = (TileMap)GetTree().Root.GetNode("Main").GetNode<Node>("TileMap");   
    }

    public override void _PhysicsProcess(double delta)
    {
        Movement();
    }

    void Movement()
    {
        Vector2 direction = Input.GetVector(
            negativeX: "move_left",
            negativeY: "move_up",
            positiveX: "move_right",
            positiveY: "move_down");

        Velocity += direction * speed;
        Velocity = Velocity.Lerp(Vector2.Zero, friction);

        MoveAndSlide();
    }

    /// <summary>
    /// Gets the players position at the tile they are currently standing on.
    /// </summary>
    /// <returns> Returns a Vector2I relative to the tilemap. </returns>
    public Vector2I GetTileAtPlayerPos()
    {
        Vector2I vector2I = new Vector2I((int)Position.X,(int)Position.Y);
        return tileMap.LocalToMap(vector2I);
    }

    /// <summary>
    /// Gets the position of the tile at the mouse cursor.
    /// </summary>
    /// <returns> Returns a Vector2I relative to the tilemap. </returns>
    public Vector2I GetTileAtCursorPos()
    {
        Vector2I vector2I = (Vector2I)tileMap.GetLocalMousePosition();
        return tileMap.LocalToMap(vector2I);
    }
}
