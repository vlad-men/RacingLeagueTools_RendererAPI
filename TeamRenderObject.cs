public class TeamRenderObject : RenderObject
{
    public string FullName { get; set; }
    public string Abbreviation { get; set; }
    public Color Color { get; set; }
    public NationRenderObject Nation { get; set; }
    public CarRenderObject Car { get; set; }
    public string Badge { get; set; }
    public int Position { get; set; }
}
