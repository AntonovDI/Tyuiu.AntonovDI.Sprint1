using System.Runtime.Intrinsics;
using Tyuiu.AntonovDI.Sprint1.Task3.V15.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Антонов Д. И. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнил: Антонов Даниил Иванович | ИСТНб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, решающую следующую задачу: два автомобиля имеют     *");
        Console.WriteLine("* скорости V1 км/ч и V2 км/ч соответственно, находятся на расстоянии S км *");
        Console.WriteLine("* друг от друга и движутся в противоположные стороны. Определить          *");
        Console.WriteLine("* расстояние между ними через T часов. Ответ округлите до 3 знаков        *");
        Console.WriteLine("* после запятой.                                                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* одинаковых массивов по длине.                                           *");
        Console.WriteLine("*                                                                         *");
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