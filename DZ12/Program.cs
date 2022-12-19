// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа.
// 452 -> 6
// 82 -> 2
// 9012 -> 3

Console.WriteLine( "Введите число!" );
int n = Convert.ToInt32( Console.ReadLine() );

int ret = Parser( n );
Console.WriteLine( "Result: " + ret.ToString() );

static int Parser( int input )
{
    int count  = input.ToString().Length;
    int sample = input;
    int result = 0;

    for ( int i = 0; i < count; i++ )
    {
        int element = input % 10;
        input /= 10;
        if ( element > 0 )
        {           
            if ( ( sample % element ) == 0 )
            {
                result += element;
            }
        
        }
    }
    return result;
}


