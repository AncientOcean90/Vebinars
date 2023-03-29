// Задайте массив. Найдите число, которое определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3]  -> нет
// 3; массив [6, 7, 19, 345, 3]  -> да


int[] CreateAndFillArray(int size, int leftRangeValue, int rightRangeValue)
{
    int [] array = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(leftRangeValue, rightRangeValue + 1);
    }
    return array;
}

void PrintArrayInConsole(int[] array)
{
    System.Console.WriteLine(string.Join(",", array));  
}

void FindTheNumber(int[] array, int enterNumber) 
{
    for(int i = 0; i < array.Length; i++)
        {
            if (array[i] == enterNumber)
            {
                System.Console.WriteLine("Да");
                return;
            }
        }
    System.Console.WriteLine("Нет");
}

int size = 12;
int[] array = CreateAndFillArray(size, -9, 10);

PrintArrayInConsole(array);
int enterNumber = Convert.ToInt32(Console.ReadLine());
FindTheNumber(array, enterNumber);