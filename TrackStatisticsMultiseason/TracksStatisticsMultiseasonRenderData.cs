namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.TrackStatisticsMultiseason;

public class TracksStatisticsMultiseasonRenderData : BaseRenderData
{
    public string MultiSeasonName { get; set; }
    public int SeasonsCount { get; set; }
    public int TracksCount { get; set; }
    public ICollection<SeasonRenderData> Seasons { get; set; } = [];
    public ICollection<TrackStatisticsMultiseasonRenderData> Tracks { get; set; } = [];
}
