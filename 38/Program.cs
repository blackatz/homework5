// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    Random random = new Random();
    while (index < length)
    {
        collection[index] = random.Next(-10,10);
        index++;
    }
}

void PrintArray(int[] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        Console.Write(input[i]);
        if (i != input.GetLength(0) - 1)
        Console.Write(", ");
    }
        Console.WriteLine();
    }


void MinOrMax(int[] collection)
{
    int count = collection.Length;
    int min = 0;
    int max = 0;
    int finish = 0;
    int i = 0;

    while (i < count)
    {
        if (collection[i] > max) 
        {
            max = collection[i];
        }
        if (collection[i] < min) 
        {
            min = collection[i];
        }
        i++;
    }
    finish = max - min;
    Console.WriteLine("Минимальное значение: " + min);
    Console.WriteLine("Максимальное значение: " + max);
    Console.WriteLine("Разница между значениями: " + finish);

}

Console.WriteLine("Введите количество переменных");
int n = int.Parse(Console.ReadLine()!);
int [] array = new int [n];

FillArray(array);
PrintArray(array);
MinOrMax(array);
