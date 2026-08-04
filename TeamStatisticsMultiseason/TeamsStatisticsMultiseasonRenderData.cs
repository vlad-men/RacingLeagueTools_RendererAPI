namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.TeamStatisticsMultiseason;

public class TeamsStatisticsMultiseasonRenderData : BaseRenderData
{
    public string MultiSeasonName { get; set; }
    public int SeasonsCount { get; set; }
    public int TeamsCount { get; set; }
    public ICollection<SeasonRenderData> Seasons { get; set; } = [];
    public ICollection<TeamStatisticsMultiseasonRenderData> Teams { get; set; } = [];
}
