/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

int Factorial(int N)
{
    int factorial = 1;
    while (N >= 1)
    {
        factorial *= N;
        N--;
    }
    return factorial;
}

Console.WriteLine("Программа считает факториал введённого положительного числа.");
Console.Write("Введите число, больше 1: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0)
{
    Console.WriteLine("Введено число меньше 1.");
    return;
}

Console.WriteLine(Factorial(num));

Author();