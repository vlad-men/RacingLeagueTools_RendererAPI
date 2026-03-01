namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.TeamStandingsMultiseason;

public class TeamStandingsMultiseasonRenderData : BaseRenderData
{
    public string MultiSeasonName { get; set; }
    public int SeasonsCount { get; set; }
    public int TeamsCount { get; set; }
    public ICollection<SeasonRenderData> Seasons { get; set; } = [];
    public ICollection<TeamMultiseasonRenderData> Teams { get; set; } = [];
}