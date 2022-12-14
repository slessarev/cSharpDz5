// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i=0; i<size; i++)
    {
        array[i]= new Random().Next(minValue,maxValue);
    }
    Console.WriteLine(String.Join(" ",array));
    return array;
}
void ShowEvenNumbers(int[] array)
{
    int count=0;
    for (int i=0; i<array.Length; i++) 
    {
        if (array[i]%2==0) count++;
    }
    Console.WriteLine("Количество четных чисел в массиве :" + count);
}

Console.Clear();
ShowEvenNumbers(FillArray(20,100,1000));
