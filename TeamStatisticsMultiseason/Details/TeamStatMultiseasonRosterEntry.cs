namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.TeamStatisticsMultiseason.Details;

public class TeamStatMultiseasonRosterEntry
{
    public DriverRenderData Driver { get; set; }
    public bool IsPrimaryLineup { get; set; }
    public int SeasonsCount { get; set; }
    public int MajorRacesCount { get; set; }
    public PointsValue Points { get; set; }
    public int Wins { get; set; }
    public int Podiums { get; set; }
    public int Poles { get; set; }
    public int DnfCount { get; set; }
    public int DsqCount { get; set; }
    public int BestRacePosition { get; set; }
    public string PointsSharePercent { get; set; }
}
