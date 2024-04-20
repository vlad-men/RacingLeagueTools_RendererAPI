namespace RacingLeagueTools.FlexRenderer.Models;
public class TeamSeasonRenderData : BaseRenderData
{
    public TeamRenderData Team { get; set; }
    public List<TeamEventRenderData> Events { get; set; }
    public bool IsShow { get; set; }
    public List<DriverSessionRenderData> MajorRaces { get; set; }
    public List<DriverSessionRenderData> MajorQuals { get; set; }
    public int PositionPrev { get; set; }
    public int Position { get; set; }
    public string PositionString { get; set; }
    public int PositionJump { get; set; }
    public PointsValue Points { get; set; }
    public PointsValue PointsToLeaderDiff { get; set; }
    public PointsValue PointsToAboveDiff { get; set; }
    public PointsValue PointsToBeyondDiff { get; set; }
    public int CountP1 { get; set; }
    public int CountP2 { get; set; }
    public int CountP3 { get; set; }
    public int BestPos { get; set; }
    public int BestPos1 { get; set; }
    public int BestPos2 { get; set; }
    public int BestPos3 { get; set; }
    public int BestPos1Count { get; set; }
    public int BestPos2Count { get; set; }
    public int BestPos3Count { get; set; }
    public int RacesCount { get; set; }
    public int QualCount { get; set; }
    public int EventsCount { get; set; }
    public int RaceFastestLapCount { get; set; }
    public int RaceDriverDayCount { get; set; }
    public int RaceBestMomentCount { get; set; }
    public int CountQualP1 { get; set; }
    public int BestPosQual { get; set; }
    public int PenaltyPoints { get; set; }
    public int CountDnf { get; set; }
    public int CountDns { get; set; }
    public int CountNotClassified { get; set; }
    public int CountTop3 { get; set; }
    public int CountTop5 { get; set; }
    public int CountTop10 { get; set; }
    public DriverSeasonRenderData Driver0 => Drivers.Count > 0 ? Drivers[0] : new DriverSeasonRenderData();
    public DriverSeasonRenderData Driver1 => Drivers.Count > 1 ? Drivers[1] : new DriverSeasonRenderData();
    public DriverSeasonRenderData Driver2 => Drivers.Count > 2 ? Drivers[2] : new DriverSeasonRenderData();
    public DriverSeasonRenderData Driver3 => Drivers.Count > 3 ? Drivers[3] : new DriverSeasonRenderData();
    public IList<DriverSeasonRenderData> Drivers { get; } = new List<DriverSeasonRenderData>();
}