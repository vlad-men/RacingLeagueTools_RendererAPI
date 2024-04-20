namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public abstract class NamedRenderData : BaseRenderData
{
    public string Name { get; set; }
    public string LogotypePath { get; set; }
    public Dictionary<LogotypeVariant, string> LogotypeVariants { get; set; } = new();
    public string DefaultLogotypePath => LogotypeVariants.GetValueOrDefault(LogotypeVariant.Default);
    public string AlternativeLogotypePath => LogotypeVariants.GetValueOrDefault(LogotypeVariant.Alternative);
    public string DarkLogotypePath => LogotypeVariants.GetValueOrDefault(LogotypeVariant.Dark);
    public string LightLogotypePath => LogotypeVariants.GetValueOrDefault(LogotypeVariant.Light);
    public string GrayedLogotypePath => LogotypeVariants.GetValueOrDefault(LogotypeVariant.Grayed);
}