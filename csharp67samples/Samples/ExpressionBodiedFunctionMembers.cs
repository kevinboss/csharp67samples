using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp67samples.Samples
{
    [TestClass]
    public class ExpressionBodiedFunctionMembers
    {
        [TestMethod]
        public void Basic()
        {
            var result = new ExpressionBodiedFunctionMembers().ToString();

            Assert.AreEqual("Meiser, Hans", result);
        }

        public override string ToString() => $"{LastName}, {FirstName}";
        public string FirstName { get; } = "Hans";
        public string LastName { get; } = "Meiser";
    }
}
