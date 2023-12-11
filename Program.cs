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
   
    //--------------------------------------------------------------------------------------------------------------------------------------------
    //
    //
    array = [4, 16, 30, 12, 9, 22, 46, 58, 74, 82]
    count = 0
        for number in array:
        if number % 2 == 0:
        count += 1
        print(“Количество четных чисел:”, count)