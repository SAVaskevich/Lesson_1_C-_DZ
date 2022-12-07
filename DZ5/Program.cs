// Задача 3: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Проверка на кратность 7ми и 23 чила.");
Console.WriteLine("------------------------------------");
Console.WriteLine("Введите число!");
int numberA = Convert.ToInt32(Console.ReadLine());

int a = numberA % 7;
int b = numberA % 23;

if ( a == 0 & b == 0)
{
    Console.Write("Число кратно 7ми и 23ом!");
}
else
{
    Console.Write("Число не кратно 7ми и 23ом!");
}




