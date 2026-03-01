namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.DriverStatisticsMultiseason;

public class DriverMultiseasonTrackEntry : BaseRenderData
{
    public TrackRenderData Track { get; set; }
    public int RaceCount { get; set; }
    public int Wins { get; set; }
    public int Podiums { get; set; }
    public int Poles { get; set; }
    public int BestRacePosition { get; set; }
    public string AverageRacePosition { get; set; }
    public PointsValue TotalPoints { get; set; }
}
