using System;
using System.Security.Cryptography.X509Certificates;

public class Programm1
{
    int n = 1;
    int m = 2;
    int result;
    public static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
    }

    public static void Task1()
    {
        double n;
        double m;
        bool isNumN = false;
        bool isNumM = false;

        do
        {
            Console.WriteLine("Введите число n: ");
            isNumN = double.TryParse(Console.ReadLine(), out n);

            Console.WriteLine("Введите число m: ");
            isNumM = double.TryParse(Console.ReadLine(), out m);
            if(isNumM == false || isNumM == false)
            {
                Console.WriteLine("Обнаружено неправильное значение. Попробуйте ещё раз.");
            }
        } while(isNumN == false && isNumM == false);

        double res1 = m * n++;
        bool res2 = m-- < n;
        bool res3 = ++m > n;

        double x;
        bool isNumX = false;

        do
        {
            Console.WriteLine("Введите число n: ");
            isNumX = double.TryParse(Console.ReadLine(), out x);
            if(isNumX == false)
            {
                Console.WriteLine("Введено неправильное значение. Попробуйте ещё раз.");
            }
        } while (isNumX);

        double res4 = Math.Cos(Math.Atan(x));
        Console.WriteLine("Результат 1: " + res1);
        Console.WriteLine("Результат 2: " + res2);
        Console.WriteLine("Результат 3: " + res3);
        Console.WriteLine("Результат 4: " + res4);
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
    }
    public static void Task2()
    {
        bool XparseResult = false;
        bool YparseResult = false;
        double x;
        double y;
        do
        {
            Console.WriteLine("Введите координату x: ");
            XparseResult = double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Введите координату y: ");
            YparseResult = double.TryParse(Console.ReadLine(), out y);
            if(XparseResult == false || YparseResult == false)
            {
                Console.WriteLine("Одно из введённых значений неправильное.");
            }
        } while (XparseResult = YparseResult = false);
        if(x >= 0 && x <= 5 && y >= -7 && y <= 5)
        {
            if(y <= 0)
            {
                Console.WriteLine("Эта точка принадлежит заданной области!");
            }
            else if ((y+x-5) < 0)
            {
                Console.WriteLine("Эта точка принадлежит заданной области!");
            }
            else
            {
                Console.WriteLine("Эта точка не принадлежит заданной области.");
            }
        }
        else
        {
            Console.WriteLine("Эта точка не принадлежит заданной области.");
        }
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
    }
    public static void Task3()
    {
        double a = 1000;
        double b = 0.00001;
        double result1 = (Math.Pow((a - b), 4) - (Math.Pow(a, 4) + 6 * a * a * b * b + Math.Pow(b, 4))) / ((-4) * a * Math.Pow(b, 3) - 4 * Math.Pow(a, 3) * b);
        float result2 = ((float)((Math.Pow(a - b, 4) - (Math.Pow(a, 4) + 6 * a * a * b * b + Math.Pow(b, 4))) / ((-4) * a * Math.Pow(b, 3) - 4 * Math.Pow(a, 3) * b)));
        Console.WriteLine("Double: " + result1);
        Console.WriteLine("Float: " + result2);
        Console.WriteLine("Ответы различны так как float, имея всего 7 знаков после запятой, округлил 0.9999999 до 1, а double - нет");
    }
}