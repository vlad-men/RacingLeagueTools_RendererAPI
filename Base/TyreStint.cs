namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;

public struct TyreStint
{
    public TyresType Tyres { get; set; }
    public int Laps { get; set; }
    public int Percentage { get; set; }
    public bool IsPercentage { get; set; }
    public int StartLapNumber { get; set; }
    public int EndLapNumber { get; set; }
    public int EndLapRaw { get; set; }
}