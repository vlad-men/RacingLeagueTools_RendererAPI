public class TeamSeasonRenderObject : RenderObject
{
    public TeamRenderObject Team { get; set; }
    public List<TeamEventRenderObject> Events { get; set; }
    public bool IsShow { get; set; }
    public List<DriverSessionRenderObject> MajorRaces { get; set; }
    public List<DriverSessionRenderObject> MajorQuals { get; set; }
    public int PositionPrev { get; set; }
    public int Position { get; set; }
    public int PositionJump { get; set; }
    public string Points { get; set; }
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
    public int QualisWinCount { get; set; }
    public int BestPosQual { get; set; }
    public int PenaltyPoints { get; set; }
}
