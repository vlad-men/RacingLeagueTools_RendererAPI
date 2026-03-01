namespace RacingLeagueTools.FlexRenderer.Models.RenderObjects.Standings.Details;

public class DriverSeasonDeepRatingsDetails
{
    public bool IsRatingsAvailable { get; set; }

    // race pace rating (advanced / pro feature)
    public RatingValue RacePaceRating { get; set; }
    public int RacePacePosition { get; set; }
    public string RacePaceAveragePosition { get; set; }
    public int RacePaceRatingsCount { get; set; }
    public string RacePaceRatingChange { get; set; } = string.Empty;
    public bool IsRacePaceRatingChangePositive { get; set; }
    public bool IsRacePaceRatingChangeNegative { get; set; }

    // consistency rating (advanced / pro feature)
    public RatingValue ConsistencyRating { get; set; }
    public int ConsistencyPosition { get; set; }
    public string ConsistencyAveragePosition { get; set; }
    public int ConsistencyRatingsCount { get; set; }
    public string ConsistencyRatingChange { get; set; } = string.Empty;
    public bool IsConsistencyRatingChangePositive { get; set; }
    public bool IsConsistencyRatingChangeNegative { get; set; }

    // attack rating (pro feature)
    public RatingValue AttackRating { get; set; }
    public int AttackPosition { get; set; }
    public string AttackAveragePosition { get; set; }
    public int AttackRatingsCount { get; set; }
    public string AttackRatingChange { get; set; } = string.Empty;
    public bool IsAttackRatingChangePositive { get; set; }
    public bool IsAttackRatingChangeNegative { get; set; }

    // defense rating (pro feature)
    public RatingValue DefenseRating { get; set; }
    public int DefensePosition { get; set; }
    public string DefenseAveragePosition { get; set; }
    public int DefenseRatingsCount { get; set; }
    public string DefenseRatingChange { get; set; } = string.Empty;
    public bool IsDefenseRatingChangePositive { get; set; }
    public bool IsDefenseRatingChangeNegative { get; set; }
}
