//ДЗ 2.
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int TwoNumber (int num)
{
    int result;
    result = num / 10 % 10;
    return result;
}

Console.Clear();
Console.Write("Input three-digital number: ");
int inputNum = Convert.ToInt32(Console.ReadLine());
int result = TwoNumber(inputNum);
Console.WriteLine($"The second figure of number {inputNum} is {result}.");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdFigureCut (int num)
{   
    int inpNum = num;
    int result = 0;
    if (num < 100) 
        Console.WriteLine("No third figure!");
    else
    {
        while (num >= 1000)
            {
                num = num / 10;   
            }
        int number = num % 10;
        Console.WriteLine($"The third figure of number {inpNum} is {number}.");
    }   
    
}
Console.Clear();
Console.Write("Input integer number: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());

ThirdFigureCut(inputNumber);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет