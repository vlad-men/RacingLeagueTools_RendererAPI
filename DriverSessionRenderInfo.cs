public class DriverSessionRenderInfo
{
    public DriverSessionRenderObject Driver { get; set; }
    
    public DriverSessionRenderObject Teammate0 => Teammates.Count >=1 ? Teammates[0] : null;
    public DriverSessionRenderObject Teammate1 => Teammates.Count >=2 ? Teammates[1] : null;
    public DriverSessionRenderObject Teammate2 => Teammates.Count >=3 ? Teammates[2] : null;
    public DriverSessionRenderObject Teammate3 => Teammates.Count >=4 ? Teammates[3] : null;
    
    public List<DriverSessionRenderObject> Teammates { get; set; }

}