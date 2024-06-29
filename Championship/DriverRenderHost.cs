namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public class DriverRenderHost : BaseRenderData
{
    public DriverRenderData Driver { get; set; }
    public DriverSeasonRenderData DriverSeason { get; set; }
    public TeamRenderData Team { get; set; }
    public CarRenderData Car { get; set; }

    public DriverRenderObject Teammate0 => Teammates.Count >= 1 ? Teammates[0] : null;
    public DriverRenderObject Teammate1 => Teammates.Count >= 2 ? Teammates[1] : null;
    public DriverRenderObject Teammate2 => Teammates.Count >= 3 ? Teammates[2] : null;
    public DriverRenderObject Teammate3 => Teammates.Count >= 4 ? Teammates[3] : null;

    public DriverSeasonRenderData TeammateSeason0 => TeammatesSeason.Count >= 1 ? TeammatesSeason[0] : null;
    public DriverSeasonRenderData TeammateSeason1 => TeammatesSeason.Count >= 2 ? TeammatesSeason[1] : null;
    public DriverSeasonRenderData TeammateSeason2 => TeammatesSeason.Count >= 3 ? TeammatesSeason[2] : null;
    public DriverSeasonRenderData TeammateSeason3 => TeammatesSeason.Count >= 4 ? TeammatesSeason[3] : null;

    public List<DriverRenderObject> Teammates { get; set; }
    public List<DriverSeasonRenderData> TeammatesSeason { get; set; }
}