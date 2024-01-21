public class LeagueRoleRenderObject : RenderObject
{
    public LeagueRoleBuiltIn? LeagueRoleBuiltIn { get; set; }
    public bool IsIsBuiltInRole { get; set; }
    public Color Color { get; set; }
    public Color SecondaryColor { get; set; }
    public int Priority { get; set; }
}