using Tyuiu.AntonovDI.Sprint1.Task3.V15.Lib;

namespace Tyuiu.AntonovDI.Sprint1.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 3;
            double v2 = 4;
            double S = 15;
            double T = 3;
            var res = ds.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(36, res);
        }
    }
}
