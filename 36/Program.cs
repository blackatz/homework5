// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    Random random = new Random();
    while (index < length)
    {
        collection[index] = random.Next(-100,101);
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


int SumOf(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int sum = 0;

    while (index < count)
    {
        if(index%2 == 0)
        {
            sum = sum + collection[index];
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
Console.WriteLine("Сумма чисел на нечетных позициях: " + sum);