using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp67samples.Samples
{
    [TestClass]
    public class StringInterpolation
    {
        [TestMethod]
        public void Basic()
        {
            const string firstName = "Hans";
            const string lastName = "Meiser";

            var fullName = $"{firstName} {lastName}";

            Assert.AreEqual("Hans Meiser", fullName);
        }

        [TestMethod]
        public void FunctionCalls()
        {
            const string firstName = "Hans";
            const string lastName = "Meiser";

            var fullName = $"{firstName} {lastName.Reverse().Aggregate(string.Empty, (s, c) => s += c)}";

            Assert.AreEqual("Hans resieM", fullName);
        }

        [TestMethod]
        public void GoCrazy()
        {
            var grades = new List<int>
            {
                5,
                4,
                5,
                6
            };

            var result =
                $@"All Grades: {grades.OrderByDescending(g => g)
                .Select(s => s.ToString("F2")).Aggregate((partial, element) => $"{partial}, {element}")}";

            Assert.AreEqual("All Grades: 6.00, 5.00, 5.00, 4.00", result);
        }
    }
}