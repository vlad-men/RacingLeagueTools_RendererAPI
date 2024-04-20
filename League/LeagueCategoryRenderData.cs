namespace RacingLeagueTools.FlexRenderer.Models;
public class LeagueCategoryRenderData : NamedRenderData
{
    public string ShortName { get; set; }
    public Color Color { get; set; }
    public Color SecondaryColor { get; set; }
    public int DriversCount { get; set; }
    public int SeasonsCount { get; set; }
}