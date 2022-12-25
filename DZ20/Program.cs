// Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет


void FillArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 9);
            Console.Write($"{array[i, j]}" + "  ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите строку: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[3, 4];
FillArray(array);

if (m < array.GetLength(0) && n < array.GetLength(1))
    Console.Write("[" + $"{array[m, n]}" + "]" + " -> Искомое число");
else
    Console.Write("[" + m + ", " + n + "] -> Такого числа в массиве нет!");

