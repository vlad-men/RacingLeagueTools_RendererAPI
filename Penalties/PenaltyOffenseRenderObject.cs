public class PenaltyOffenseRenderObject : RenderObject
{
    public int Position { get; set; }
    public string Paragraph { get; set; }
    public string Offense { get; set; }
    public string Description { get; set; }
    public int PenaltyPoints { get; set; }
    public int PenaltySeconds { get; set; }
    public int PenaltyPositions { get; set; }
    public int PenaltyWarnings { get; set; }
    public PenaltyActionType PenaltyActionType { get; set; }
    public int PenaltyActionValue { get; set; }
}
