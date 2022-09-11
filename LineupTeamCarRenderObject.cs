public class LineupTeamCarRenderObject
{
    public TeamRenderObject Team { get; set; }
    public CarRenderObject Car { get; set; }
    public List<LineupRenderObject> Lines { get; set; } = new List<LineupRenderObject>();

    public LineupRenderObject Line0 => Lines.Count >= 1 ? Lines[0] : null;
    public LineupRenderObject Line1 => Lines.Count >= 2 ? Lines[1] : null;
    public LineupRenderObject Line2 => Lines.Count >= 3 ? Lines[2] : null;
    public LineupRenderObject Line3 => Lines.Count >= 4 ? Lines[3] : null;
}