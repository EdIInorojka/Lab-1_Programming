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

    #region Задание 1

    public static void Task1()
    {
        double n;
        double m;
        bool isNumN = false;
        bool isNumM = false;


        do //Цикл ввода чисел m и n
        {
            Console.WriteLine("Введите число n: ");
            isNumN = double.TryParse(Console.ReadLine(), out n); //Попытка парсинга для переменной n

            Console.WriteLine("Введите число m: ");
            isNumM = double.TryParse(Console.ReadLine(), out m); //Попытка парсинга для переменной m

            if (!isNumM || !isNumM) //Проверка правильности введённых значений (Обработка только для пользователя)
            {
                Console.WriteLine("Обнаружено неправильное значение. Попробуйте ещё раз.");
            }

        } while(!isNumN && !isNumM); //Проверка правильности значений для выхода из цикла

        double res1 = m * n++; //Пример 1
        bool res2 = m-- < n; //Пример 2
        bool res3 = ++m > n; //Пример 3

        double x;
        bool isNumX = false;

        do
        {
            Console.WriteLine("Введите число x: ");
            isNumX = double.TryParse(Console.ReadLine(), out x); //Попытка парсинга для переменной x

            if (!isNumX) //Проверка правильности введённых значений (Обработка только для пользователя)
            {
                Console.WriteLine("Введено неправильное значение. Попробуйте ещё раз.");
            }

        } while (!isNumX); //Проверка правильности значения для выхода из цикла

        double res4 = Math.Cos(Math.Atan(x)); //Пример 4

        Console.WriteLine("Результат 1: " + res1);
        Console.WriteLine("Результат 2: " + res2);
        Console.WriteLine("Результат 3: " + res3);
        Console.WriteLine("Результат 4: " + res4);
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
    }

    #endregion

    #region Задание 2

    public static void Task2()
    {
        bool XparseResult = false;
        bool YparseResult = false;
        double x;
        double y;

        do //Цикл ввода переменных x и y
        {
            Console.WriteLine("Введите координату x: ");
            XparseResult = double.TryParse(Console.ReadLine(), out x); //Попытка парсинга для переменной x

            Console.WriteLine("Введите координату y: ");
            YparseResult = double.TryParse(Console.ReadLine(), out y); //Попытка парсинга для переменной y

            if (!XparseResult|| !YparseResult) //Проверка правильности введённых значений (Обработка только для пользователя)
            {
                Console.WriteLine("Одно из введённых значений неправильное.");
            }

        } while (!XparseResult && !YparseResult); 

        if(x >= 0 && x <= 5 && y >= -7 && y <= 5) //Выбирираем только прямоугольную область на координатной плоскости
        {
            if(y <= 0) //y<0 => в прямоугольной области все точки будут подходить
            {
                Console.WriteLine("Эта точка принадлежит заданной области!");
            }

            else if ((y+x-5) < 0) // y>0 => проверка, что точка ниже прямой
            {
                Console.WriteLine("Эта точка принадлежит заданной области!");
            }

            else // y>0 и точка выше прямой
            {
                Console.WriteLine("Эта точка не принадлежит заданной области.");
            }
        }
        else //Если число за пределами области
        {
            Console.WriteLine("Эта точка не принадлежит заданной области.");
        }
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
    }

    #endregion

    #region Задание 3

    public static void Task3()
    {
        double a = 1000;
        double b = 0.00001;


        double numerator = (Math.Pow((a - b), 4) - (Math.Pow(a, 4) + 6 * a * a * b * b + Math.Pow(b, 4))); //Числитель
        double denominator = ((-4) * a * Math.Pow(b, 3) - 4 * Math.Pow(a, 3) * b); //Знаменатель

        double result1 = numerator / denominator; //Вычисление значения в Double
        float result2 = (float)result1; //Перевод переменной во Float

        Console.WriteLine("Double: " + result1);
        Console.WriteLine("Float: " + result2);
        Console.WriteLine("Ответы различны так как float, имея всего 7 знаков после запятой, округлил 0.9999999 до 1, а double - нет");
    }

    #endregion

}