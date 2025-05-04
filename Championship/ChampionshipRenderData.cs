namespace RacingLeagueTools.FlexRenderer.Models;
public class ChampionshipRenderData : NamedRenderData
{
    public ICollection<TeamRenderData> Teams { get; set; }
    public ICollection<CarRenderData> Cars { get; set; }
    public ICollection<GameRenderData> Games { get; set; }
    public ICollection<TrackRenderData> Tracks { get; set; }
    public bool IsFastestLapPointsOnlyForScored { get; set; }
    public bool IsMinorRacesEqualsMajor { get; set; }
    public EventFormat EventFormat { get; set; }
    public MulticlassConfiguration? MulticlassConfiguration { get; set; }
    public bool IsHaveMulticlassConfiguration => MulticlassConfiguration is not null && MulticlassConfiguration.RacingClasses.Count > 1;
}