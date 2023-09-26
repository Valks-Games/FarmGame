namespace FarmGame;

public partial class TileState : Node
{
    public bool IsWatered { get; private set; }
    public bool IsTilled { get; private set; }
    public bool IsSeeded { get; private set; }
    public int DaysSinceStateChange { get; private set; }
    public int CurrentGrowthStage { get; private set; }
    const int MaxGrowthStage = 5;

    public void SetWaterStatus(bool _isWatered)
    {
        if (IsWatered != _isWatered)
        {
            IsWatered = _isWatered;
            DaysSinceStateChange = 0;
        }
    }

    public void SetSeedStatus(bool _isSeeded)
    {
        if (IsTilled == true)
        {
            IsSeeded = _isSeeded;
            DaysSinceStateChange = 0;
        }
    }

    public void SetTillStatus(bool _isTilled)
    {
        if (IsTilled == false)
        {
            IsTilled = _isTilled;
            DaysSinceStateChange = 0;
        }
    }

    public void IncreaseGrowthStage()
    {
        // MaxGrowthStage will be the harvested state. 
        // MaxGrowthStage - 1 will be the crops fully grown stage.
        if (CurrentGrowthStage == MaxGrowthStage)
        {
            ResetTileToDefaultState();
        }
        else if (CurrentGrowthStage <= (MaxGrowthStage - 1) & IsSeeded == true)
        {
            CurrentGrowthStage++;
            DaysSinceStateChange = 0;
        }
    }

    public void ResetTileToDefaultState()
    {
        IsWatered = false;
        IsTilled = false;
        IsSeeded = false;
        DaysSinceStateChange = 0;
        CurrentGrowthStage = 0;
    }
}
