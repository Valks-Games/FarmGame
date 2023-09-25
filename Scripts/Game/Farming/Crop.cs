using Godot;
using System;

public partial class Crop : Node
{
    public string CropName  { get; private set;}
    public string CropDescription  { get; private set;}
    public int DaysUntilMaxGrowth  { get; private set;}
    public int CropYield  { get; private set;}    
    public int DaysUntilDeath  { get; private set;}
    public Seasons.Season GrowthSeason  { get; private set;}

    public Crop(string _CropName, string _CropDescription, int _DaysUntilMaxGrowth, 
                int _CropYield, int _DaysUntilDeath, Seasons.Season _GrowthSeason)
    {
        CropName = _CropName;
        CropDescription = _CropDescription;
        DaysUntilMaxGrowth = _DaysUntilMaxGrowth;
        CropYield = _CropYield;
        DaysUntilDeath = _DaysUntilDeath;
        GrowthSeason = _GrowthSeason;
    }
}
