// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



Console.WriteLine("Поиск третьей цифры из трехзначного числа.");

Console.WriteLine("Введите число!");
int numberA = Convert.ToInt32(Console.ReadLine());


if (numberA < 100)
{
    Console.Write("Третьей цифры нет!");
}
 
else
 {
 while (numberA > 999) 
      
    if (numberA > 999)
    {
        numberA = numberA / 10; 
    }
    if (numberA > 99 & numberA < 999)
    {
    numberA = numberA % 10;
    Console.Write(numberA);
    }
 } 


   
   
   
   
    // else if (numberA < 100)
    // {
    //     Console.Write("Третьей цифры нет!");
    // }
    //  else
    // {
    //     int numberA = numberA % 10;
    // Console.Write(numberA);
    // }
// Console.Write(numberA);



// if(numberA < 999  &  numberA > 99)
// {
//    int first = numberA / 10;
//    int second = first % 10;
// Console.Write(second);
// }

// else 
// {
//    Console.Write("Число не трехзначное! ");
// }