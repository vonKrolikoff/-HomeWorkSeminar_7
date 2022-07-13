// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int m = Input("Введите m: ");
int n = Input("Введите n: ");

int[,] array = new int[m, n];

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void PourArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

PourArray(array);
PrintArray(array);
Console.WriteLine();
