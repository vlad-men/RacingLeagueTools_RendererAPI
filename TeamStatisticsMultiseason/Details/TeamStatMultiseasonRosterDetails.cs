namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.TeamStatisticsMultiseason.Details;

public class TeamStatMultiseasonRosterDetails
{
    public int UniqueDriversCount { get; set; }
    public int PrimaryDriversCount { get; set; }
    public string TopScorerName { get; set; }
    public string TopScorerPoints { get; set; }
    public ICollection<TeamStatMultiseasonRosterEntry> Drivers { get; set; } = [];
}
