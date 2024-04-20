namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public class SeasonPenaltiesRenderHost : BaseRenderData
{
    public SeasonRenderData Season { get; set; }
    public ICollection<DriverPenaltiesSeasonRenderData> Drivers { get; set; }
}