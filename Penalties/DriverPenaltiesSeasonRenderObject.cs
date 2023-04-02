public class DriverPenaltiesSeasonRenderObject : RenderObject
{
    public DriverRenderObject Driver { get; set; }
    public TeamRenderObject Team { get; set; }
    public CarRenderObject Car { get; set; }
    public List<PenaltyItemRenderObject> Penalties { get; set; }
    public List<PenaltyItemRenderObject> Actions { get; set; }
    public int PenaltyPointsActive { get; set; }
    public int PenaltyPointsOverall { get; set; }
    public int PenaltySeconds { get; set; }
    public int PenaltyPositions { get; set; }
    public int PenaltyIngameSeconds { get; set; }
    public int PenaltyIngamePositions { get; set; }
    public int PenaltyWarningsActive { get; set; }
    public int PenaltyWarningsOverall { get; set; }
}
