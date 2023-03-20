// Сложить А и В
// void - ничего не возвращаем
// тип данных, которые возвращаем. Имя функции. 

int inputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;   
}

int Summ(int a, int b) 
{
   return  a + b;
}


int A = inputNumberWithMessage("Введите А");
int B = inputNumberWithMessage("Введите B");

System.Console.WriteLine(Summ(A, B));