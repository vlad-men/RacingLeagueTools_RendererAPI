namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.Standings.Details;

public class DriverSeasonParticipationDetails
{
    // events
    public int EventsParticipated { get; set; }
    public int TotalEventsExpected { get; set; }
    public string EventCompletionRatePercent { get; set; }

    // races
    public int TotalRacesCount { get; set; }
    public int TotalMajorRacesCount { get; set; }
    public int TotalRacesFinished { get; set; }
    public int TotalMajorRacesFinished { get; set; }
    public string RaceCompletionRatePercent { get; set; }
    public string MajorRaceCompletionRatePercent { get; set; }

    // quals
    public int TotalQualsCount { get; set; }
    public int TotalMajorQualsCount { get; set; }

    // practices
    public int TotalPracticesCount { get; set; }

    // totals
    public int TotalSessionsParticipated { get; set; }
}
