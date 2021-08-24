using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaskString.Tests
{
    [TestClass]
    public class MaskExtensionsTests
    {
        [TestCategory("Mask Tests")]
        [TestMethod("Validando as mascaras em strings")]       
        [DataRow("78342023672")]
        public void ShouldValidateMask(string cpf)
        {
            var result = "783.420.236-72";
            Assert.IsTrue((cpf.FormatCPF() == result));
        }
    }
}
