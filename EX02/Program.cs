// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int x = Input("Введите искомое число: ");
int count = 0;
int[,] array = new int[5, 5];

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
            array[i, j] = new Random().Next(0, 10);
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
Console.WriteLine ();
PrintArray(array);
Console.WriteLine ();

for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            
            if (x == array [i,j])
            {
                count++;
            }
        }
    }

Console.WriteLine ();
if (count == 0) Console.WriteLine("Искомое число '" + x + "' в массиве не найдено."); Console.WriteLine ();
if (count > 0) Console.Write("Искомое число '" + x + "' найдено, имеет индексы: ");
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            
            if (x == array [i,j])
            {
                Console.Write("[" + i + "," + j + "] ");
            }
         }
    }
}