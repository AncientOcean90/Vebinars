// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(System.Console.ReadLine());
int b = a / 10 % 10;
System.Console.WriteLine(b);




// int inputNumberWithMessage(string message)
// {
//     Console.WriteLine(message);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;   
// }

// int number = inputNumberWithMessage("Введите трехзначное число");

// if (number < 100 || number > 999)
// {
//     System.Console.WriteLine("Неверный ввод");
//     return;
// }

// int result = number / 10 % 10;
// System.Console.WriteLine(result);



