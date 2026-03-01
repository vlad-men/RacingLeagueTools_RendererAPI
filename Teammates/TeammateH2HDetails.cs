namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.Teammates;

public class TeammateH2HDetails
{
    public DriverRenderData ContraDriver { get; set; }
    public int Wins { get; set; }
    public int Losses { get; set; }
    public int Draws { get; set; }
    public int Total { get; set; }
    public string WinsString { get; set; }
    public string LossesString { get; set; }
    public string DrawsString { get; set; }
    public string WinPercentageString { get; set; }
    public bool IsWinning { get; set; }
}
