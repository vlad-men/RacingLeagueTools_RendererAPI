namespace RacingLeagueTools.FlexRenderer.Models;
public class TrackRenderData : NamedRenderData
{
    public string CircuitName { get; set; }
    public string CircuitFullName { get; set; }
    public string LocationName { get; set; }
    public string Years { get; set; }
    public int Length { get; set; }
    public string CountryName { get; set; }
    public NationRenderData Nation { get; set; }
    public int NumberTurns { get; set; }
    public string RaceLapRecordTime { get; set; }
    public string RaceLapRecordDriverName { get; set; }
}