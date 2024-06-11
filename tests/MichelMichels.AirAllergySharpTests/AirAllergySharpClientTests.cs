namespace MichelMichels.AirAllergySharp.Tests;

[TestClass]
public class AirAllergySharpClientTests
{
    private const string baseUrl = @"https://api-airallergy.sciensano.be/public/";

    [TestMethod]
    public void BaseUrl_Null_ThrowsArgumentNullException()
    {
        Assert.ThrowsException<ArgumentNullException>(() => new AirAllergySharpClient(null!));
    }

    [TestMethod]
    public async Task GetPermissionsTest()
    {
        // Arrange 
        AirAllergySharpClient airAllergySharpClient = new(baseUrl);

        // Act
        List<Models.Permission> results = await airAllergySharpClient.GetPermissions();

        // Assert
        Assert.IsTrue(results.Count != 0);
    }
    [TestMethod]
    public async Task GetStationsTest()
    {
        // Arrange 
        AirAllergySharpClient airAllergySharpClient = new(baseUrl);

        // Act
        List<Models.Station> results = await airAllergySharpClient.GetStations();

        // Assert
        Assert.IsTrue(results.Count != 0);
    }
    [TestMethod]
    public async Task GetAllergensTest()
    {
        // Arrange 
        AirAllergySharpClient airAllergySharpClient = new(baseUrl);

        // Act
        List<Models.Allergen> results = await airAllergySharpClient.GetAllergens();

        // Assert
        Assert.IsTrue(results.Count != 0);
    }
}