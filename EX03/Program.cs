// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Задайте размеры массива mXn");
int m = Input("Введите m: ");
int n = Input("Введите n: ");
int cnt = 0;
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

double Sum (double a)
{
    double x = 0;
    int count = 0;
    int j = cnt;
    {
    for(int i = 0; i < array.GetLength(0); i++)
    {
        x = x+array[i,j];
        count++;
    }
        x = x/count; return x;
    }   
}

Console.WriteLine("находим среднее арифметическое:");

while (cnt < n)
{
    Console.Write(Sum(n) + " ");
    cnt++;
}
