namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public class DriverSessionRenderHost : BaseRenderData
{
    public DriverSessionRenderData Driver { get; set; }

    public DriverSessionRenderData Teammate0 => Teammates.Count >= 1 ? Teammates[0] : null;
    public DriverSessionRenderData Teammate1 => Teammates.Count >= 2 ? Teammates[1] : null;
    public DriverSessionRenderData Teammate2 => Teammates.Count >= 3 ? Teammates[2] : null;
    public DriverSessionRenderData Teammate3 => Teammates.Count >= 4 ? Teammates[3] : null;

    public IList<DriverSessionRenderData> Teammates { get; set; }
}