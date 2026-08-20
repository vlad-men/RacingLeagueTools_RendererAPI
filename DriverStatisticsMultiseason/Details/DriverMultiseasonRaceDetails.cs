namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.DriverStatisticsMultiseason.Details;

public class DriverMultiseasonRaceDetails
{
    public int TotalOvertakes { get; set; }
    public string AverageOvertakesPerRace { get; set; }
    public int FastestLapCount { get; set; }
    public int TotalLaps { get; set; }
    public int TotalLeadLaps { get; set; }
    public bool IsHasOvertakesData { get; set; }
    public bool IsHasLeadData { get; set; }
}
