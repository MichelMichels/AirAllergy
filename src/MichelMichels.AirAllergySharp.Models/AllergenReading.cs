namespace MichelMichels.AirAllergySharp.Models;

public class AllergenReading
{
    public string Allergen { get; set; } = string.Empty;
    public List<Measure> Measures { get; set; } = [];
}
