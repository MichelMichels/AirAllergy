using MichelMichels.AirAllergySharp.Models;

namespace MichelMichels.AirAllergySharp.Tests;

[TestClass]
public class AirAllergySharpClientTests
{
    private AirAllergyOptions options = new();

    [TestMethod]
    public void BaseUrl_Null_ThrowsArgumentNullException()
    {
        Assert.ThrowsException<ArgumentNullException>(() => new AirAllergySharpClient(null!));
    }

    [TestMethod]
    public async Task GetPermissionsTest()
    {
        // Arrange 
        AirAllergySharpClient airAllergySharpClient = new(options);

        // Act
        List<Models.Permission> results = await airAllergySharpClient.GetPermissions();

        // Assert
        Assert.IsTrue(results.Count != 0);
    }
    [TestMethod]
    public async Task GetStationsTest()
    {
        // Arrange 
        AirAllergySharpClient airAllergySharpClient = new(options);

        // Act
        List<Models.Station> results = await airAllergySharpClient.GetStations();

        // Assert
        Assert.IsTrue(results.Count != 0);
    }
    [TestMethod]
    public async Task GetAllergensTest()
    {
        // Arrange 
        AirAllergySharpClient airAllergySharpClient = new(options);

        // Act
        List<Models.Allergen> results = await airAllergySharpClient.GetAllergens();

        // Assert
        Assert.IsTrue(results.Count != 0);
    }
    [TestMethod]
    public async Task GetStationReadingTest()
    {
        // Arrange 
        AirAllergySharpClient airAllergySharpClient = new(options);

        // Act
        List<Models.StationReading> results = await airAllergySharpClient.GetStationReadings();

        // Assert
        Assert.IsTrue(results.Count != 0);
    }
    [TestMethod]
    [DataRow(null, null)]
    [DataRow("BEBRUS", null)]
    [DataRow("BEBRUS", "POAC")]
    [DataRow(null, "POAC")]
    public async Task GetSpecificStationReadingTest(string? station, string? allergen)
    {
        // Arrange 
        AirAllergySharpClient airAllergySharpClient = new(options);

        // Act
        List<Models.StationReading> results = await airAllergySharpClient.GetStationReadings(station, allergen);

        // Assert
        Assert.IsTrue(results.Count != 0);
    }
}