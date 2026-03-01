namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.DriverStatisticsMultiseason.Details;

public class DriverMultiseasonStandingsDetails
{
    public int Championships { get; set; }
    public string ChampionshipWinsString { get; set; }
    public int BestStandingsPosition { get; set; }
    public int WorstStandingsPosition { get; set; }
    public string AverageStandingsPosition { get; set; }
    public int RunnerUpFinishes { get; set; }
    public int TopThreeFinishes { get; set; }
    public int TopFiveFinishes { get; set; }
    public int TotalRoundsLeading { get; set; }
}
