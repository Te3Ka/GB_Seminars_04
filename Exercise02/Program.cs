/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

int NumberDigits(int num)
{
    if (num < 1)
        return -1;
    int ind = 0;
    while (num > 0)
    {
        num /= 10;
        ind++;
    }
    return ind;
}

Console.WriteLine("Программа показывает количество цифр в ведённом числе.");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    Console.WriteLine("Введено число меньше 1. Выполнение программы прервано.");
    return;
}

Console.WriteLine(NumberDigits(num));

Author();