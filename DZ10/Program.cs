// Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.
// 3 -> [1, 8, 27].
// 5 -> [1, 8, 27, 64, 125]
// Указание: Вывод массива вынести в отдельную функцию.



Console.WriteLine("Введите размер массива!");
Console.WriteLine("_______________________");
int n = Convert.ToInt32( Console.ReadLine());
int[] array = new int[n];
void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);   
        }
}

for (int i = 0; i < n; i++)
     {
        array[i] = i;
        array[i] = (i+1) * (i+1) * (i+1);
     }


Console.WriteLine("_______________________");
PrintArray();












// Console.WriteLine("______________________");
// Console.WriteLine("{0}", string.Join("\n", array));
