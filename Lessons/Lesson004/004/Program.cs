// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


void FillArrayRandomNumbers(int[] array)
{
    Random Rnd = new Random();

    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Rnd.Next(0, 2);
        }   
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1)
            System.Console.Write(array[i]);
        else
            System.Console.Write(array[i] + ", ");
    }   
}

int [] Arr = new int[8];
FillArrayRandomNumbers(Arr);
PrintArray(Arr);





// int [] Arr = new int[8];
// Random Rnd = new Random();
// for(int i = 0; i < Arr.Length; i++)
// {
//     Arr[i] = Rnd.Next(0, 2);
// }
// for(int i = 0; i < Arr.Length; i++)
// {
//     System.Console.Write (Arr[i] + " ");
// }