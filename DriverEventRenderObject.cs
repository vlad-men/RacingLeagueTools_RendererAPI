public class DriverEventRenderObject : RenderObject
{
    public EventRenderObject Event { get; set; }
    public List<DriverSessionRenderObject> Races { get; set; }
    public List<DriverSessionRenderObject> Quals { get; set; }
    public List<DriverSessionRenderObject> MajorRaces { get; set; }
    public List<DriverSessionRenderObject> MajorQuals { get; set; }
    public DriverSessionRenderObject MajorRace {get; set; }
    public DriverSessionRenderObject MajorQual { get; set; }
    public int Points { get; set; }
    public string PointsString { get; set; }
    public List<int> RacesClassificationPosition { get; set; }
    public List<int> RacesMajorClassificationPosition { get; set; }
    public List<int> QualsClassificationPosition { get; set; }
    public int RacesCount { get; set; }
    public int RacesAllCount { get; set; }
    public int QualsCount { get; set; }
    public bool IsParticipiedEvent { get; set; }
    public DriverSessionStatus? RaceMajorStatus { get; set; }
    public DriverSessionStatus? QualMajorStatus { get; set; }
    public bool IsRaceMajorParticipied { get; set; }
    public bool IsQualMajorParticipied { get; set; }
    public bool IsRaceMajorClassified { get; set; }
    public bool IsQualMajorClassified { get; set; }
    public int RaceMajorPosition { get; set; }
    public int QualMajorPosition { get; set; }
    public string RaceMajorPositionString { get; set; }
    public string QualMajorPositionString { get; set; }
    public int PenaltyPoints { get; set; }
    public int PenaltyTimeGame { get; set; }
    public int PenaltyTimeStewards { get; set; }
    public int PenaltyPosGame { get; set; }
    public int PenaltyPosStewards { get; set; }
    public int PenaltyTimeSum { get; set; }
    public int PenaltyPosSum { get; set; }
    public bool IsWorstEvent { get; set; }
}
