namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.Teammates;

public class TeammateDriverRenderData
{
    public bool IsExist { get; set; }
    public DriverRenderData Driver { get; set; }
    public PointsValue TeamPoints { get; set; }
    public int EventsForTeam { get; set; }
    public int RacesForTeam { get; set; }
    public int QualsForTeam { get; set; }
    public int BestRacePosition { get; set; }
    public int BestQualPosition { get; set; }
    public int CountP1 { get; set; }
    public int CountP3 { get; set; }
    public int CountQualP1 { get; set; }

    public bool IsTeamPointsBest { get; set; }
    public bool IsRacesForTeamBest { get; set; }
    public bool IsQualsForTeamBest { get; set; }
    public bool IsEventsForTeamBest { get; set; }
    public bool IsBestRacePositionBest { get; set; }
    public bool IsBestQualPositionBest { get; set; }
    public bool IsCountP1Best { get; set; }
    public bool IsCountP3Best { get; set; }
    public bool IsCountQualP1Best { get; set; }

    public TeammateH2HDetails RaceH2H { get; set; }
    public TeammateH2HDetails QualH2H { get; set; }
    public TeammateH2HDetails AbsoluteRaceH2H { get; set; }
    public TeammateH2HDetails AbsoluteQualH2H { get; set; }
}
