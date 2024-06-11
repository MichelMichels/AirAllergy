using MichelMichels.AirAllergySharp.Models;

namespace MichelMichels.AirAllergySharp;

public interface IAirAllergySharpClient
{
    Task<List<Permission>> GetPermissions();
    Task<List<Station>> GetStations();
    Task<List<Allergen>> GetAllergens();
}
