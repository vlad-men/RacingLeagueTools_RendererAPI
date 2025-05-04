namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public class LeagueRoleRenderData : NamedRenderData
{
    public LeagueRoleBuiltIn? LeagueRoleBuiltIn { get; set; }
    public bool IsBuiltInRole { get; set; }
    public Color Color { get; set; }
    public Color SecondaryColor { get; set; }
    public Color TertiaryColor { get; set; }
    public int Priority { get; set; }
}