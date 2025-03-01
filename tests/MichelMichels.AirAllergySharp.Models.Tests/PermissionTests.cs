using MichelMichels.AirAllergySharp.Models;

namespace MichelMichels.AirAllergySharpTests.Models;

[TestClass]
public class PermissionTests
{
    [TestMethod]
    public void DefaultConstructorTest()
    {
        // Arrange
        Permission model = new();

        // Act

        // Assert
        Assert.AreEqual(string.Empty, model.Allergen);
        Assert.AreEqual(string.Empty, model.Station);
        Assert.AreEqual(string.Empty, model.Feature);
    }
}
