using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp67samples.Samples
{
    [TestClass]
    public class PatternMatching
    {
        [TestMethod]
        public void Basics()
        {
            string result;
            Geometry g = new Square(5);
            switch (g)
            {
                case Triangle triangle:
                    result = $"{triangle.Width} {triangle.Height} {triangle.Base}";
                    break;
                case Rectangle rectangle:
                    result = $"{rectangle.Width} {rectangle.Height}";
                    break;
                case Square square:
                    result = $"{square.Width}";
                    break;
                default:
                    result = "<other>";
                    break;
            }
            Assert.AreEqual("5", result);
        }

        class Geometry
        {
        }

        class Triangle : Geometry
        {
            public int Width { get; }
            public int Height { get; }
            public int Base { get; }

            public Triangle(int width, int height, int Base)
            {
                Width = width;
                Height = height;
                this.Base = Base;
            }
        }

        class Rectangle : Geometry
        {
            public int Width { get; }
            public int Height { get; }

            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }
        }

        class Square : Geometry
        {
            public int Width { get; }

            public Square(int width)
            {
                Width = width;
            }
        }
    }
}