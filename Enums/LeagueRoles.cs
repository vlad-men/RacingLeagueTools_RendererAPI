public enum LeagueRoleBuiltIn
{
    [Description("League Head")] LeagueHead = 1,
    [Description("Admin")] Admin = 2,
    [Description("Manager")] Manager = 4,
    [Description("Race Director")] RaceDirector = 8,
    [Description("Head Steward")] HeadSteward = 16,
    [Description("Steward")] Steward = 32,
    [Description("Staff")] Staff = 64,
    [Description("Commentator")] Commentator = 128,
    [Description("Streamer")] Streamer = 256,
    [Description("Driver")] Driver = 512,
    [Description("Reserve")] Reserve = 1024,
}