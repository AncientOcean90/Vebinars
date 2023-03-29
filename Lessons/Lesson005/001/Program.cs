// Напишите программу замены элемента массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2]  ->  [4, 8, -8, -2]


int[] CreateAndFillArray(int size, int leftRangeValue, int rightRangeValue)
{
    int [] array = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(leftRangeValue, rightRangeValue);
    }
    return array;
}



void PrintArrayInConsole(int[] array)
{
    System.Console.WriteLine(string.Join(",", array));  
}



void MultiplicationArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] * -1;
        }
}



int size = 12;
int[] array = CreateAndFillArray(size, -9, 10);

PrintArrayInConsole(array);
MultiplicationArray(array);
PrintArrayInConsole(array);
