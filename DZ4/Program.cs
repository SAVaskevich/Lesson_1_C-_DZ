Console.WriteLine("Поиск максимального числа.");

Console.WriteLine("Введите первое число!");
int numberA = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("Введите второе число!");
int numberB = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("Введите третье число!");
int numberC = Convert.ToInt32( Console.ReadLine());

int max = 0;

if(numberA > numberB)
{
    max = numberA;
}
else 
{
    max = numberB;
}
if(numberC > max)
{
    max = numberC;
}
else
{
   Console.WriteLine("Они равны!");   
}
Console.WriteLine("Максимальное число равно ");
Console.Write(max);

// Или вариант ниже!


//Console.WriteLine("Поиск максимального числа.");

//Console.WriteLine("Введите первое число!");
//int numberA = Convert.ToInt32( Console.ReadLine());

//Console.WriteLine("Введите второе число!");
//int numberB = Convert.ToInt32( Console.ReadLine());

//Console.WriteLine("Введите третье число!");
//int numberC = Convert.ToInt32( Console.ReadLine());

//if(numberA > numberB  &  numberA > numberC)
//{
//    Console.Write("Максимальное число ");
//    Console.WriteLine( numberA);
//}

//else if(numberB > numberA  &  numberB > numberC)
//{
//    Console.Write("Максимальное число ");
//    Console.WriteLine( numberB);
//}

//else if(numberB < numberC  &  numberA < numberC)
//{
//    Console.Write("Максимальное число ");
//    Console.WriteLine( numberC);
//}

//else
//{
//    Console.Write("Они равны!");   
//}