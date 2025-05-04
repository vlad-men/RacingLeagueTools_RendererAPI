namespace RacingLeagueTools.FlexRenderer.Models;
public class CarRenderData : NamedRenderData
{
    public CarClassRenderData CarClass { get; set; }
    public VendorRenderData Vendor { get; set; }
    public int Year { get; set; }
    public int Power { get; set; }
    public string LiveryPath { get; set; } //to use, set ForceLiveriesLoading to true (see renderer manual)
    public IList<string> LiveryVariants { get; set; } = new List<string>();
    public string LiveryDefaultVariantPath => LiveryVariants.Count > 0 ? LiveryVariants[0] : null;
    public string LiveryVariant2Path => LiveryVariants.Count > 1 ? LiveryVariants[1] : null;
    public string LiveryVariant3Path => LiveryVariants.Count > 2 ? LiveryVariants[2] : null;
    public Color Color { get; set; }
    public Color SecondaryColor { get; set; }
    public Color TertiaryColor { get; set; }
}