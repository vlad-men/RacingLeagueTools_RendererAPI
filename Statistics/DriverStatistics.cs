public class DriverStatistics
{
    public DriverStatistics()
    {
        Values = new List<ValueStatistics>();
    }
    
    public DriverRenderObject Driver { get; set; }
    public TeamRenderObject Team { get; set; }
    public CarRenderObject Car { get; set; }

    public int Position { get; set; }
    public ValueStatistics Value0 => Values.Count > 0 ? Values[0] : new ValueStatistics() { IsEnabled = false };
    public ValueStatistics Value1 => Values.Count > 1 ? Values[1] : new ValueStatistics() { IsEnabled = false };
    public ValueStatistics Value2 => Values.Count > 2 ? Values[2] : new ValueStatistics() { IsEnabled = false };
    public ValueStatistics Value3 => Values.Count > 3 ? Values[3] : new ValueStatistics() { IsEnabled = false };
    public ValueStatistics Value4 => Values.Count > 4 ? Values[4] : new ValueStatistics() { IsEnabled = false };
    public ValueStatistics Value5 => Values.Count > 5 ? Values[5] : new ValueStatistics() { IsEnabled = false };
    public ValueStatistics Value6 => Values.Count > 6 ? Values[6] : new ValueStatistics() { IsEnabled = false };
    public ValueStatistics Value7 => Values.Count > 7 ? Values[7] : new ValueStatistics() { IsEnabled = false };

    public List<ValueStatistics> Values { get; }
}