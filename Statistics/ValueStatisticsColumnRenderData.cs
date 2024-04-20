namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects;
public class ValueStatisticsColumnRenderData : BaseRenderData
{
    public string Header { get; set; }
    public bool IsEnabled { get; set; }
    public ValueStatisticsType Type { get; set; }
    public int GroupId { get; set; }
    public int Index { get; set; }

    public static void CopyFromColumnDataValues(ValueStatisticsColumnRenderData columnRenderData, ColumnDataValues columnData)
    {
        columnRenderData.Header = columnData.Header;
        columnRenderData.Type = ValueStatisticsRenderData.TypeFromDataValueType(columnData.Type);
        columnRenderData.GroupId = columnData.GroupId;
        columnRenderData.Index = columnData.Index;

        columnRenderData.IsEnabled = !string.IsNullOrEmpty(columnRenderData.Header);
        if (columnRenderData.Type is ValueStatisticsType.Stints or ValueStatisticsType.Separator or ValueStatisticsType.Tyres)
            columnRenderData.IsEnabled = true;
    }
}