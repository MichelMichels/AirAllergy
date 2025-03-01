using MichelMichels.AirAllergySharp.Models;

namespace MichelMichels.AirAllergySharpTests.Models;

[TestClass]
public class AirAllergyOptionsTests
{
    [TestMethod]
    public void DefaultConstructorTest()
    {
        // Arrange
        AirAllergyOptions model = new();

        // Act

        // Assert
        Assert.IsNotNull(model.BaseUrl);
        Assert.AreEqual(@"https://api-airallergy.sciensano.be/public/", model.BaseUrl);
    }
}
