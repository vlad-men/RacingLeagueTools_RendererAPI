public class PenaltiesHostRenderObject
{
    public EventRenderObject Event { get; set; }
    public List<PenaltyItemRenderObject> Penalties { get; set; }
    public bool IsSinglePenalty => Penalties is { Count: 1 };
    public bool IsFullPenaltiesForEvent { get; set; }
}
