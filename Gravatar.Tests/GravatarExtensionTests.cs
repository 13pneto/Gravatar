using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar Tests")]
        [TestMethod("Should validate Gravatar extension")]
        [DataRow(null,false, 200)]
        [DataRow("", false, 200)]
        [DataRow(" ", false, 200)]
        [DataRow("a@a", false, 200)]
        [DataRow("a@pedro.com",false, 200)]
        [DataRow("skootbr@gmail.com", true)]
        public void ShouldValidateGravatar(string email, bool status, int? size = 100)
        {
            var result = $"https://www.gravatar.com/avatar/0ca43f28eadb720f7f044981ee7f325f?s=100";
            Assert.AreEqual((email.ToGravatar(size) == result), status);
        }
    }
}
