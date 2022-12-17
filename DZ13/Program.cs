// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int result = 0;
int[] array = new int[4];
Random random = new Random();
Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
    {
    array[i] = random.Next(100,999);               
    Console.Write("{0} ", array[i]);               
    }
            
for (int i = 0; i < array.Length; i++)
    {                              
    if(array[i] % 2 == 0)
        {
        result += 1;
        }

    }           
Console.WriteLine();          
Console.Write("Количество четных чисел: ");
Console.WriteLine(result);