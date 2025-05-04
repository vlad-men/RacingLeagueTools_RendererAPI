namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public struct TyreWear
{
    public int IntValue { get; set; }
    public int FloatValue { get; set; }
    public string PercentValue => $"{IntValue}%";
    public bool IsHaveValue => IntValue > 0;
}