namespace RacingLeagueTools.FlexRenderer.Models;
public class CarRenderData : NamedRenderData
{
    public CarClassRenderData CarClass { get; set; }
    public VendorRenderData Vendor { get; set; }
    public int Year { get; set; }
    public int Power { get; set; }
}