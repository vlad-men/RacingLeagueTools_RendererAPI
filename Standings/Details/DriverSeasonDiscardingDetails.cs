namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.Standings.Details;

public class DriverSeasonDiscardingDetails
{
    // status
    public bool IsDiscardEnabled { get; set; }
    public bool IsEventsDiscardMode { get; set; }
    public bool IsRacesDiscardMode { get; set; }

    // configuration
    public int ConfiguredDiscardEventsCount { get; set; }
    public int ConfiguredDiscardRacesCount { get; set; }
    public bool IsEventsFullDiscard { get; set; }
    public bool IsRacesFullDiscard { get; set; }

    // results
    public int DiscardedEventsCount { get; set; }
    public int DiscardedRacesCount { get; set; }
    public PointsValue TotalDiscardedPoints { get; set; }
    public string TotalDiscardedPointsString { get; set; }
}
