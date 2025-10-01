using Tyuiu.AntonovDI.Sprint1.Task4.V23.Lib;

namespace Tyuiu.AntonovDI.Sprint1.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, 2);
        }
    }
}
