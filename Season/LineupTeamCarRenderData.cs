namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public class LineupTeamCarRenderData : BaseRenderData
{
    public TeamRenderData Team { get; set; }
    public CarRenderData Car { get; set; }
    public IList<LineupRenderData> Lines { get; set; } = new List<LineupRenderData>();
    public LineupRenderData Line0 => Lines.Count >= 1 ? Lines[0] : null;
    public LineupRenderData Line1 => Lines.Count >= 2 ? Lines[1] : null;
    public LineupRenderData Line2 => Lines.Count >= 3 ? Lines[2] : null;
    public LineupRenderData Line3 => Lines.Count >= 4 ? Lines[3] : null;
}