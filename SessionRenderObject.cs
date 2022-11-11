public class SessionRenderObject : RenderObject
{
    public TrackRenderObject Track { get; set; }
    public SessionType SessionType { get; set; }
    public RaceType RaceType { get; set; }
    public QualificationType QualType { get; set; }
    public CompletedStatus CompletedStatus { get; set; }
    public DriverRenderObject FastestLapDriver { get; set; }
    public string FastestLapTime { get; set; }
    public int FastestLapTimeMs { get; set; }
    public TyresType FastestLapTyres { get; set; }
    public int FastestLapNumLap { get; set; }
    public DriverRenderObject DriverDayDriver { get; set; }
    public DriverRenderObject BestMomentDriver { get; set; }
    public bool IsLiveData { get; set; }
    public UInt64 LiveId { get; set; }
    public DateTime LiveStartDate { get; set; }
    public DateTime LiveEndDate { get; set; }
    public DateTime LiveStartDateGmt { get; set; }
    public DateTime LiveEndDateGmt { get; set; }
    public bool IsSingleplayerMode { get; set; }
    public ChampionshipType ChampionshipType { get; set; }
    public WeatherType WeatherType { get; set; }
    public int AirTemperature { get; set; }
    public string AirTemperatureString { get; set; }
    public int TrackTemperature { get; set; }
    public int TotalLaps { get; set; }
    public TimeSpan SessionDuration { get; set; }
    public int SessionDurationMinutes { get; set; }
    public string FastestOverallSector1 { get; set; }
    public string FastestOverallSector2 { get; set; }
    public string FastestOverallSector3 { get; set; }
    public bool IsCombinedQual { get; set; }
    public bool IsMajorTypeRace { get; set; }
    public int SafetyCarCount { get; set; }
    public int VirtualSafetyCarCount { get; set; }
    public List<DriverSessionRenderObject> Drivers { get; set; }
}