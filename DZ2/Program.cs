Console.WriteLine("Поиск максимального числа.");

Console.WriteLine("Введите первое число!");
int numberA = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("Введите второе число!");
int numberB = Convert.ToInt32( Console.ReadLine());

if(numberA < numberB)
{
    Console.Write("Максимальное число ");
    Console.WriteLine( numberB);
}

else if(numberA > numberB)
{
    Console.Write("Максимальное число ");
    Console.WriteLine( numberA);
}

else
{
    Console.Write("Они равны!");   
}


