namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public class ValueStatisticsRenderData : BaseRenderData
{
    public string Value { get; set; }
    public bool IsEnabled { get; set; }
    public bool IsHighlighted { get; set; }
    public object RawValue { get; set; }
    public ValueStatisticsType Type { get; set; } = ValueStatisticsType.Undefined;
    public int Level { get; set; }
    public IList<TyresStint> Stints { get; set; }
    public TyresType? Tyres { get; set; }
    public bool IsBig { get; set; }
    public bool IsSmall { get; set; }
}