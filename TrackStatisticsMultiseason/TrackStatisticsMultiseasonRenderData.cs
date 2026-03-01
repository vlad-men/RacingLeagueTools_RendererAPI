namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.TrackStatisticsMultiseason;

public class TrackStatisticsMultiseasonRenderData : BaseRenderData
{
    public TrackRenderData Track { get; set; }
    public string MultiSeasonName { get; set; }
    public int SeasonsCount { get; set; }

    // key flat metrics
    public int TotalEvents { get; set; }
    public int TotalRaces { get; set; }
    public int TotalQualifications { get; set; }
    public string FirstVisitDate { get; set; }
    public string LastVisitDate { get; set; }

    // extended details (always initialized, never null)
    public TrackMultiseasonRaceDetails RaceDetails { get; set; } = new();
    public TrackMultiseasonQualDetails QualDetails { get; set; } = new();
    public TrackMultiseasonRecordsDetails RecordsDetails { get; set; } = new();

    public ICollection<TrackMultiseasonSeasonEntry> Seasons { get; set; } = [];
}
