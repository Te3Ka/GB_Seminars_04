/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А
7 -> 28
4 -> 10
8 -> 36
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

int SumNumbers(int num)
{
    if (num < 1)
        return -1;
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Программа выводит на экран сумму чисел от 1 до введённого целого положительного числа");
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out int A);
while (A <= 0)
{
    Console.Write("Введено число меньше 1, повторите ввод: ");
    int.TryParse(Console.ReadLine(), out A);
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {SumNumbers(A)}");

Author();