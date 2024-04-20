namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public class DriverPenaltiesSeasonRenderData : BaseRenderData
{
    public DriverRenderObject Driver { get; set; }
    public TeamRenderData Team { get; set; }
    public CarRenderData Car { get; set; }
    public ICollection<PenaltyItemRenderData> AllPenalties { get; set; } = new List<PenaltyItemRenderData>();
    public ICollection<PenaltyActionRenderData> AllActions { get; set; } = new List<PenaltyActionRenderData>();
    public int PenaltyPointsActive { get; set; }
    public int PenaltyPointsOverall { get; set; }
    public int PenaltySeconds { get; set; }
    public int PenaltyPositions { get; set; }
    public int PenaltyIngameSeconds { get; set; }
    public int PenaltyIngamePositions { get; set; }
    public int PenaltyWarningsActive { get; set; }
    public int PenaltyWarningsOverall { get; set; }
    public int DisqualificationsOverall { get; set; }
    public int DisqualificationsStewardsOnly { get; set; }
    public int PenaltyActionsActiveSum { get; set; }
    public int PenaltyActionsSum { get; set; }
}