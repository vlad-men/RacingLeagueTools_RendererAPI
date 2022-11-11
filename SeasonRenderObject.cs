public class SeasonRenderObject : RenderObject
{
    public LeagueRenderObject LeagueInfo { get; set; }
    public string FullName { get; set; }
    public CompletedStatus CompletedStatus { get; set; }
    public ChampionshipRenderObject Championship { get; set; }
    public LeagueCategoryRenderObject LeagueCategory { get; set; }
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
    public int SeasonOverallNumberEvents { get; set; }
    public int SeatsPerTeam { get; set; }
    public bool IsProFeaturesEnabled { get; set; }
}