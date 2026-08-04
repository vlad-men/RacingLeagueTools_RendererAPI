namespace RacingLeagueTools.FlexRenderer.Models;

public class DriverSessionRenderData : BaseRenderData
{
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
    public TyreType? FastestLapTyres { get; set; }
    public TyreTypeInfo? FastestLapTyresInfo { get; set; }
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
    public Dictionary<QualificationType, DriverSessionRenderData> Segments { get; set; }
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
    public bool IsMostLapsLedDriver { get; set; }
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
    public string DriverPointsString => DriverPoints?.Value ?? string.Empty;
    public PointsValue TeamPoints { get; set; }
    public string TeamPointsString => TeamPoints?.Value ?? string.Empty;
    public SessionRenderData Session { get; set; }
    public string RaceNumber { get; set; }
    public bool IsHaveRaceNumber { get; set; }
    public int LapsCount { get; set; }
    public int GridPosition { get; set; }
    public int PositionJump { get; set; }
    public int PitsCount { get; set; }
    public ICollection<TyreStintInfo> Stints { get; set; }
    public TyreStintInfo Stint0 => Stints != null && Stints.Count > 0 ? Stints.ElementAt(0) : default;
    public TyreStintInfo Stint1 => Stints != null && Stints.Count > 1 ? Stints.ElementAt(1) : default;
    public TyreStintInfo Stint2 => Stints != null && Stints.Count > 2 ? Stints.ElementAt(2) : default;
    public TyreStintInfo Stint3 => Stints != null && Stints.Count > 3 ? Stints.ElementAt(3) : default;
    public TyreStintInfo Stint4 => Stints != null && Stints.Count > 4 ? Stints.ElementAt(4) : default;
    public ICollection<LapInfo> Laps { get; set; } = [];
    public LapInfo Lap0 => Laps != null && Laps.Count > 0 ? Laps.ElementAt(0) : new LapInfo();
    public LapInfo Lap1 => Laps != null && Laps.Count > 1 ? Laps.ElementAt(1) : new LapInfo();
    public LapInfo Lap2 => Laps != null && Laps.Count > 2 ? Laps.ElementAt(2) : new LapInfo();
    public LapInfo Lap3 => Laps != null && Laps.Count > 3 ? Laps.ElementAt(3) : new LapInfo();
    public LapInfo Lap4 => Laps != null && Laps.Count > 4 ? Laps.ElementAt(4) : new LapInfo();
    public LapInfo Lap5 => Laps != null && Laps.Count > 5 ? Laps.ElementAt(5) : new LapInfo();
    public int OvertakesCount { get; set; }
    public int LosePositionsCount { get; set; }
    public int MaxSpeed { get; set; }
    public int LeadLaps { get; set; }
    public int LeadDistance { get; set; }
    public int RaceDistancePercentage { get; set; }
    public string LiveryPath { get; set; }
    public ICollection<DriverFeatureInfo> DriverFeatures { get; set; } = [];
    public DriverFeatureInfo? PrimaryDriverFeature => DriverFeatures?.FirstOrDefault();
    public bool IsHaveDriverFeature => PrimaryDriverFeature is not null;
    public RacingClassInfo? RacingClass { get; set; }
    public bool IsHaveRacingClass => RacingClass is not null;
}