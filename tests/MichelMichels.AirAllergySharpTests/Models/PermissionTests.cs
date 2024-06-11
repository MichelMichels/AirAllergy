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
        Assert.IsNotNull(model.Allergen);
        Assert.IsNotNull(model.Station);
        Assert.IsNotNull(model.Feature);
    }
}
