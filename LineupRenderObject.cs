public class LineupRenderObject : RenderObject
{
    public DriverRenderObject Driver { get; set; }
    public TeamRenderObject Team { get; set; }
    public CarRenderObject Car { get; set; }
    public DriverStatus SeatType { get; set; }
    public int SeatPosition { get; set; }
    public string Badge { get; set; }
    public int DriverRaces { get; set; }
    public int DriverSkips { get; set; }
    public bool IsDriverSet { get; set; }
    public bool IsCarSet { get; set; }
    public SeasonRenderObject Season { get; set; }
    public bool IsNextTeam { get; set; }

    public LineupsBasedType LineupsBasedType { get; set; }

}
