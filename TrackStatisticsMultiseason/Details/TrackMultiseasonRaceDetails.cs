namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.TrackStatisticsMultiseason.Details;

public class TrackMultiseasonRaceDetails
{
    // fastest race lap record
    public string FastestLapTime { get; set; }
    public DriverRenderData FastestLapDriver { get; set; }
    public TeamRenderData FastestLapTeam { get; set; }
    public SeasonRenderData FastestLapSeason { get; set; }
    public string FastestLapSeasonName { get; set; }

    // most wins
    public DriverRenderData MostWinsDriver { get; set; }
    public int MostWinsDriverCount { get; set; }
    public TeamRenderData MostWinsTeam { get; set; }
    public int MostWinsTeamCount { get; set; }

    // most podiums
    public DriverRenderData MostPodiumsDriver { get; set; }
    public int MostPodiumsDriverCount { get; set; }
    public TeamRenderData MostPodiumsTeam { get; set; }
    public int MostPodiumsTeamCount { get; set; }

    // averages
    public string AvgPitstops { get; set; }
    public string AvgOvertakes { get; set; }
    public string AvgDuration { get; set; }
    public bool IsHaveOvertakesData { get; set; }
}
