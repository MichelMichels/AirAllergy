﻿using MichelMichels.AirAllergySharp.Models;

namespace MichelMichels.AirAllergySharp;

public interface IAirAllergySharpClient
{
    Task<List<Permission>> GetPermissions();
    Task<List<Station>> GetStations();
    Task<List<Allergen>> GetAllergens();
    Task<List<StationReading>> GetStationReadings(string? station, string? allergen);
}
