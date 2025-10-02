using Tyuiu.AntonovDI.Sprint1.Task6.V13.Lib;

namespace Tyuiu.AntonovDI.Sprint1.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "abcd";
            bool result = ds.CheckWordsAlphabet(value);
            Assert.AreEqual(true, result);
        }
    }
 }
