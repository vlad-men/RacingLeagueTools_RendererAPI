namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public class EventPenaltiesRenderHost : BaseRenderData
{
    public EventRenderData Event { get; set; }
    public ICollection<PenaltyItemRenderData> Penalties { get; set; }
    public bool IsSinglePenalty => Penalties is { Count: 1 };
    public bool IsFullPenaltiesForEvent { get; set; }
}