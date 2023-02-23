/*Задача 29: Напишите программу, которая задаёт массив из элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33-> [6, 1, 33]*/


int GenArray()
{
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}
void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 100);
    }
}

void PrintArray(int[] arr)
{
    Console.WriteLine("[" + string.Join(", ", arr) + "]");
}
int[] array = new int[GenArray()];
FillArray(array);
PrintArray(array);
