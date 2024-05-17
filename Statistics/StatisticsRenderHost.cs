namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public class StatisticsRenderHost : BaseRenderData
{
    public string Header { get; set; }
    public string SubHeader { get; set; }
    public string Description { get; set; }
    public string StatisticsTypeString { get; set; } //can be one of SeasonStatisticsType / SessionStatisticsType enum value
    public List<DriverStatisticsRenderData> Drivers { get; } = new();

    public ValueStatisticsColumnRenderData Column0 =>
        Columns.Count > 0 ? Columns[0] : new ValueStatisticsColumnRenderData() { IsEnabled = false };

    public ValueStatisticsColumnRenderData Column1 =>
        Columns.Count > 1 ? Columns[1] : new ValueStatisticsColumnRenderData() { IsEnabled = false };

    public ValueStatisticsColumnRenderData Column2 =>
        Columns.Count > 2 ? Columns[2] : new ValueStatisticsColumnRenderData() { IsEnabled = false };

    public ValueStatisticsColumnRenderData Column3 =>
        Columns.Count > 3 ? Columns[3] : new ValueStatisticsColumnRenderData() { IsEnabled = false };

    public ValueStatisticsColumnRenderData Column4 =>
        Columns.Count > 4 ? Columns[4] : new ValueStatisticsColumnRenderData() { IsEnabled = false };

    public ValueStatisticsColumnRenderData Column5 =>
        Columns.Count > 5 ? Columns[5] : new ValueStatisticsColumnRenderData() { IsEnabled = false };

    public ValueStatisticsColumnRenderData Column6 =>
        Columns.Count > 6 ? Columns[6] : new ValueStatisticsColumnRenderData() { IsEnabled = false };

    public ValueStatisticsColumnRenderData Column7 =>
        Columns.Count > 7 ? Columns[7] : new ValueStatisticsColumnRenderData() { IsEnabled = false };

    public ValueStatisticsColumnRenderData Column8 =>
        Columns.Count > 8 ? Columns[8] : new ValueStatisticsColumnRenderData() { IsEnabled = false };

    public ValueStatisticsColumnRenderData Column9 =>
        Columns.Count > 9 ? Columns[9] : new ValueStatisticsColumnRenderData() { IsEnabled = false };

    public ValueStatisticsColumnRenderData Column10 =>
        Columns.Count > 10 ? Columns[10] : new ValueStatisticsColumnRenderData() { IsEnabled = false };


    public List<ValueStatisticsColumnRenderData> Columns { get; } = new();
}