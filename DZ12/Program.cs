// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа.
// 452 -> 6
// 82 -> 2
// 9012 -> 3

Console.WriteLine("Введите число!");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("_____________");
int size = 0;
int result = 0;
int temp = n;
float temp1 = 0;
int temp2 = 0;
int[] array = new int[10];

for (int i = 0; i < 10; i++)
{
    temp2 = temp % 10;
    if (temp2 != 0)
    {
        array[i] = temp2;
        temp = temp / 10;
        size += 1;
        if (temp == 0)
        {
            i = 10;
        }
    }
}
for (int i = 0; i < size; i++)
{
    temp = n / array[i];
    temp1 = temp % 10;

    if (temp1 != 0)
    {
        result = result + array[i];
    }

}
Console.WriteLine(result);


