namespace RacingLeagueTools.FlexRenderer.Models;
public class TeamRenderData : NamedRenderData
{
    public string FullName { get; set; }
    public string Abbreviation { get; set; }
    public Color Color { get; set; }
    public Color SecondaryColor { get; set; }
    public NationRenderData Nation { get; set; }
    public CarRenderData Car { get; set; }
    public string Badge { get; set; }
    public int Position { get; set; }
}