using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace csharp67samples.Samples
{
    [TestClass]
    public class NullConditionalOperators
    {
        [TestMethod]
        public void Basic()
        {
            Person person = null;

            var result = person?.FirstName;

            Assert.IsNull(result);
        }

        [TestMethod]
        public void Delegates()
        {
            Func<string> action = null;

            var result = action?.Invoke();

            Assert.IsNull(result);
        }

        private class Person
        {
            public string FirstName { get; internal set; }
        }
    }
}