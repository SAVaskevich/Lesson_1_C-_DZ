// Задайте две квадратные матрицы одинакового размера. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица:
// 18 20
// 15 18
void FillArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 9);
        }
    }
}
void PrintArray(int[,] array, string title)
{
    Console.WriteLine($"{title}:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}" + "  ");
        }
        Console.WriteLine();
    }
}
void CalcArray(int[,] A, int[,] B)
{
    int[,] r = new int[A.GetLength(0), A.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            for (int k = 0; k < B.GetLength(0); k++)
            {
                r[i, j] += A[i, k] * B[k, j];
            }
        }
    }
    PrintArray(r, "Результирующая матрица");
}
Console.Write("Введите колличество строк: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество колонок: ");
int colCount = Convert.ToInt32(Console.ReadLine());
int[,] arrayA = new int[rowCount, colCount];
int[,] arrayB = new int[rowCount, colCount];
FillArray(arrayA);
PrintArray(arrayA, "Созданный массив A");
FillArray(arrayB);
PrintArray(arrayB, "Созданный массив B");
CalcArray(arrayA, arrayB);