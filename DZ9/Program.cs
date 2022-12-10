// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



Console.WriteLine("Поиск рассояния между двух точек в пространстве.");
Console.WriteLine("===============================================.");
Console.WriteLine("Введите координаты первого обьекта!");
Console.Write("x = ");
Double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
Double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z = ");
Double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второго обьекта!");
Console.Write("x = ");
Double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
Double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z = ");
Double z2 = Convert.ToDouble(Console.ReadLine());
Double distance = 0;
distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.Write("Дистанция ->");
Console.WriteLine(distance);