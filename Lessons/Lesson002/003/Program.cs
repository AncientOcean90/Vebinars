// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int firstNumber = Convert.ToInt32(Console.ReadLine());
// int secondNumber = firstNumber / 7 == 0 и firstNumber / 23 == 0;

if (firstNumber % 7 == 0 && firstNumber % 23 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
