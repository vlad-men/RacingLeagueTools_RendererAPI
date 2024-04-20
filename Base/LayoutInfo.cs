namespace RacingLeagueTools.SharedLibrary.Models.Themes;
public readonly struct LayoutInfo
{
    public RenderType RenderType { get; }
    public RenderDataType RenderDataType { get; }
    public int RenderVersion { get; }
    public string SpecificCaptionType { get; }
}