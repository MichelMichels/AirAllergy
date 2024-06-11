namespace MichelMichels.AirAllergySharp.Models;

public class Permission
{
    public string Allergen { get; set; } = string.Empty;
    public bool Allow { get; set; }
    public string Feature { get; set; } = string.Empty;
    public string Station { get; set; } = string.Empty;
}
