namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public class DriverEventRenderData : BaseRenderData
{
    public EventRenderData Event { get; set; }
    public ICollection<DriverSessionRenderData> Races { get; set; }
    public ICollection<DriverSessionRenderData> Quals { get; set; }
    public ICollection<DriverSessionRenderData> Practices { get; set; }
    public ICollection<DriverSessionRenderData> MajorRaces { get; set; }
    public ICollection<DriverSessionRenderData> MajorQuals { get; set; }
    public ICollection<StandingsSessionRenderData> StandingsRaces { get; set; }
    public ICollection<StandingsSessionRenderData> StandingsQuals { get; set; }
    public ICollection<StandingsSessionRenderData> StandingsPractices { get; set; }

    public IEnumerable<StandingsSessionRenderData> AllStandingsSessions =>
        StandingsRaces.Concat(StandingsQuals).Concat(StandingsPractices);
    public DriverSessionRenderData MajorRace { get; set; }
    public DriverSessionRenderData MajorQual { get; set; }
    public PointsValue Points { get; set; }
    public string PointsString => Points.StringValue; //depricated
    public ICollection<int> RacesClassificationPosition { get; set; }
    public ICollection<int> RacesMajorClassificationPosition { get; set; }
    public ICollection<int> QualsClassificationPosition { get; set; }
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
    public bool IsMajorRaceFastestLap { get; set; }
    public bool IsMajorQualPole { get; set; }
}