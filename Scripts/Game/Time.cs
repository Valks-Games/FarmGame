using System.Globalization;

namespace FarmGame;

public partial class Time : Label
{
    const int GAME_START_YEAR = 2023;
    const int GAME_START_MONTH = 3;
    const int GAME_START_DAY = 1;
    const int TIME_MULTIPLIER = 60;

    Global global;
    DateTime gameTime = new(GAME_START_YEAR, GAME_START_MONTH, GAME_START_DAY);

    public override void _Ready()
    {
        global = GetNode<Global>(Global.PATH);

        global.OnGameSaved += gameData =>
        {
            gameData.Time = gameTime.ToString();
        };

        global.OnGameLoaded += gameData =>
        {
            gameTime = DateTime.Parse(gameData.Time);
        };
    }

    public override void _PhysicsProcess(double delta)
    {
        UpdateTime(delta);
    }
    
    void UpdateTime(double delta)
    {
        gameTime = gameTime.AddSeconds(delta * TIME_MULTIPLIER);

        Text = 
            $"{GetAbbreviatedMonth(gameTime.Month)}, " +
            $"Day {gameTime.Day:00}, {gameTime.Hour:00}:{gameTime.Minute:00}";
    }

    static string GetAbbreviatedMonth(int month) => 
        CultureInfo.CurrentCulture.DateTimeFormat
            .GetAbbreviatedMonthName(month)
            .Replace(".", "");
}
