public struct PointsValue
{
    public int IntValue { get; set; } // 11.5 => 12
    public int RawValue { get; set; } // 11.5 => 115
    public float FloatValue { get; set; } // 11.5 => 11.5
    public string StringValue { get; set; } // 11.5 => "11.5", 0 => "0"
    public string ZeroEmptyStringValue { get; set; } // 0 => ""
    public string LocalizedStringValue { get; set; } //can be 11.5 => "11,5" (depends on end user locale)
    public string ZeroEmptyLocalizedStringValue { get; set; } // 0 => ""
    public string Value => ZeroEmptyStringValue;
    public override string ToString() => ZeroEmptyStringValue;
}