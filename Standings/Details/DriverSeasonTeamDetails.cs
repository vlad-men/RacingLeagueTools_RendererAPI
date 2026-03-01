namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.Standings.Details;

public class DriverSeasonTeamDetails
{
    // current / primary team
    public TeamRenderData? LineUpTeam { get; set; }
    public TeamRenderData? LastRaceTeam { get; set; }
    public TeamRenderData? MostFrequentTeam { get; set; }

    // multi-team info
    public int TotalTeamsCount { get; set; }
    public bool HasTeamChanges { get; set; }
    public bool HasMultipleTeams { get; set; }
    public int TeamChangesCount { get; set; }

    // driver status
    public DriverStatus LineUpStatus { get; set; }
    public DriverStatus LastRaceStatus { get; set; }
    public DriverStatus MostFrequentStatus { get; set; }
    public bool HasStatusChanges { get; set; }
    public int StatusChangesCount { get; set; }
    public bool IsPrimaryDriver { get; set; }
    public bool IsReserveDriver { get; set; }
}
