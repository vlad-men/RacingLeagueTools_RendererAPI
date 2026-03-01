namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.DriverStatisticsMultiseason.Details;

public class DriverMultiseasonParticipationDetails
{
    public int SeasonsParticipated { get; set; }
    public int TotalEvents { get; set; }
    public int TotalRaces { get; set; }
    public int TotalMajorRaces { get; set; }
    public int TotalQuals { get; set; }
    public int TotalMajorQuals { get; set; }
    public int TotalRacesFinished { get; set; }
    public string RaceCompletionRatePercent { get; set; }
    public string EventCompletionRatePercent { get; set; }
}
