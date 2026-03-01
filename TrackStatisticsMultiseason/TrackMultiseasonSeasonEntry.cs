namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.TrackStatisticsMultiseason;

public class TrackMultiseasonSeasonEntry : BaseRenderData
{
    public SeasonRenderData Season { get; set; }
    public string SeasonName { get; set; }
    public int TotalEvents { get; set; }
    public int TotalRaces { get; set; }

    public string FastestLapTime { get; set; }
    public DriverRenderData FastestLapDriver { get; set; }

    public DriverRenderData RaceWinnerDriver { get; set; }
    public TeamRenderData RaceWinnerTeam { get; set; }
}
