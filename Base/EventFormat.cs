namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;

public class EventFormat
{
    public IList<EventSessionPreset> Presets { get; set; } = [];
    public EventSessionPreset PrimaryPreset { get; set; }
}
