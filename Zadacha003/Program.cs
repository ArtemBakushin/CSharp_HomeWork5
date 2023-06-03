/*
Задача 29:
Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/

int size = 8;
int[] array = new int [size];
for (int i = 0 ; i < size ; i++)
{
    array[i] = new Random().Next(99);

}
 Console.WriteLine($"Массив [{String.Join("; ", array)}]");