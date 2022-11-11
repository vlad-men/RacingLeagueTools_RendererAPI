public class DriverRenderObject : RenderObject
{
    public string RealName { get; set; }
    public string InGameName { get; set; } 
    public string DiscordName { get; set; }
    public string DiscordLink { get; set; }
    public string SteamName { get; set; }
    public string SteamLink { get; set; }
    public string BadgeText { get; set; }
    public List<byte[]> BadgeImages { get; set; }
    public NationRenderObject Nationality { get; set; }
    public DriverStatus DriverStatus { get; set; }
    public LeagueRole LeagueRole { get; set; }
    public int RaceNumber { get; set; }
    public NationRenderObject NationalityIngame { get; set; }
    public GamePlatform GamePlatform { get; set; }
    public string Description { get; set; }
}