namespace FarmGame;

public partial class TileState_Manager : Node
{
    TileState TileState = new TileState();
    Crop Crop;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {

    }

    public void UnwaterTileOnNewDay()
    {
        // WIP: Needs to check day status from Time.cs when implemented
        if (true)
        {
            TileState.SetWaterStatus(false);
            throw new NotImplementedException();    
        }
    }

    public void AdvanceCropStage()
    {
        // WIP: Needs to check day status from Time.cs when implemented
        if (true)
        {
            TileState.IncreaseGrowthStage();
            throw new NotImplementedException();    
        }
    }

    public void DestroyCrop()
    {
        // WIP: Needs to check day status from Time.cs when implemented
        if (true)
        {
            TileState.ResetTileToDefaultState();
            throw new NotImplementedException();    
        }
    }

        public void AddCrop()
    {
        if (TileState.IsTilled)
        {
            TileState.SetSeedStatus(true);
            throw new NotImplementedException();    
        }
    }
}
