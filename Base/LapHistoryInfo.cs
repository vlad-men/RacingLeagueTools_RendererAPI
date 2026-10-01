namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.Base;

public class LapPositionInfo
{
    public int Lap { get; set; }
    public int? Position { get; set; }
    public bool IsEstimated { get; set; }
}

public class WeatherPointInfo
{
    public int Lap { get; set; }
    public int TimeMs { get; set; }
    public string Time { get; set; } = string.Empty;
    public WeatherType Weather { get; set; }
    public string WeatherString { get; set; } = string.Empty;
    public int AirTemperature { get; set; }
    public int TrackTemperature { get; set; }
}

public class TrackStatusPeriodInfo
{
    public string Kind { get; set; } = string.Empty; //"SC" or "VSC"
    public bool IsVirtual { get; set; }
    public int StartLap { get; set; }
    public int EndLap { get; set; }
    public int LapsCount => StartLap > 0 && EndLap >= StartLap ? EndLap - StartLap + 1 : 0;
    public int DurationMs { get; set; }
    public string Duration { get; set; } = string.Empty;
}
