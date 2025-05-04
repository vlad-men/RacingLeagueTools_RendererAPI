namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public struct TyreStintInfo
{
    public TyreType Tyres { get; set; }
    public TyreTypeInfo TyresInfo { get; set; }
    public int Laps { get; set; }
    public bool IsPercentage { get; set; }
    public int Percentage { get; set; }
    public float PercentageFloat { get; set; }
    public int StartLapNumber { get; set; }
    public int EndLapNumber { get; set; }
    public int EndLapRaw { get; set; }
    public TyreWear WearAtStart { get; set; }
    public TyreWear WearAtEnd { get; set; }
}