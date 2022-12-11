// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите A!");
int A = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("_______________________");
Console.WriteLine("Введите B!");
int B = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("_______________________");
int temp = A;
int result = 0;

for (int i = 1; i < B; i++)
     {
        temp = temp * A;
        result = temp;
     }

Console.Write("Ответ = ");
Console.WriteLine(result);
