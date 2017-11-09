using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp67samples.Samples
{
    [TestClass]
    public class Discards
    {
        [TestMethod]
        public void Basics()
        {
            bool TrySave(out int index, object data)
            {
                //Some fancy DB action
                index = 1;
                return true;
            }

            var result = TrySave(out _, new object());
            
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TupleDiscard()
        {
            (string alpha, string beta) MakeTuple()
            {
                return ("Hello", "World");
            }

            (_, string thatsWhatWeCareAbout) = MakeTuple();
            
            Assert.AreEqual("World", thatsWhatWeCareAbout);
        }
    }
}
