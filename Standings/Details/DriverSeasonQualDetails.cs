namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.Standings.Details;

public class DriverSeasonQualDetails
{
    // position stats
    public int BestQualPosition { get; set; }
    public int WorstQualPosition { get; set; }
    public string AverageQualPosition { get; set; }

    // pole positions
    public int PoleCount { get; set; }
    public int FrontRowCount { get; set; }

    // top finishes
    public int CountTop3 { get; set; }
    public int CountTop5 { get; set; }
    public int CountTop10 { get; set; }

    // participation
    public int TotalQualsCount { get; set; }
    public int TotalMajorQualsCount { get; set; }
}
