namespace MichelMichels.AirAllergySharp.Models;

public class StationReading
{
    public string Station { get; set; } = string.Empty;
    public List<AllergenReading> Allergens { get; set; } = [];
}
