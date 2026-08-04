namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.TeamStatisticsMultiseason.Details;

public class TeamStatMultiseasonPointsDetails
{
    public PointsValue AveragePointsPerSeason { get; set; }
    public PointsValue AveragePointsPerRace { get; set; }
    public PointsValue AveragePointsPerEvent { get; set; }
    public PointsValue BestSeasonPoints { get; set; }
    public PointsValue WorstSeasonPoints { get; set; }
    public PointsValue BestRacePoints { get; set; }
    public int ScoringRacesCount { get; set; }
    public string ScoringRatePercent { get; set; }
}
