public class StandingsSeasonRenderObject : RenderObject
{
    public List<DriverSeasonRenderObject> Drivers { get; set; }
    public List<TeamSeasonRenderObject> Teams { get; set; }
    public EventRenderObject LastEvent { get; set; }
    public int SeasonProgressPercent { get; set; }
    public DriverRenderObject DriverSeasonLeader { get; set; }
    public TeamRenderObject TeamSeasonLeader { get; set; }
}
