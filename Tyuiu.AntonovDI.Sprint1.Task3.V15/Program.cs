using System.Runtime.Intrinsics;
using Tyuiu.AntonovDI.Sprint1.Task3.V15.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double v1; double v2; double S; double T;
        Console.WriteLine("Введите скорость первого автомобиля: ");
        v1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите скорость второго автомобиля: ");
        v2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите начальное расстояние между автомобилями: ");
        S = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите время потраченное на дорогу: ");
        T = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine($"Итоговое расстояние между автомобилями - {Math.Round(ds.DistanceOverTime(v1, v2, S, T), 3)}");

        Console.ReadKey();
    }
}