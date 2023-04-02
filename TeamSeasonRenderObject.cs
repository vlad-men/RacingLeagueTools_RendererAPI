public class TeamSeasonRenderObject : RenderObject
{
    public TeamRenderObject Team { get; set; }
    public List<TeamEventRenderObject> Events { get; set; }
    public bool IsShow { get; set; }
    public List<DriverSessionRenderObject> MajorRaces { get; set; }
    public List<DriverSessionRenderObject> MajorQuals { get; set; }
    public int PositionPrev { get; set; }
    public int Position { get; set; }
    public string PositionString { get; set; }
    public int PositionJump { get; set; }
    public string Points { get; set; }
    public float PointsRaw { get; set; }
    public float PointsToLeaderDiff { get; set; }
    public float PointsToAboveDiff { get; set; }
    public float PointsToBeyondDiff { get; set; }
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
    public DriverSeasonRenderObject Driver0 => Drivers.Count > 0 ? Drivers[0] : new DriverSeasonRenderObject();
    public DriverSeasonRenderObject Driver1 => Drivers.Count > 1 ? Drivers[1] : new DriverSeasonRenderObject();
    public DriverSeasonRenderObject Driver2 => Drivers.Count > 2 ? Drivers[2] : new DriverSeasonRenderObject();
    public DriverSeasonRenderObject Driver3 => Drivers.Count > 3 ? Drivers[3] : new DriverSeasonRenderObject();
    public List<DriverSeasonRenderObject> Drivers { get; } = new();
}