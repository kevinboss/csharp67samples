using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp67samples.Samples
{
    [TestClass]
    public class IndexInitializers
    {
        [TestMethod]
        public void Dictionaries()
        {
            var webErrors = new Dictionary<int, string>
            {
                [404] = "Page not Found",
                [302] = "Page moved, but left a forwarding address.",
                [500] = "The web server can't come out to play today."
            };

            Assert.AreEqual("Page not Found", webErrors[404]);
        }
    }
}