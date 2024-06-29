public class DriverRenderData : NamedRenderData
{
    public string RealName { get; set; }
    public string InGameName { get; set; }
    public string DiscordName { get; set; }
    public string DiscordLink { get; set; }
    public string SteamName { get; set; }
    public string SteamLink { get; set; }
    public string BadgeText { get; set; }
    public ICollection<byte[]> BadgeImages { get; set; }
    public NationRenderData Nationality { get; set; }
    public DriverStatus DriverStatus { get; set; }
    public ICollection<LeagueRoleRenderData> LeagueRoles { get; set; }
    public int RaceNumber { get; set; }
    public NationRenderData NationalityIngame { get; set; }
    public GamePlatform GamePlatform { get; set; }
    public string Description { get; set; }
}