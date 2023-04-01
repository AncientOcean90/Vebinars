// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double [] ArrayInput (int length)
{
    double[] array = new double[length];
    Random rnd = new Random();

    for(int i = 0; i < length; i++)
    {
        array[i] = rnd.NextDouble() * (100 - 10) + 10;
    }
    return array;
}

void PrintArray(double[] array)
{
  for(int i = 0; i <= array.Length - 1; i++)
    {
        Console.WriteLine ($"{Math.Round(array[i], 2)}");
    }
}

double DifferenceMaxMinArrayElements(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }
    }
    System.Console.WriteLine($"Max = {max}, Min = {min}");
    return max - min; 
}
 
System.Console.WriteLine("Массив:");
double[] array = ArrayInput(10);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов на нечётных позициях: {DifferenceMaxMinArrayElements(array)}");