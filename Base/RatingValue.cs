namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.Base;

public struct RatingValue
{
    public float Value => ValueOutOf10;
    public string StringValue { get; init; }
    public float ValueOutOf10 { get; set; }
    public float ValueOutOf100 { get; set; }
    public float ValueOutOf1 { get; set; }
    public int Level { get; set; }
    public bool IsDefined { get; set; }
}
