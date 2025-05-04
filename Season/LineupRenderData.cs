namespace RacingLeagueTools.FlexRenderer.Models;
public class LineupRenderData : BaseRenderData
{
    public DriverRenderObject Driver { get; set; }
    public TeamRenderData Team { get; set; }
    public CarRenderData Car { get; set; }
    public DriverStatus SeatType { get; set; }
    public int SeatPosition { get; set; }
    public string Badge { get; set; }
    public int DriverRaces { get; set; }
    public int DriverSkips { get; set; }
    public bool IsDriverSet { get; set; }
    public bool IsCarSet { get; set; }
    public SeasonRenderData Season { get; set; }
    public bool IsNextTeam { get; set; }
    public LineupsBasedType LineupsBasedType { get; set; }
    public ICollection<DriverFeatureInfo> DriverFeatures { get; set; } = [];
    public DriverFeatureInfo? PrimaryDriverFeature => DriverFeatures.FirstOrDefault();
    public bool IsHaveDriverFeature => PrimaryDriverFeature is not null;
}