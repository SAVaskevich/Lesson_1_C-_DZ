Console.WriteLine("Поиск всех четных чисел.");
int a = 1;
Console.WriteLine("Введите число!");
int n = Convert.ToInt32( Console.ReadLine());

while (a < n)
    if(a % 2 == 0)
    {
        Console.WriteLine(a);
        a++;
    }
    else 
    {
        a++;
    }
  