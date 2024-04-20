namespace RacingLeagueTools.FlexRenderer.Models;
public class ChampionshipRenderData : NamedRenderData
{
    public ICollection<TeamRenderData> Teams { get; set; }
    public ICollection<CarRenderData> Cars { get; set; }
    public ICollection<GameRenderData> Games { get; set; }
    public ICollection<TrackRenderData> Tracks { get; set; }
    public bool IsFastestLapPointsOnlyForScored { get; set; }
    public bool IsMinorRacesEqualsMajor { get; set; }
}