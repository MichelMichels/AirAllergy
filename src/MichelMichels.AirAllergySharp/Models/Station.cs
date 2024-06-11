using System.Text.Json.Serialization;

namespace MichelMichels.AirAllergySharp.Models;

public class Station
{
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("en")]
    public string EnglishName { get; set; } = string.Empty;

    [JsonPropertyName("fr")]
    public string FrenchName { get; set; } = string.Empty;

    [JsonPropertyName("nl")]
    public string DutchName { get; set; } = string.Empty;
}
