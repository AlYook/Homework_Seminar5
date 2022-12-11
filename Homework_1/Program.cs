// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int count = 0;
int[] array = new int[5];
int i = 0;

for (; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    
}
Console.WriteLine(string.Join(", ", array));

foreach (int el in array)
{
    if (el % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(count);