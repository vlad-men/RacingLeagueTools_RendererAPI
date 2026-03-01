namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.Standings.Details;

public class DriverSeasonPositionsDetails
{
    // major race positions
    public int BestMajorRacePosition { get; set; }
    public int WorstMajorRacePosition { get; set; }
    public string AverageMajorRacePosition { get; set; }

    // major qual positions
    public int BestMajorQualPosition { get; set; }
    public int WorstMajorQualPosition { get; set; }
    public string AverageMajorQualPosition { get; set; }

    // all race positions
    public int BestAllRacePosition { get; set; }
    public int WorstAllRacePosition { get; set; }
    public string AverageAllRacePosition { get; set; }

    // all qual positions
    public int BestAllQualPosition { get; set; }
    public int WorstAllQualPosition { get; set; }
    public string AverageAllQualPosition { get; set; }

    // position change (grid to finish)
    public string AveragePositionChange { get; set; }

    // points metrics
    public PointsValue AveragePointsPerMajorRace { get; set; }
    public string AveragePointsPerMajorRaceString { get; set; }
    public int ScoringMajorRacesCount { get; set; }
    public int TotalMajorRacesForScoring { get; set; }
    public string ScoringRatePercent { get; set; }
}
