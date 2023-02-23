/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Sum(int a)
{
    int res = 0;
    while (a > 0)
    {
        int b = a % 10;
        a = a / 10;
        res = res + b;
    }
    Console.WriteLine(res);
}
int N = ReadInt("Input Number: ");
Sum(N);
