namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.Standings.Details;

public class DriverSeasonChampionshipDetails
{
    //championship position
    public int BestChampionshipPosition { get; set; }
    public int RoundsLeading { get; set; }
    public bool IsHasLedChampionship { get; set; }

    //championship status
    public int BestPossiblePosition { get; set; }
    public bool IsChampionshipSecured { get; set; }
    public bool IsCanWinChampionship { get; set; }

    //position movement
    public bool IsNewOnStandings { get; set; }
    public int PositionChange { get; set; }
    public int PositionChangeAbs { get; set; }
    public bool IsPositionChangePositive { get; set; }
    public bool IsPositionChangeNegative { get; set; }
}
