namespace FarmGame;

public static class Utils
{
    public static Vector2 GetGridPosition(int x, int y)
    {
        Vector2 offset = Vector2.One * 24;
        return new Vector2(x, y) * 48 + offset;
    }
}
