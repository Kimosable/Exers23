// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число");
int number = int.Parse(System.Console.ReadLine());

int[] Cube(int number)
{
    int [] result = new int[number];
    for(int i = 0; i < number; i++)
    {
        result[i] = (int)Math.Pow(i+1, 3);
    }
    return result;
}

void PrintArray(int[] result)
{
 for (int i = 0; i < result.Length; i++)
    {
        System.Console.WriteLine(result [i]);
    }
}

PrintArray(Cube(number));