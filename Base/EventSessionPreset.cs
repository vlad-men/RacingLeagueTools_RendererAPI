namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;

public class EventSessionPreset
{
    public string Name { get; set; }
    public IList<EventSessionDescription> Sessions { get; set; } = [];
    public bool IsPrimary { get; set; }
}