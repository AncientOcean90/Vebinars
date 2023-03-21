// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


int inputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;  
}

int SummDigitsNumber(int number)
{
    int summ = 0;
    while(number > 0)
    {
        summ = summ + number % 10;
        number = number / 10;
    }
    return summ;
}

int number = inputNumberWithMessage("Введите число");
System.Console.WriteLine(SummDigitsNumber(number));