namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.TeamStatisticsMultiseason;

public class TeamStatisticsMultiseasonSeasonEntry : BaseRenderData
{
    public SeasonRenderData Season { get; set; } = null!;
    public string SeasonName { get; set; } = string.Empty;
    public bool IsParticipated { get; set; }

    // Points
    public PointsValue Points { get; set; }

    // Standings position in this season
    public int Position { get; set; }
    public string PositionString { get; set; } = string.Empty;

    // Race positions
    public int Wins { get; set; }
    public int Podiums { get; set; }
    public int Top5 { get; set; }
    public int Top10 { get; set; }
    public int BestRacePosition { get; set; }
    public string AverageRacePosition { get; set; } = string.Empty;

    // Qual positions
    public string AverageQualPosition { get; set; } = string.Empty;

    // Participation
    public int RacesCount { get; set; }
    public int EventsCount { get; set; }

    // Change tracking (difference from previous multiseason snapshot)
    public PointsValue PointsChange { get; set; }
    public int WinsChange { get; set; }
    public int PodiumsChange { get; set; }
    public int Top5Change { get; set; }
    public int Top10Change { get; set; }
    public int RacesCountChange { get; set; }

    // Season completeness
    public bool IsSeasonCompleted { get; set; }
}
