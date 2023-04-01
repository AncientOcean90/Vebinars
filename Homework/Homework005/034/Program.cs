// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] ArrayInput (int length)
{
    int[] array = new int[length];
    Random rnd = new Random();

    for(int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);
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

int FindEvenNumbersArray (int[] array)
{
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                counter++;
            }
        }
        return counter;  
}
 
System.Console.WriteLine("Массив:");
int[] array = ArrayInput(4);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел: {FindEvenNumbersArray (array)}");