using System.Text.Json.Serialization;

namespace MichelMichels.AirAllergySharp.Models;

public class Allergen
{
    public bool AppDisplay { get; set; }
    public string ChartInformation { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public DateTime DisplayAppFrom { get; set; }
    public DateTime DisplayAppTo { get; set; }

    [JsonPropertyName("en")]
    public string EnglishName { get; set; } = string.Empty;

    [JsonPropertyName("fr")]
    public string FrenchName { get; set; } = string.Empty;

    public bool IsHighSeason { get; set; }

    [JsonPropertyName("nl")]
    public string DutchName { get; set; } = string.Empty;

    [JsonPropertyName("rlHighThreshold")]
    public int HighThreshold { get; set; }

    [JsonPropertyName("rlLowThreshold")]
    public int LowThreshold { get; set; }

    [JsonPropertyName("rlMediumThreshold")]
    public int MediumThreshold { get; set; }

    [JsonPropertyName("rlNoneThreshold")]
    public int NoneThreshold { get; set; }

    public DateTime? SeasonStart { get; set; }
    public DateTime? SeasonEnd { get; set; }
}
