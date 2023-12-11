Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

    namespace EvenNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10]{4, 16, 30, 12, 9, 22, 46, 58, 74, 82};
            int evenCount = 0;

            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
            }

            Console.WriteLine($"Количество четных чисел: {evenCount}");
        }
    }
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------

Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

    using System;

class Program
{
    static void Main()
    {
        // Создаем массив с 10 вещественными числами
        Random rnd = new Random();
        double[] array = Enumerable.Range(0, 10).Select(x => rnd.NextDouble() * 10 - 5).ToArray();

        // Находим минимальное и максимальное значение в массиве
        double minValue = array.Min();
        double maxValue = array.Max();

        // Вычисляем разницу между ними
        double difference = maxValue - minValue;

        Console.WriteLine("Минимальный элемент: " + minValue);
        Console.WriteLine("Максимальный элемент: " + maxValue);
        Console.WriteLine("Разница между ними: " + difference);
    }
}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
