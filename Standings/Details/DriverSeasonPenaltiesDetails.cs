namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.Standings.Details;

public class DriverSeasonPenaltiesDetails
{
    // penalty points
    public int TotalPenaltyPoints { get; set; }

    // time penalties
    public int TotalPenaltySecsIngame { get; set; }
    public int TotalPenaltySecsStewards { get; set; }
    public int TotalPenaltyTime { get; set; }

    // position penalties
    public int TotalPenaltyPosIngame { get; set; }
    public int TotalPenaltyPosStewards { get; set; }
    public int TotalPenaltyPositions { get; set; }

    // incidents
    public int DnfCount { get; set; }
    public int DsqCount { get; set; }
}
