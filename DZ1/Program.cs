// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



Console.WriteLine("Поиск второй цифры из трехзначного числа.");

Console.WriteLine("Введите число!");
int numberA = Convert.ToInt32( Console.ReadLine());


if(numberA < 999  &  numberA > 99)
{
   int first = numberA / 10;
   int second = first % 10;
Console.Write(second);
}

else 
{
   Console.Write("Число не трехзначное! ");
}

