namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.DriverStatisticsMultiseason;

public class DriverStatisticsMultiseasonRenderData : BaseRenderData
{
    public DriverRenderData Driver { get; set; }
    public string MultiSeasonName { get; set; }
    public int SeasonsCount { get; set; }

    public PointsValue TotalPoints { get; set; }
    public int Wins { get; set; }
    public int Podiums { get; set; }
    public int Poles { get; set; }
    public int RacesCount { get; set; }
    public int EventsCount { get; set; }

    public DriverMultiseasonParticipationDetails ParticipationDetails { get; set; } = new();
    public DriverMultiseasonPositionsDetails PositionsDetails { get; set; } = new();
    public DriverMultiseasonPointsDetails PointsDetails { get; set; } = new();
    public DriverMultiseasonStandingsDetails StandingsDetails { get; set; } = new();
    public DriverMultiseasonDisciplineDetails DisciplineDetails { get; set; } = new();
    public DriverMultiseasonPerformanceDetails PerformanceDetails { get; set; } = new();

    public ICollection<DriverMultiseasonSeasonEntry> Seasons { get; set; } = [];
    public ICollection<DriverMultiseasonTrackEntry> Tracks { get; set; } = [];
}
