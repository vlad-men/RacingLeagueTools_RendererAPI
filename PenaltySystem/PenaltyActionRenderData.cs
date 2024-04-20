namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public class PenaltyActionRenderData : BaseRenderData
{
    public PenaltyActionType Type { get; set; }
    public string TypeString { get; set; }
    public string TypeAbbreviature { get; set; }
    public string TypeShortDescription { get; set; }
    public bool IsHaveValue { get; set; }
    public int Value { get; set; }
    public string ValueDescription { get; set; }
    public string FullValueOnlyDescription { get; set; }
    public string FullTypeAndValueDescription { get; set; }
    public PenaltyActionStatus Status { get; set; }
    public bool IsActive { get; set; }
    public bool IsApplied { get; set; }
    public bool IsCancelled { get; set; }
    public bool IsFailed { get; set; }
    public SeasonRenderData TargetSeason { get; set; }
    public bool IsHaveOnlyOneSeasonAreaUi { get; set; }
    public string SeasonsAreaStringUi { get; set; }
    public IList<SeasonRenderData> SeasonsArea { get; set; }
    public DriverSessionRenderData TargetDriverSession { get; set; }
    public PenaltyItemRenderData PenaltyItem { get; set; }
    public DriverRenderObject Driver { get; set; }
}