// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// [3.3 7.76 22 2 78.67] -> 76.67

double result = 0;
double[] array = new double[4];
double max = 0;
double min = 100;
Random random = new Random();
Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100) + random.NextDouble();               
        Console.Write("{0} ", array[i]);               
        if ( array[i] > max)
        {
            max = array[i];
            
        }  
        if ( array[i] < min)
            {
            min = array[i];
            }   
    }
Console.WriteLine();
Console.Write("Максимальное число: ");
Console.Write(max);              
Console.WriteLine();
Console.Write("Минимальное число: ");
Console.Write(min); 
result = max - min;
Console.WriteLine();          
Console.Write("Разница максимального и минимального числа массива: ");
Console.WriteLine(result);