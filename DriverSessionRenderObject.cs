﻿public class DriverSessionRenderObject : RenderObject
{
    public int Position { get; set; }
    public string PositionString { get; set; }
    public int ClassificationPosition { get; set; }
    public DriverRenderObject Driver { get; set; }
    public TeamRenderObject Team { get; set; }
    public CarRenderObject Car { get; set; }
    public DriverStatus SeatType { get; set; }
    public DriverSessionStatus Status { get; set; }
    public string Time { get; set; }
    public int TimeMs { get; set; }
    public string IntervalRace { get; set; }
    public string AbsoluteTime { get; set; }
    public int AbsoulteTimeMs { get; set; }
    public string FastestLapTime { get; set; }
    public int FastestLapTimeMs { get; set; }
    public TyresType? FastestLapTyres { get; set; }
    public int FastestLapNumLap { get; set; }
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
    public string PenaltyTimeStringLeftPart { get; set; }
    public string PenaltyTimeStringRightPart { get; set; }
    public string DriverPointsString { get; set; }
    public string TeamPointsString { get; set; }
    public SessionRenderObject Session { get; set; }
    public int RaceNumber { get; set; }
    public bool IsHaveRaceNumber { get; set; }
    public int LapsCount { get; set; }
    public int GridPosition { get; set; }
    public int PositionJump { get; set; }
    public int PitsCount { get; set; }
    public List<TyresStint> Stints { get; set; } 


}