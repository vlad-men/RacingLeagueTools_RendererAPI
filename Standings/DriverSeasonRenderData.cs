namespace RacingLeagueTools.FlexRenderer.Models;
public class DriverSeasonRenderData : BaseRenderData
{
    public string LiveryPath { get; set; } //to use, set ForceLiveriesLoading to true (see renderer manual)
    public DriverRenderObject Driver { get; set; }
    public DriverStatus DriverStatus { get; set; }
    public bool IsReserve { get; set; }
    public int SeatPosition { get; set; }
    public ICollection<DriverEventRenderData> Events { get; set; }
    public bool IsShow { get; set; }
    public TeamRenderData Team { get; set; }
    public CarRenderData Car { get; set; }
    public ICollection<DriverSessionRenderData> MajorRaces { get; set; }
    public ICollection<DriverSessionRenderData> MajorQuals { get; set; }
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
    public string BestPos { get; set; }
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
    public string LiveryPath { get; set; } //to use, set ForceLiveriesLoading to true (see renderer manual)
}