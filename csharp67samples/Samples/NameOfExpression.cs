using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp67samples.Samples
{
    [TestClass]
    public class NameOfExpression
    {
        [TestMethod]
        public void Basics()
        {
            Func<string, string> sampleFunction = lastName =>
            {
                if (string.IsNullOrWhiteSpace(lastName))
                    throw new ArgumentException("Cannot be blank", nameof(lastName));
                return lastName;
            };

            try
            {
                sampleFunction("Meiser");
            }
            catch (ArgumentException argumentException) when (argumentException.ParamName == "lastName")
            {
                Assert.IsTrue(true);
            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }
        }
    }
}
