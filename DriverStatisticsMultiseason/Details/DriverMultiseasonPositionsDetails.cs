namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.DriverStatisticsMultiseason.Details;

public class DriverMultiseasonPositionsDetails
{
    // Race positions
    public int BestRacePosition { get; set; }
    public int WorstRacePosition { get; set; }
    public string AverageRacePosition { get; set; }
    public int RaceP1 { get; set; }
    public int RaceP2 { get; set; }
    public int RaceP3 { get; set; }
    public int Top5 { get; set; }
    public int Top10 { get; set; }
    public int TotalRaceFinishes { get; set; }

    // Grid positions
    public string AverageGridPosition { get; set; }
    public string AveragePositionChange { get; set; }

    // Qual positions
    public int BestQualPosition { get; set; }
    public int WorstQualPosition { get; set; }
    public string AverageQualPosition { get; set; }
    public int QualP1 { get; set; }
    public int QualP2 { get; set; }
    public int QualP3 { get; set; }
    public int FrontRowStarts { get; set; }
}