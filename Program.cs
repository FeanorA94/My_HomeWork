Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа
должна выдать ответ: Да/Нет.


\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

Console.Write("Введите число для поиска: ");
int k = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 11); //[0;10]
Console.WriteLine(string.Join(", ", array));

bool flag = false;
for(int i = 0; i < array.Length; i ++)
{
    if (array[i] == k)
    {
        Console.WriteLine("Yes");
        flag = true;
        break;
    }
}

if (flag == false)
    Console.WriteLine("No");
        
}

Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.
Пример

\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 11); //[0;10]
Console.WriteLine(string.Join(", ", array));

for(int i = 0; i < array.Length; i++)
    array[i] *= -1; // array[i] = array[i] * (-1)
Console.WriteLine(string.Join(", ", array));

Найдите произведения пар чисел в одномерном массиве. Парой
считаем первый и последний элемент, второй и предпоследний и
т.д. Результат запишите в новый массив.


\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for(int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 11); //[0;10]
// Console.WriteLine(string.Join(", ", array));

// int[] array_new = new int[array.Length / 2];

// for(int i = 0; i < array.Length / 2; i++)
//     array_new[i] = array[i] * array[array.Length - 1 - i];

// Console.WriteLine(string.Join(", ", array_new));


// [1 3 2 4 2 3] => [3 6 8]
// array[0] * array[array.Length - 1 - 0]
// array[1] * array[array.Length - 1 - 1]
// array[2] * array[array.Length - 1 - 2]
// array[3] * array[array.Length - 1 - 3]

Дано натуральное трёхзначное число. Создайте массив, состоящий из
цифр этого числа. Младший разряд числа должен располагаться на 0-
м индексе массива, старший – на 2-м.

\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


Console.Write("Введите  число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[3];

for (int i = 0; i < 3; i++)
{
    array[i] = n % 10;
    n /= 10;
}
Console.WriteLine(string.Join(", ", array));

////////////////////////////////////////////////////////////////////////////////

// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3
// 8 -> 1 2 4 8
// 7 -> 1 7
// 15 -> 1 3 5 15
// 23 -> 1 23

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 20);
}

// функция возвращает True если число простое, иначе False
bool CheckProst(int x)
{
    for (int j = 2; j < x; j++)
        if (x % j == 0)
            return false;
    return true;
}


void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        CheckProst(array[i])

}

Console.Clear();
Console.Write("Введите число элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine(string.Join(", ", array));
ReleaseArray(array);
