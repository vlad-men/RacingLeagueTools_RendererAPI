namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.Base;

public class LapInfo
{
    public int LapNumber { get; set; }
    public string LapTime { get; set; } = string.Empty;
    public int LapTimeMs { get; set; }
    public string Sector1 { get; set; } = string.Empty;
    public int Sector1Ms { get; set; }
    public string Sector2 { get; set; } = string.Empty;
    public int Sector2Ms { get; set; }
    public string Sector3 { get; set; } = string.Empty;
    public int Sector3Ms { get; set; }
    public TyreType Tyres { get; set; }
    public TyreTypeInfo TyresInfo { get; set; }
    public bool IsLapValid { get; set; }
    public bool IsSector1Valid { get; set; }
    public bool IsSector2Valid { get; set; }
    public bool IsSector3Valid { get; set; }
    public bool IsPersonalBest { get; set; }
    public bool IsSessionFastest { get; set; }
    public int StintNumber { get; set; }
    public int LapInStint { get; set; }
    public bool IsStintStart { get; set; }
    public bool IsStintEnd { get; set; }
    public string DeltaToPreviousLap { get; set; } = string.Empty;
    public int DeltaToPreviousLapMs { get; set; }
    public string DeltaToPersonalBest { get; set; } = string.Empty;
    public int DeltaToPersonalBestMs { get; set; }
}
