/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4-> 16*/

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
void AinB(int number1, int number2)
{
    Console.WriteLine(Math.Pow(number1, number2));
}
int A = ReadInt("Введите число A: ");
int B = ReadInt("Введите число B: ");
AinB(A, B);