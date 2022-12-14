// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
int SummElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i += 2) count = count + array[i];
    return count;
}

Console.Clear();
Console.WriteLine($"Сумма элементов четных индексов в массиве равна: {SummElements(FillArray(10, -100, 100))}");