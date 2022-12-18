// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Не использовать массив.

// M=5 ; 0, 7, 8, -2, -2 -> 2
// M=5 ; -1, -7, 567, 89, 223 -> 3
Console.Write("Введите M число: ");
int m = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = 0; i < m; i++)
{
    Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a > 0)
    {
        result++;
    }
}
Console.Write("Число положительных чисел: ");
Console.Write(result);