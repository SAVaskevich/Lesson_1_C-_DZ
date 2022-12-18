// Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Если кол-во элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.
// 1, 3, 8, 3, 2 -> 11
// 8, 3, 4, 2 -> 28

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
int[] array = new int[n];
int size = n;
int temp;
Random random = new Random();
Console.Write("Массив: ");
for (int i = 0; i < n; i++)
{
    array[i] = random.Next(1, 10);
    Console.Write("{0} ", array[i]);
}
for (int i = 0; i < n / 2; i++)
{
    temp = array[i] * array[size - 1];
    size--;
    result += temp;
} 
Console.WriteLine();
Console.Write("Результат: ");
Console.WriteLine(result);