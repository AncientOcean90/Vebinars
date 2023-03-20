// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int inputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());  
}

int SummDigitInNumber(int number)
{
    int summ = 0;

    for(int i = 1; i <= number; i++)
    {
        summ += i;
    }   

    return summ;
}
int A = inputNumberWithMessage("Введите A");
System.Console.WriteLine(SummDigitInNumber(A));