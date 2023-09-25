namespace FarmGame;

public partial class Player : CharacterBody2D
{
    float speed = 100;
    float friction = 0.15f;

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
}
