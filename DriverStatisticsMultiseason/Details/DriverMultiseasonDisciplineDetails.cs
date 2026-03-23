namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.DriverStatisticsMultiseason.Details;

public class DriverMultiseasonDisciplineDetails
{
    public int DnfCount { get; set; }
    public int DsqCount { get; set; }
    public int TotalPenaltyPoints { get; set; }
    public int CleanRacesCount { get; set; }
    public string CleanRacePercent { get; set; }
    public string ReliabilityPercent { get; set; }
    public double DnfRate { get; set; }
    public double CleanRaceRate { get; set; }
    public int TotalStewardsPenaltySecs { get; set; }
    public double StewardsPenaltySecsPerRace { get; set; }
}
