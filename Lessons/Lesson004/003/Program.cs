// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 5 -> 120

int inputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;  
}

int MultiplicationDigitsNumber(int number)
{
    int result = 1;
    for(int i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;
}

int A = inputNumberWithMessage("Введите число");
System.Console.WriteLine(MultiplicationDigitsNumber(A));







// Напишите программу, которая принимает на вход число N и выдает произведение все цифр в числе

// int inputNumberWithMessage(string message)
// {
//     System.Console.WriteLine(message);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;  
// }

// int MultiplicationDigitsNumber(int number)
// {
//     int pr = 1;
//     while(number > 0)
//     {
//         pr *= number % 10;
//         number /= 10;
//     }
//     return pr;
// }

// int number = inputNumberWithMessage("Введите число");
// System.Console.WriteLine(MultiplicationDigitsNumber(number));
