﻿// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

int ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0 )
            count++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array); 
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Количество четных чисел в массиве: {ReleaseArray(array)}");