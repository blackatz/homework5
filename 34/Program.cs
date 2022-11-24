// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    Random random = new Random();
    while (index < length)
    {
        collection[index] = random.Next(100,1000);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int SumOf(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int sum = 0;

    while (index < count)
    {
        if(collection[index]%2 == 0)
        {
            sum = sum + 1;
        }

        index++;        
    }

    return sum;
}

Console.WriteLine("Введите количество переменных");
int n = int.Parse(Console.ReadLine()!);
int [] array = new int [n];

FillArray(array);
PrintArray(array);

int sum = SumOf(array);
Console.WriteLine();
Console.WriteLine("Количество четных чисел: " + sum);