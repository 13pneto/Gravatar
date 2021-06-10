using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar Tests")]
        [TestMethod("Should validate Gravatar extension")]
        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow(" ", false)]
        [DataRow("a@a", false)]
        [DataRow("a@pedro.com", false)]
        [DataRow("skootbr@gmail.com", true)]
        public void ShouldValidateGravatar(string email, bool status)
        {
            var result = $"https://www.gravatar.com/avatar/0ca43f28eadb720f7f044981ee7f325f";
            Assert.AreEqual((email.ToGravatar() == result), status);
        }
    }
}
