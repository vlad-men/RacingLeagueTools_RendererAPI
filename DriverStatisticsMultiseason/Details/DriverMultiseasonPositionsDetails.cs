namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.DriverStatisticsMultiseason.Details;

public class DriverMultiseasonPositionsDetails
{
    // race positions
    public int BestRacePosition { get; set; }
    public int WorstRacePosition { get; set; }
    public string AverageRacePosition { get; set; }
    public int Top5 { get; set; }
    public int Top10 { get; set; }
    public int TotalRaceFinishes { get; set; }

    // grid positions
    public string AverageGridPosition { get; set; }
    public string AveragePositionChange { get; set; }

    // qual positions
    public int BestQualPosition { get; set; }
    public int WorstQualPosition { get; set; }
    public string AverageQualPosition { get; set; }
    public int FrontRowStarts { get; set; }
}
