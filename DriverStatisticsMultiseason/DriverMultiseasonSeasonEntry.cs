namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.DriverStatisticsMultiseason;

public class DriverMultiseasonSeasonEntry : BaseRenderData
{
    public SeasonRenderData Season { get; set; }
    public string SeasonName { get; set; }
    public bool IsParticipated { get; set; }

    // points
    public PointsValue Points { get; set; }

    // standings position in this season
    public int Position { get; set; }
    public string PositionString { get; set; }

    // race positions
    public int Wins { get; set; }
    public int Podiums { get; set; }
    public int BestRacePosition { get; set; }
    public string AverageRacePosition { get; set; }

    // qual positions
    public string AverageQualPosition { get; set; }

    // participation
    public int RacesCount { get; set; }
    public int EventsCount { get; set; }

    // season completeness
    public bool IsSeasonCompleted { get; set; }
}
