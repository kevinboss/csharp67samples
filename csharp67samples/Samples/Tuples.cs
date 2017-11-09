using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp67samples.Samples
{
    [TestClass]
    public class Tuples
    {
        [TestMethod]
        public void Basic()
        {
            var letters = ("a", "b");
            (string Alpha, string Beta) namedLetters = letters;
            Assert.AreEqual("a", namedLetters.Alpha);
            Assert.AreEqual("b", namedLetters.Beta);
        }

        [TestMethod]
        public void MultipleReturnValues()
        {
            (int Max, int Min) Range(IEnumerable<int> numbers)
            {
                var min = int.MaxValue;
                var max = int.MinValue;
                foreach (var n in numbers)
                {
                    min = (n < min) ? n : min;
                    max = (n > max) ? n : max;
                }
                return (max, min);
            }

            var result = Range(new List<int>
            {
                10,
                3,
                4,
                7
            });

            Assert.AreEqual(10, result.Max);
            Assert.AreEqual(3, result.Min);
        }

        [TestMethod]
        public void Deconstruction()
        {
            var p = new Point(3.14, 2.71);
            (double x, double y) = p;

            Assert.AreEqual(3.14, x);
            Assert.AreEqual(2.71, y);
        }

        public class Point
        {
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; }
            public double Y { get; }

            public void Deconstruct(out double x, out double y)
            {
                x = X;
                y = Y;
            }
        }
    }
}

