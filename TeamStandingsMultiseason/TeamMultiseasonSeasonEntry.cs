namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.TeamStandingsMultiseason;

public class TeamMultiseasonSeasonEntry : BaseRenderData
{
    public string SeasonName { get; set; }
    public SeasonRenderData Season { get; set; }
    public bool IsParticipated { get; set; }

    // points
    public PointsValue Points { get; set; }
    public PointsValue PointsChange { get; set; }

    // position in this season standings
    public int Position { get; set; }
    public string PositionString { get; set; }

    // race positions
    public int Wins { get; set; }
    public int Podiums { get; set; }
    public int Top5 { get; set; }
    public int Top10 { get; set; }
    public int BestRacePosition { get; set; }
    public string AverageRacePosition { get; set; }

    // qual positions
    public string AverageQualPosition { get; set; }

    // participation
    public int RacesCount { get; set; }
    public int EventsCount { get; set; }

    // change tracking (difference from previous round)
    public int WinsChange { get; set; }
    public int PodiumsChange { get; set; }
    public int Top5Change { get; set; }
    public int Top10Change { get; set; }
    public int RacesCountChange { get; set; }

    // season completeness
    public int RoundNumber { get; set; }
    public int TotalRounds { get; set; }
    public bool IsSeasonCompleted { get; set; }

    public ICollection<DriverRenderData> Drivers { get; set; } = [];
}
