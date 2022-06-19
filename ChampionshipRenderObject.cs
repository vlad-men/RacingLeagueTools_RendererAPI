public class ChampionshipRenderObject : RenderObject
{
    public List<TeamRenderObject> Teams { get; set; }
    public List<CarRenderObject> Cars { get; set; }
    public List<GameRenderObject> Games { get; set; }
    public List<TrackRenderObject> Tracks { get; set; }
    public bool IsFastestLapPointsOnlyForScored { get; set; }
    public bool IsMinorRacesEqualsMajor { get; set; }
}
