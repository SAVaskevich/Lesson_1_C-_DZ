// Задайте значения m и n. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от m до n. 
// Выполнить с помощью рекурсии.

// m = 1; n = 15 -> 120
// m = 4; n = 8. -> 30

int SumRange(int n, int m)
{
    if (n <= m)
    {
        return n + SumRange(n + 1, m);
    }
    else
    {
        return 0;
    }
}
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
int sum;
if (n < m)
{
    sum = SumRange(n, m);
}
else
{
    sum = SumRange(m, n);
}
Console.Write($"Сумма чисел: " + sum);


