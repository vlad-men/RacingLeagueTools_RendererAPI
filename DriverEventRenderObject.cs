public class DriverEventRenderObject : RenderObject
{
    public EventRenderObject Event { get; set; }
    public List<DriverSessionRenderObject> Races { get; set; }
    public List<DriverSessionRenderObject> Quals { get; set; }
    public List<DriverSessionRenderObject> MajorRaces { get; set; }
    public List<DriverSessionRenderObject> MajorQuals { get; set; }
    public string Points { get; set; }
    public List<int> RacesClassificationPosition { get; set; }
    public List<int> RacesMajorClassificationPosition { get; set; }
    public List<int> QualsClassificationPosition { get; set; }
    public int RacesCount { get; set; }
    public int RacesAllCount { get; set; }
    public int QualsCount { get; set; }
    public int RacesFinish { get; set; }
    public int RacesAllFinish { get; set; }
}
