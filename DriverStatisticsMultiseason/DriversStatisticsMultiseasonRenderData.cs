namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.DriverStatisticsMultiseason;

public class DriversStatisticsMultiseasonRenderData : BaseRenderData
{
    public string MultiSeasonName { get; set; }
    public int SeasonsCount { get; set; }
    public int DriversCount { get; set; }
    public ICollection<SeasonRenderData> Seasons { get; set; } = [];
    public ICollection<DriverStatisticsMultiseasonRenderData> Drivers { get; set; } = [];
}
