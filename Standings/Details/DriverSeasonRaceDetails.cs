namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.Standings.Details;

public class DriverSeasonRaceDetails
{
    // fastest laps
    public int FastestLapWinsCount { get; set; }
    public string AverageFastestLapPosition { get; set; }
    public string AverageFastestLapGapToLeader { get; set; }
    public bool IsHasFastestLapData { get; set; }

    // max speed
    public int BestMaxSpeed { get; set; }
    public string AverageMaxSpeed { get; set; }
    public string AverageMaxSpeedPosition { get; set; }
    public string AverageMaxSpeedGapToLeaderKmh { get; set; }
    public string AverageMaxSpeedGapToLeaderPercent { get; set; }
    public int MaxSpeedWinsCount { get; set; }
    public bool IsHasMaxSpeedData { get; set; }

    // overtakes (pro feature)
    public int TotalOvertakes { get; set; }
    public string AverageOvertakesPerRace { get; set; }
    public int BestOvertakesInRace { get; set; }
    public bool IsHasOvertakesData { get; set; }

    // defense / positions lost (pro feature)
    public int TotalPositionsLost { get; set; }
    public string AveragePositionsLostPerRace { get; set; }
    public bool IsHasDefenseData { get; set; }

    // laps
    public int TotalLaps { get; set; }
    public int TotalPossibleLaps { get; set; }
    public string LapCompletionPercent { get; set; }
    public string SeasonLapCoveragePercent { get; set; }

    // lead
    public int TotalLeadLaps { get; set; }
    public int TotalLeadDistance { get; set; }
    public string TotalLeadDistanceKm { get; set; }
    public bool IsHasLeadData { get; set; }

    // pit stops
    public int TotalPitStops { get; set; }
    public string AveragePitStopsPerRace { get; set; }
    public bool IsHasPitData { get; set; }

    // stints / tyres
    public int TotalStintCount { get; set; }
    public int TotalStintLaps { get; set; }
    public string AverageStintLaps { get; set; }
    public TyreTypeInfo? MostUsedTyre { get; set; }
}
