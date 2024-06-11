namespace MichelMichels.AirAllergySharp.Tests
{
    [TestClass]
    public class AirAllergySharpClientTests
    {
        [TestMethod]
        public void BaseUrl_Null_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new AirAllergySharpClient(null!));
        }
    }
}