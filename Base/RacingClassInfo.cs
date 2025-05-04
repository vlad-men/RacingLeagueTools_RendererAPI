namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public class RacingClassInfo
{
    public string UniqueName { get; set; }
    public string Name { get; set; }
    public string Abbreviation { get; set; }
    public Color Color { get; set; }
    public Color SecondaryColor { get; set; }
    public Color TertiaryColor { get; set; }
    public IList<RacingClassFactor> Factors { get; set; } = [];
    public RacingClassFactor FirstFactor => Factors.FirstOrDefault();
}