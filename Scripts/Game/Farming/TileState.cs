public partial class TileState : Node
{
    public bool IsWatered { get; private set;} = false;
    public bool IsTilled { get; private set;} = false;
    public bool IsSeeded { get; private set;} = false;
    public int DaysSinceStateChange { get; private set;} = 0;
    public int GrowthStage { get; private set;} = 0;

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
        if  (IsTilled == true & _isSeeded == true)
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
        // Plants will have 4 growth stages, the 5th stage will represent the harvested state.
        if (GrowthStage == 5)
        {
            ResetTileToDefaultState();
        }
        else if (GrowthStage < 4 & IsSeeded != false)
        {
            GrowthStage++;
            DaysSinceStateChange = 0;
        }
    }

    public void ResetTileToDefaultState()
    {
        IsWatered = false;
        IsTilled = false;
        IsSeeded = false;
        DaysSinceStateChange = 0;
        GrowthStage = 0;
    }
}
