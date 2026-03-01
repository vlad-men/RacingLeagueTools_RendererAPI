namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.Teammates;

public class TeammatesSeasonRenderData : BaseRenderData
{
    public TeamRenderData Team { get; set; }
    public ICollection<TeammateDriverRenderData> Drivers { get; set; } = [];
    public TeammateDriverRenderData Driver1 => Drivers.ElementAtOrDefault(0);
    public TeammateDriverRenderData Driver2 => Drivers.ElementAtOrDefault(1);
    public TeammateDriverRenderData Driver3 => Drivers.ElementAtOrDefault(2);
    public TeammateDriverRenderData Driver4 => Drivers.ElementAtOrDefault(3);
    public int SeasonProgressPercent { get; set; }
}
