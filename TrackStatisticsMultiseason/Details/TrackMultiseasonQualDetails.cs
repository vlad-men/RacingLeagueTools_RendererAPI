namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.TrackStatisticsMultiseason.Details;

public class TrackMultiseasonQualDetails
{
    // fastest qualifying lap record
    public string FastestQualLapTime { get; set; }
    public DriverRenderData FastestQualLapDriver { get; set; }
    public TeamRenderData FastestQualLapTeam { get; set; }
    public SeasonRenderData FastestQualLapSeason { get; set; }
    public string FastestQualLapSeasonName { get; set; }

    // most poles
    public DriverRenderData MostPolesDriver { get; set; }
    public int MostPolesDriverCount { get; set; }
    public TeamRenderData MostPolesTeam { get; set; }
    public int MostPolesTeamCount { get; set; }
}
