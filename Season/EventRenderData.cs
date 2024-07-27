namespace RacingLeagueTools.FlexRenderer.Models;
public class EventRenderData : BaseRenderData
{
    public int Position { get; set; }
    public string TrackName { get; set; }
    public string TrackCountryName { get; set; }
    public EventStatus EventStatus { get; set; }
    public bool IsChampionshipStatus { get; set; }
    public CompletedStatus CompletedStatus { get; set; }
    public Color Color { get; set; }
    public Color SecondaryColor { get; set; }
    public DateTime Date { get; set; }
    public DateTime DateLocal { get; set; }
    public DateTime DateGmt { get; set; }
    public TrackRenderData Track { get; set; }
    public string Description { get; set; }
    public ICollection<SessionRenderData> Races { get; set; }
    public ICollection<SessionRenderData> Quals { get; set; }
    public ICollection<SessionRenderData> Practices { get; set; }
    public bool IsFullQual { get; set; }
    public bool IsHaveSprintSessions { get; set; }
    public string WinnerString { get; set; }
}