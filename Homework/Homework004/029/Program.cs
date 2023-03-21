// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int Promt(String message) 
{
    System.Console.WriteLine(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); 
    return result; 
}

int[] GenerateArray(int Lenght, int minValue, int maxValue) 
{
    int[] array = new int[Lenght]; 
    Random random = new Random(); 
    for (int i = 0; i < Lenght; i++) 
    {
        array[i] = random.Next(minValue, maxValue +1); 
    }
    return array;
}

void PrintArray(int[] array) 
{
    System.Console.Write("[");
    for (int i =0; i < array.Length -1; i++)
    {
        System.Console.Write($"{array[i]}, "); 
    }
    System.Console.Write($"{array[array.Length-1]}"); 
    System.Console.WriteLine("]");
}

int lenght = Promt("Длина массива: ");
int min = Promt("Начальное значение, случайного числа: ");
int max = Promt("Конечсное значение, случайного числа: ");
int[] array = GenerateArray(lenght, min, max);

PrintArray(array);