/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

int[] RandomeArray(int[] arrayNew)
{
    for(int i = 0; i < arrayNew.Length; i++)
    {
        arrayNew[i] = new Random().Next(0, 2);
    }
    return arrayNew;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Программа выводит массив из 8 элементов,"
+ "заполненный 0 и 1 в случайном порядке.");

int[] array = new int[8];
RandomeArray(array);
PrintArray(array);

Author();