namespace RacingLeagueTools.FlexRenderer.Models;
public class SessionRenderData : BaseRenderData
{
    public TrackRenderData Track { get; set; }
public SessionType SessionType { get; set; }
public RaceType RaceType { get; set; }
public QualificationType QualType { get; set; }
public string SessionTypeString { get; set; }
public CompletedStatus CompletedStatus { get; set; }
public DriverRenderData FastestLapDriver { get; set; }
public string FastestLapTime { get; set; }
public int FastestLapTimeMs { get; set; }
public TyresType FastestLapTyres { get; set; }
public int FastestLapNumLap { get; set; }
public bool IsRaceFastestLapCanBeAwardedPoints { get; set; }
public PointsValue RaceFastestLapAwardedDriverPoints { get; set; }
public PointsValue RaceFastestLapAwardedTeamPoints { get; set; }
public DriverRenderData DriverDayDriver { get; set; }
public DriverRenderData BestMomentDriver { get; set; }
public bool IsLiveData { get; set; }
public UInt64 LiveId { get; set; }
public DateTime LiveStartDate { get; set; }
public DateTime LiveEndDate { get; set; }
public DateTime LiveStartDateGmt { get; set; }
public DateTime LiveEndDateGmt { get; set; }
public DateTime LiveStartDateLocal { get; set; }
public DateTime LiveEndDateLocal { get; set; }
public bool IsSingleplayerMode { get; set; }
public ChampionshipType ChampionshipType { get; set; }
public WeatherType WeatherType { get; set; }
public int AirTemperature { get; set; }
public string AirTemperatureString { get; set; }
public int TrackTemperature { get; set; }
public int TotalLaps { get; set; }
public TimeSpan SessionDuration { get; set; }
public int SessionDurationMinutes { get; set; }
public bool IsCombinedQual { get; set; }
public bool IsMajorTypeRace { get; set; }
public int SafetyCarCount { get; set; }
public int VirtualSafetyCarCount { get; set; }
public ICollection<DriverSessionRenderData> Drivers { get; set; }
public int DriversCount => Drivers?.Count ?? 0;
public int TotalPitsCount => Drivers?.Sum(d => d.PitsCount) ?? 0;

public string FastestOverallSector1 { get; set; } 
public string FastestOverallSector2 { get; set; } 
public string FastestOverallSector3 { get; set; }
public string OverallSessionFastestLap { get; set; }
public int OverallSessionFastestLapMs { get; set; }
public DriverRenderData OverallSessionFastestLapDriver { get; set; }
}