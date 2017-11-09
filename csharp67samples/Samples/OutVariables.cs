using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp67samples.Samples
{
    [TestClass]
    public class OutVariables
    {
        [TestMethod]
        public void Basic()
        {
            var parsedInput = -1;
            const string input = "123";
            if (int.TryParse(input, out var result))
                parsedInput = result;
            Assert.AreEqual(123, parsedInput);
        }
    }
}
