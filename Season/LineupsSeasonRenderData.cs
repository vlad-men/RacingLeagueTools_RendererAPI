namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public class LineupsSeasonRenderData : BaseRenderData
{
    public IList<LineupRenderData> Lineups { get; set; }
    public ICollection<LineupRenderData> LineupsReserves { get; set; }
    public ICollection<LineupTeamCarRenderData> Teams { get; set; }
}