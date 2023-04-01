// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int [] ArrayInput (int length)
{
    int[] array = new int[length];
    Random rnd = new Random();

    for(int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 1000);
    }
    return array;
}

void PrintArray (int[] array)
{
  for(int i = 0; i <= array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int SumElementsOddPositionsArray (int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
        {
            sum += array[i];
        }
        return sum;  
}
 
System.Console.WriteLine("Массив:");
int[] array = ArrayInput(8);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов на нечётных позициях: {SumElementsOddPositionsArray(array)}");