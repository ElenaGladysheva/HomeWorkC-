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
Console.WriteLine($"The second digit of number {inputNum} is {result}.");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdFigureCut (int num)
{   
    int result = num;
    if (num < 100) 
    {
        result = -1;
    }
    else
    {
        while (result >= 1000)
        {
            result = result / 10;   
        }
        result = result % 10;
    }   
    return result;
}
Console.Clear();
Console.Write("Input integer number: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());

int thirdDigit = ThirdFigureCut(inputNumber);
if (thirdDigit == -1)
    Console.WriteLine("No third digit!");
else
    Console.WriteLine($"The third digit of number {inputNumber} is {thirdDigit}.");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*

bool CheckWeekend (int num)
{
    if (num == 6 || num == 7)
        return true;
    else
        return false;

}

Console.Clear();
Console.Write("Input the number of week's day: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
if (CheckWeekend(inputNumber))
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
*/
