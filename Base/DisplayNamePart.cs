public enum DisplayNameToken
{
    Name = 0,
    FirstName,
    LastName,
    InGameName,
}

public class DisplayNamePart
{
    public DisplayNameToken Token { get; set; }
    public string Value { get; set; }
}
