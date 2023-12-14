internal class Program
{
    private static void Main(string[] args)
    {
        void InputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = new Random().Next(0, 20);
        }

//         // функция возвращает True если число простое, иначе False
//         bool CheckProst(int x)
//         {
//             for (int j = 2; j < x; j++)
//                 if (x % j == 0)
//                     return false;
//             return true;
//         }


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
    }
}