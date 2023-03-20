// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int index = (int) Math.Log10(number) + 1;

System.Console.WriteLine(index);

