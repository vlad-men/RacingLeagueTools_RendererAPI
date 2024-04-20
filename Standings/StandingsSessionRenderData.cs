namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public class StandingsSessionRenderData : BaseRenderData
{
    public DriverSessionRenderData DriverSession { get; set; }
    public SessionRenderData Session => DriverSession.Session;
    public bool IsSessionMajorForSeason { get; set; }
    public bool IsSessionMajor { get; set; }
    public PointsValue Points { get; set; }
    public PointsValue DiscardedPoints { get; set; }
    public bool IsSessionDiscarded => IsSessionOnlyPointsDiscarded || IsSessionFullyDiscarded;
    public bool IsSessionOnlyPointsDiscarded { get; set; }
    public bool IsSessionFullyDiscarded { get; set; }
}
