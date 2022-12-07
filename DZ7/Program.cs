Console.WriteLine("Проверка числа на палиндромность.");
Console.WriteLine("Введите число!");
int n = Convert.ToInt32(Console.ReadLine());
int Digit1 = 0;
int Digit5 = 0;
int Digit2 = 0;
int Digit4 = 0;
int temp1 = n;
int temp2 = n;

if (n > 9999 & n < 100000 )
{
for (int i = 0 ;i < 4 ; i ++)

    {
        Digit1 = temp1 / 10;
        temp1 = Digit1;
    }

    Digit5 = n % 10;

    for (int i = 0 ;i < 3 ; i ++)

    {
        Digit2 = temp2 / 10;
        temp2 = Digit2;
        Digit2 = Digit2 % 10;
    }

    Digit4 = n / 10;
    Digit4 = Digit4 % 10;

    if (Digit1 == Digit5 & Digit2 == Digit4 )
    {
        Console.WriteLine("Число является палиндромом!");
    }
    else 
    {
        Console.WriteLine("Число не является палиндромом!");
    }
}
else
{
    Console.WriteLine("Число не является пятизначным!");
}


