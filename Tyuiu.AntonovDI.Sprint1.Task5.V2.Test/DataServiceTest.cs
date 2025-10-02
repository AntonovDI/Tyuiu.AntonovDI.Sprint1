using Tyuiu.AntonovDI.Sprint1.Task5.V2.Lib;


namespace Tyuiu.AntonovDI.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 50;
            int res = ds.FahrenheitToСelsius(x);
            int wait = 10;
            Assert.AreEqual(wait, res);
        }
    }
}
