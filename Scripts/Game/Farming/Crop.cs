namespace FarmGame;

[GlobalClass]
public partial class Crop : Node
{
    // Crops are added manually via the crops scene/node in the editor.

    [Export]
    public string CropName;
    [Export]
    public string CropDescription;
    [Export]
    public int DaysUntilMaxGrowth;
    [Export]
    public int CropYield;
    [Export]
    public int DaysUntilDeath;
    [Export]
    public Seasons.Season GrowthSeason;

    public Crop()
    {

    }
}
