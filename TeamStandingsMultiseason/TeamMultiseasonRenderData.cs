namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.TeamStandingsMultiseason;

public class TeamMultiseasonRenderData : BaseRenderData
{
    public TeamRenderData Team { get; set; }
    public int Position { get; set; }
    public string PositionString { get; set; }
    public int PositionJump { get; set; }
    public bool IsNewEntry { get; set; }
    public PointsValue Points { get; set; }
    public PointsValue PointsChange { get; set; }
    public PointsValue AveragePointsPerRace { get; set; }

    // race positions
    public int Wins { get; set; }
    public int Podiums { get; set; }
    public int Top5 { get; set; }
    public int Top10 { get; set; }
    public int BestRacePosition { get; set; }
    public int WorstRacePosition { get; set; }
    public string AverageRacePosition { get; set; }
    public int TotalFinishes { get; set; }

    // qual positions
    public int Poles { get; set; }
    public int FrontRowStarts { get; set; }
    public int BestQualPosition { get; set; }
    public int WorstQualPosition { get; set; }
    public string AverageQualPosition { get; set; }
    public int TotalQualifications { get; set; }

    // participation
    public int RacesCount { get; set; }
    public int EventsCount { get; set; }
    public int TotalEntries { get; set; }

    public ICollection<TeamMultiseasonSeasonEntry> Seasons { get; set; } = [];
}
