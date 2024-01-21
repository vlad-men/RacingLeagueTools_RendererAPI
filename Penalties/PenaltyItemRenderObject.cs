public class PenaltyItemRenderObject : RenderObject
{
    public string PenaltyId { get; set; }
    public DriverRenderObject Driver { get; set; }
    public DriverRenderObject Issuer { get; set; }
    public DriverRenderObject Submitter { get; set; }
    public TeamRenderObject Team { get; set; }
    public CarRenderObject Car { get; set; }
    public SeasonRenderObject Season { get; set; }
    public SessionRenderObject Session { get; set; }
    public DriverSessionRenderObject DriverSession { get; set; }
    public int PenaltyPoints { get; set; }
    public int PenaltySeconds { get; set; }
    public int PenaltyPositions { get; set; }
    public int PenaltyWarnings { get; set; }
    public bool IsDisqualified { get; set; }
    public int PenaltySecondsOverall { get; set; } //including sum of penalty actions
    public int PenaltyPositionsOverall { get; set; } //including sum of penalty actions
    public bool IsDisqualifiedOverall { get; set; } //including sum of penalty actions
    public int PenaltyWarningsOverall { get; set; } //including sum of penalty actions
    public bool IsNoPunishment { get; set; }
    public bool IsCancelled { get; set; }
    public PenaltyOffenseRenderObject PenaltyOffense { get; set; }
    public string Offense { get; set; }
    public string Description { get; set; }
    public string Verdict { get; set; }
    public string Decision => Verdict;
    public string Details => Description;
    public string Lap { get; set; }
    public string Turn { get; set; }
    public DateTime Date { get; set; }
    public DateTime DateEvent { get; set; }
    public bool IsCreatedByUser { get; set; }
    public int SameOffenseRepeatedCount { get; set; }
    public List<DriverRenderObject> DriversInvolved { get; set; } = new List<DriverRenderObject>();
    public string DriversInvolvedString { get; set; }
    public bool IsInnerPenalty { get; set; } //penalty issued from session results page
    public bool IsHavePenaltyActions { get; set; }
    public List<PenaltyActionRenderObject> PenaltyActions { get; set; } = new List<PenaltyActionRenderObject>();
}
