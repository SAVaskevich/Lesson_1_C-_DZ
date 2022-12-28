// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 9);
        }
    }
}
void PrintArray(int[,] array)
{
    Console.WriteLine("Созданный массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}" + "  ");
        }
        Console.WriteLine();
    }
}
void SmallestAmountLine(int[,] array)
{
    int minSum = 0;
    int rowNum = -1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }
        Console.WriteLine($"Сумма={rowSum}");

        if ((rowSum < minSum) || (rowNum == -1))
        {
            minSum = rowSum;
            rowNum = i;
        }
    }
    Console.WriteLine($"\tIndex строки: {rowNum}\n\tМинимальная сумма: {minSum}");
}
int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
SmallestAmountLine(array);

