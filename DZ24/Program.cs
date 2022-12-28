// Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив. Обратите внимание, 
// что максимальный размер такого массива ограничен. Проверку эл-та на присутствие 
// в массиве можно вынести в отдельную функцию.
// Например,
// 11 22 78
// 12 47 96
// 25 87 88

void PrintArray(int[,] array)
{
    Console.WriteLine("Созданный массив c проверкой на повторения:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}" + "  ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int rand = random.Next(10, 99);
            do
            {
                rand = random.Next(10, 99);
            } while (!ArrayCheck(array, rand));
            array[i, j] = rand;
        }
    }
}
static bool ArrayCheck(int[,] array, int random)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == random)
            {
                return false;
            }
        }
    }
    return true;
}
int[,] array = new int[3, 3];
FillArray(array);
PrintArray(array);

