﻿// Функцию не коммитить =)
int[] Random(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}



// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] array = Random(10,100,999);
Console.WriteLine($"[{String.Join(", ", array)}]");
int chet=0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2==0)
    {
        chet ++;
    }
}
Console.WriteLine($"Количество четных чисел в данном массиве: {chet}");



// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19     [-4, -6, 89, 6] -> 0

// Console.Clear();
// int[] array = Random(10,-10,10);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// int sum=0;
// for (int i = 0; i < array.Length; i+=2)
// {
//     sum=sum+array[i];
// }
// Console.WriteLine($"Суммa элементов, стоящих на нечётных позициях: {sum}");



// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// На семинаре договорились с преподователем, что числа будут целые, сказала, что вас предупредит.

// Console.Clear();
// int[] array = Random(10,1,10);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// int min = array[0];
// int max = array[0];
// for (int i = 1; i < array.Length; i++)
// {
//     if (array[i]>max)
//     {
//         max=array[i];
//     }
//     if (array[i]<min)
//     {
//         min=array[i];
//     }
// }
// Console.WriteLine($"Разницу между максимальным и минимальным элементов массива: {max-min}");