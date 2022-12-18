// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int result = 0;
int[] array = new int[4];
Random random = new Random();
Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 99);
    Console.Write("{0} ", array[i]);
}
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        result = result + array[i];
    }
}
Console.WriteLine();
Console.Write("Сумма чисел массива на не четных индексах: ");
Console.WriteLine(result);

