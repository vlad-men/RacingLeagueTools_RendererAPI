namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.TeamStatisticsMultiseason.Details;

public class TeamStatMultiseasonRaceDetails
{
    public int TotalOvertakes { get; set; }
    public string AverageOvertakesPerRace { get; set; }
    public int FastestLapCount { get; set; }
    public int TotalLaps { get; set; }
    public int TotalLeadLaps { get; set; }
    public bool IsHasOvertakesData { get; set; }
    public bool IsHasLeadData { get; set; }
}
