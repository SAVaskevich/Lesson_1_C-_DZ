// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа.

// 452 -> 6

// 82 -> 2

// 9012 -> 3

Console.WriteLine("Введите число!");
int n = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("_____________");
int result = 0;
int temp = n;
for (int i = 2; i < 10; i++)
{
    temp = n / i;
    temp = temp % 10;
    
    if (temp == 0)
    {
        result = result + i;
    
    }
}
Console.WriteLine(result);