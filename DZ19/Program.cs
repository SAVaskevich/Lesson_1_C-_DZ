﻿// Задача 1. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами. 
// Тип данных для элементов выбрать double, 
// наличие ненулевой дробной части обязательно.
// m = 3, n = 4.
// 0.5 7.96 -2.78 -0.2
// 1.7 -3.3 8.574 -9.9
// 8.5 7.87 -7.1 9.15

void FillArray(double[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-9, 9) + random.NextDouble();
            Console.Write($"{array[i, j]}");
            Console.Write("   ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите колличество сторок: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
FillArray(array);


