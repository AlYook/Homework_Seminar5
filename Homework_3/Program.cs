//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = new double[5];
double diff = 0;
int i = 0;

for (; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100) + new Random().NextDouble();
    
}
Console.WriteLine(string.Join(", ", array));

double min = array[0];
double max = array[0];

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
    if (array[j] < min)
    {
        min = array[j];
    }
}
Console.WriteLine($"min {min} max {max}");
diff = max - min;
Console.WriteLine(diff);