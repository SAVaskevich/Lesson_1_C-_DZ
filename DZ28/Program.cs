// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillArray(int[,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return array;
}

void PrintArray(int[,] pArray)
{
    for (int i = 0; i < pArray.GetLength(0); i++)
    {
        for (int j = 0; j < pArray.GetLength(1); j++)
        {
            Console.Write(pArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Спиральное заполнение массива.");
Console.WriteLine("_____________________________");

Console.Write("Количество строк: ");
int rowCount = Convert.ToInt32(Console.ReadLine());

Console.Write("Количество столбцов: ");
int colCount = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rowCount, colCount];

FillArray(array);
PrintArray(array);