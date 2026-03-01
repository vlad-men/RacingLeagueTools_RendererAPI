namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.DeepRatingsSeason;

public class DeepRatingsSeasonRenderData : BaseRenderData
{
    public ICollection<DriverSeasonRenderData> Drivers { get; set; }
    public EventRenderData LastEvent { get; set; }
    public int SeasonProgressPercent { get; set; }
    public ICollection<EventRenderData> Events { get; set; }
}
