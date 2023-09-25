public partial class Crop_Builder : Node
{
    // Crop_Builder will be instantiated once at runtime to build objects for all the available crops in the game.

    public readonly List <Crop> Crops;

    public override void _Ready()
    {
        Crops.Add(new Crop("Test", "TestDesc", 1,1,1, Seasons.Season.Spring));
    }
}
