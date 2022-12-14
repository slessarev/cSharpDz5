﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//_______________________________________________Дисклеймер________________________________________________________

// Вещественные числа — это числа, у которых есть дробная часть (она может быть нулевой). 
// Они могут быть положительными или отрицательными. Вот несколько примеров: 15 56.22 0.0 1242342343445246 - 232336.11. 
// Как же устроено вещественное число? Достаточно просто: оно состоит из целой части, дробной части и знака.

// В примере задачи используются целые числа.  Преподаватель на семинаре, так же ответил, что нужно использовать целые числа.
// __________________________________________________________________________________________________________________

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    Console.WriteLine(String.Join(" ", array));
    return array;
}
int DiffElements(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    int dif = max - min;
    return dif;
}
Console.Clear();
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {DiffElements(FillArray(10, -100, 100))}");