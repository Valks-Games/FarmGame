namespace FarmGame;

public partial class Crop : Node
{
    public string CropName { get; private set; }
    public string CropDescription { get; private set; }
    public int DaysUntilMaxGrowth { get; private set; }
    public int CropYield { get; private set; }
    public int DaysUntilDeath { get; private set; }
    public Seasons.Season GrowthSeason { get; private set; }

    public Crop(string _cropName, string _cropDescription, int _daysUntilMaxGrowth,
                int _cropYield, int _daysUntilDeath, Seasons.Season _growthSeason)
    {
        CropName = _cropName;
        CropDescription = _cropDescription;
        DaysUntilMaxGrowth = _daysUntilMaxGrowth;
        CropYield = _cropYield;
        DaysUntilDeath = _daysUntilDeath;
        GrowthSeason = _growthSeason;
    }
}
