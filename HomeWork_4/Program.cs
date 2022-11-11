//ДЗ 4.
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int DegreeAB (int a, int b)
{
    int result = 1;
    for(int i = 1; i <=b; i++ )
        result *= a;
    return result;
}

Console.Clear();
Console.Write("Input A: ");
int inpA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B: ");
int InpB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The number {inpA} to the power of {InpB} is {DegreeAB(inpA, InpB)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]