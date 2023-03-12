// Демонстрация решения.
// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное само на себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Объявить тип переменной, объявить имя.

int inputNumber = Convert.ToInt32(Console.ReadLine());
// int square = inputNumber * inputNumber;
int square = Convert.ToInt32(Math.Pow(inputNumber, 2));

System.Console.WriteLine(square);
