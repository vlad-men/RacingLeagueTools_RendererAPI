namespace RacingLeagueTools.FlexRenderer.Models;
public class SeasonRenderData : NamedRenderData
{
    public LeagueRenderData LeagueInfo { get; set; }
    public string FullName { get; set; }
    public CompletedStatus CompletedStatus { get; set; }
    public Color Color { get; set; }
    public Color SecondaryColor { get; set; }
    public Color TertiaryColor { get; set; }
    public ChampionshipRenderData Championship { get; set; }
    public LeagueCategoryRenderData MainLeagueCategory { get; set; }
    public ICollection<LeagueCategoryRenderData> LeagueCategories { get; set; }
    public LineupsBasedType LineupsBasedType { get; set; }
    public int GridSize { get; set; }
    public bool IsSeparateReservesAtStandings { get; set; }
    public bool IsShowTimesInsteadGapInQual { get; set; }
    public bool IsStandingsShowAllLineups { get; set; }
    public bool IsStandingsShowArchiveDrivers { get; set; }
    public bool IsStandingsShowReserves { get; set; }
    public int SeasonProgressPercent { get; set; }
    public string SeasonProgressPercentString { get; set; }
    public DriverRenderObject SeasonLeader { get; set; }
    public string SeasonLeaderString { get; set; }
    public int SeasonCurrentNumberEvent { get; set; }
    public int SeasonCurrentNumberEventExcludingNonChampionship { get; set; }
    public int SeasonOverallNumberEvents { get; set; }
    public int SeasonOverallNumberEventsExcludingNonChampionship { get; set; }
    public int SeatsPerTeam { get; set; }
    public bool IsProFeaturesEnabled { get; set; }
    public TimeOnly DefaultEventStartTime { get; set; }
    public bool IsEventDateOnly { get; set; }
    public bool IsSessionDateOnly { get; set; }
    public EventFormat EventFormat { get; set; }
    public MulticlassConfiguration? MulticlassConfiguration { get; set; }
    public bool IsHaveMulticlassConfiguration => MulticlassConfiguration is not null && MulticlassConfiguration.RacingClasses.Count > 1;
}