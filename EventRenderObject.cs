public class EventRenderObject : RenderObject
{
    public int Position { get; set; }
    public string TrackName { get; set; }
    public string TrackCountryName { get; set; }
    public EventStatus EventStatus { get; set; }
    public bool IsChampionshipStatus { get; set; }
    public CompletedStatus CompletedStatus { get; set; }
    public DateTime Date { get; set; }
    public TrackRenderObject Track { get; set; }
    public string Description { get; set; }
    public List<SessionRenderObject> Races { get; set; }
    public List<SessionRenderObject> Quals { get; set; }
    public List<SessionRenderObject> Practices { get; set; }
    public bool IsFullQual { get; set; }
    public string WinnerString { get; set; }
}
