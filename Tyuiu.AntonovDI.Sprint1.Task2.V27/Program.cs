using Tyuiu.AntonovDI.Sprint1.Task2.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x;
        Console.WriteLine("Длина стороны квадрата:");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Периметр квадрата -  " + ds.CalculateSquarePerimetr(x));
        Console.ReadKey();
    }
}