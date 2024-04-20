namespace RacingLeagueTools.FlexRenderer.Models;
public class StandingsSeasonRenderData : BaseRenderData
{
    public ICollection<DriverSeasonRenderData> Drivers { get; set; }
    public ICollection<TeamSeasonRenderData> Teams { get; set; }
    public EventRenderData LastEvent { get; set; }
    public int SeasonProgressPercent { get; set; }
    public DriverRenderObject DriverSeasonLeader { get; set; }
    public TeamRenderData TeamSeasonLeader { get; set; }
    public ICollection<EventRenderData> Events { get; set; }
    public bool IsPositionJumpForDriversExists { get; set; }
    public bool IsPositionJumpForTeamsExists { get; set; }
}