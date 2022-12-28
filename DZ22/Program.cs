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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}" + "  ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
int index = 0;
int sum = int.MaxValue;
Console.WriteLine("Созданный массив:");
FillArray(array);
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    int temp = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp += array[i, j];
    }
    Console.WriteLine();
    Console.WriteLine("Сумма=" + sum);
    if (temp < sum)
    {
    sum = temp;
    index = i;
    }    
}
Console.WriteLine("Результат: " + index);
