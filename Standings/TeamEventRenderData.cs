namespace RacingLeagueTools.FlexRenderer.Models;
public class TeamEventRenderData : BaseRenderData
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
    public PointsValue Points { get; set; }
    public string PointsValue => Points.StringValue; //deprecated
    public ICollection<int> RacesClassificationPosition { get; set; }
    public ICollection<int> RacesMajorClassificationPosition { get; set; }
    public ICollection<int> QualsClassificationPosition { get; set; }
    public int RacesCount { get; set; }
    public int RacesAllCount { get; set; }
    public int QualsCount { get; set; }
    public int RacesFinish { get; set; }
    public int RacesAllFinish { get; set; }
    public int PenaltyPoints { get; set; }
    public int PenaltyTimeGame { get; set; }
    public int PenaltyTimeStewards { get; set; }
    public int PenaltyPosGame { get; set; }
    public int PenaltyPosStewards { get; set; }
    public int PenaltyTimeSum { get; set; }
    public int PenaltyPosSum { get; set; }
}