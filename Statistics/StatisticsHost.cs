public class StatisticsHost : RenderObject
{
    public string Header { get; set; }
    public string SubHeader { get; set; }
    public string Description { get; set; }
    public List<DriverStatistics> Drivers { get; } = new();

    public ValueStatisticsColumn Column0 =>
        Columns.Count > 0 ? Columns[0] : new ValueStatisticsColumn() { IsEnabled = false };

    public ValueStatisticsColumn Column1 =>
        Columns.Count > 1 ? Columns[1] : new ValueStatisticsColumn() { IsEnabled = false };

    public ValueStatisticsColumn Column2 =>
        Columns.Count > 2 ? Columns[2] : new ValueStatisticsColumn() { IsEnabled = false };

    public ValueStatisticsColumn Column3 =>
        Columns.Count > 3 ? Columns[3] : new ValueStatisticsColumn() { IsEnabled = false };

    public ValueStatisticsColumn Column4 =>
        Columns.Count > 4 ? Columns[4] : new ValueStatisticsColumn() { IsEnabled = false };

    public ValueStatisticsColumn Column5 =>
        Columns.Count > 5 ? Columns[5] : new ValueStatisticsColumn() { IsEnabled = false };

    public ValueStatisticsColumn Column6 =>
        Columns.Count > 6 ? Columns[6] : new ValueStatisticsColumn() { IsEnabled = false };

    public ValueStatisticsColumn Column7 =>
        Columns.Count > 7 ? Columns[7] : new ValueStatisticsColumn() { IsEnabled = false };

    public ValueStatisticsColumn Column8 =>
        Columns.Count > 8 ? Columns[8] : new ValueStatisticsColumn() { IsEnabled = false };

    public ValueStatisticsColumn Column9 =>
        Columns.Count > 9 ? Columns[9] : new ValueStatisticsColumn() { IsEnabled = false };

    public ValueStatisticsColumn Column10 =>
        Columns.Count > 10 ? Columns[10] : new ValueStatisticsColumn() { IsEnabled = false };


    public List<ValueStatisticsColumn> Columns { get; } = new();
}