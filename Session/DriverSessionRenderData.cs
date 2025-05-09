namespace RacingLeagueTools.FlexRenderer.Models;
public class DriverSessionRenderData : BaseRenderData
{
    public string LiveryPath { get; set; } //to use, set ForceLiveriesLoading to true (see renderer manual)
    public int Position { get; set; }
    public string PositionString { get; set; }
    public string PositionIncludeStatus { get; set; }
    public int ClassificationPosition { get; set; }
    public DriverRenderObject Driver { get; set; }
    public TeamRenderData Team { get; set; }
    public CarRenderData Car { get; set; }
    public DriverStatus SeatType { get; set; }
    public int SeatPosition { get; set; }
    public DriverSessionStatus Status { get; set; }
    public string Time { get; set; }
    public int TimeMs { get; set; }
    public string IntervalRace { get; set; }
    public string AbsoluteTime { get; set; }
    public int AbsoluteTimeMs { get; set; }
    public string FastestLapTime { get; set; }
    public int FastestLapTimeMs { get; set; }
    public TyresType? FastestLapTyres { get; set; }
    public int FastestLapNumLap { get; set; }
    public int FastestLapSector1Ms { get; set; }
    public int FastestLapSector2Ms { get; set; }
    public int FastestLapSector3Ms { get; set; }
    public string FastestLapSector1 { get; set; }
    public string FastestLapSector2 { get; set; }
    public string FastestLapSector3 { get; set; }
    public bool IsOverallFastestSector1 { get; set; }
    public bool IsOverallFastestSector2 { get; set; }
    public bool IsOverallFastestSector3 { get; set; }
    public string QualQ1Time { get; set; }
    public string QualQ2Time { get; set; }
    public string QualQ3Time { get; set; }
    public int QualQ1TimeMs { get; set; }
    public int QualQ2TimeMs { get; set; }
    public int QualQ3TimeMs { get; set; }
    public int LapsCountQ1 { get; set; }
    public int LapsCountQ2 { get; set; }
    public int LapsCountQ3 { get; set; }
    public bool IsFinished { get; set; }
    public bool IsRaceFastestLap { get; set; }
    public bool IsRaceDriverOfDay { get; set; }
    public bool IsBestMomentDriver { get; set; }
    public int PenaltyTimeIngame { get; set; }
    public int PenaltyPosIngame { get; set; }
    public int PenaltyTimeStewards { get; set; }
    public int PenaltyPosStewards { get; set; }
    public int PenaltyTimeTotal { get; set; }
    public int PenaltyPosTotal { get; set; }
    public int PenaltyPoints { get; set; }
    public string PenaltyTimeStringLeftPart { get; set; }
    public string PenaltyTimeStringRightPart { get; set; }
    public PointsValue DriverPoints { get; set; }
    public string DriverPointsString => DriverPoints.Value; //deprecated
    public PointsValue TeamPoints { get; set; }
    public string TeamPointsString => TeamPoints.Value; //deperecated
    public SessionRenderData Session { get; set; }
    public int RaceNumber { get; set; }
    public bool IsHaveRaceNumber { get; set; }
    public int LapsCount { get; set; }
    public int GridPosition { get; set; }
    public int PositionJump { get; set; }
    public int PitsCount { get; set; }
    public ICollection<TyresStint> Stints { get; set; }
    public int OvertakesCount { get; set; }
    public int LosePositionsCount { get; set; }
    public int MaxSpeed { get; set; }
    public int LeadLaps { get; set; }
    public int LeadDistance { get; set; }
    public int RaceDistancePercentage { get; set; }
    public string LiveryPath { get; set; } //to use, set ForceLiveriesLoading to true (see renderer manual)
    public ICollection<DriverFeatureInfo> DriverFeatures { get; set; } = []; //info from season's lineups
    public DriverFeatureInfo? PrimaryDriverFeature => DriverFeatures.FirstOrDefault();
    public bool IsHaveDriverFeature => PrimaryDriverFeature is not null;
}