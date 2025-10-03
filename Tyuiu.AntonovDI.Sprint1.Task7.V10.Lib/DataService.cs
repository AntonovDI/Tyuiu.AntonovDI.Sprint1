using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AntonovDI.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {
            double ctg = (1.0 / Math.Tan(x*3));
            return Math.Round((2 * ctg - (Math.Log(Math.Cos(x)) / Math.Log(1 + x*x))), 3);
        }
    }
}
