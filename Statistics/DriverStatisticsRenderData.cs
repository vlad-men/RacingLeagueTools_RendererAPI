namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public class DriverStatisticsRenderData : BaseRenderData
{
    public DriverRenderObject Driver { get; set; }
    public TeamRenderData Team { get; set; }
    public CarRenderData Car { get; set; }

    public int Position { get; set; }
    public ValueStatisticsRenderData Value0 => Values.Count > 0 ? Values[0] : new ValueStatisticsRenderData() { IsEnabled = false };
    public ValueStatisticsRenderData Value1 => Values.Count > 1 ? Values[1] : new ValueStatisticsRenderData() { IsEnabled = false };
    public ValueStatisticsRenderData Value2 => Values.Count > 2 ? Values[2] : new ValueStatisticsRenderData() { IsEnabled = false };
    public ValueStatisticsRenderData Value3 => Values.Count > 3 ? Values[3] : new ValueStatisticsRenderData() { IsEnabled = false };
    public ValueStatisticsRenderData Value4 => Values.Count > 4 ? Values[4] : new ValueStatisticsRenderData() { IsEnabled = false };
    public ValueStatisticsRenderData Value5 => Values.Count > 5 ? Values[5] : new ValueStatisticsRenderData() { IsEnabled = false };
    public ValueStatisticsRenderData Value6 => Values.Count > 6 ? Values[6] : new ValueStatisticsRenderData() { IsEnabled = false };
    public ValueStatisticsRenderData Value7 => Values.Count > 7 ? Values[7] : new ValueStatisticsRenderData() { IsEnabled = false };
    public ValueStatisticsRenderData Value8 => Values.Count > 8 ? Values[8] : new ValueStatisticsRenderData() { IsEnabled = false };
    public ValueStatisticsRenderData Value9 => Values.Count > 9 ? Values[9] : new ValueStatisticsRenderData() { IsEnabled = false };
    public ValueStatisticsRenderData Value10 => Values.Count > 10 ? Values[10] : new ValueStatisticsRenderData() { IsEnabled = false };


    public List<ValueStatisticsRenderData> Values { get; } = new();
}