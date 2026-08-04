namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.TeamStatisticsMultiseason;

public class TeamStatisticsMultiseasonRenderData : BaseRenderData
{
    public TeamRenderData Team { get; set; }
    public string MultiSeasonName { get; set; }
    public int SeasonsCount { get; set; }

    // points
    public PointsValue TotalPoints { get; set; }

    // race positions
    public int Wins { get; set; }
    public int Podiums { get; set; }
    public int Poles { get; set; }
    public int RacesCount { get; set; }
    public int EventsCount { get; set; }

    public TeamStatMultiseasonParticipationDetails ParticipationDetails { get; set; } = new();
    public TeamStatMultiseasonPositionsDetails PositionsDetails { get; set; } = new();
    public TeamStatMultiseasonPointsDetails PointsDetails { get; set; } = new();
    public TeamStatMultiseasonTitlesDetails TitlesDetails { get; set; } = new();
    public TeamStatMultiseasonDisciplineDetails DisciplineDetails { get; set; } = new();
    public TeamStatMultiseasonRaceDetails RaceDetails { get; set; } = new();
    public TeamStatMultiseasonRosterDetails RosterDetails { get; set; } = new();

    public ICollection<TeamStatMultiseasonSeasonEntry> Seasons { get; set; } = [];
}
