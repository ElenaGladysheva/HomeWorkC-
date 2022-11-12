//ДЗ 4.
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
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
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
/*
int SumDigitInNumber (int number)
{
    int result = 0;
    int currentNum = number;
    int power = 1;

    while(currentNum !=0)
    {
        currentNum = currentNum / 10;
        result = result + number % (10*power)/power;
        power *= 10;

    }
    return result;

}

Console.Clear();
Console.Write("Input number: ");
int inpN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of digit in number {inpN} is {SumDigitInNumber(inpN)}.");
*/
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] array) //Метод случайного заполнения массива.
{
    int count = array.Length;
    int index = 0;
    while (index < count)
    {
        array[index] = new Random().Next(0,10); //числа [0,9]
        index++;
    }
}

void PrintArray(int[] array) // Метод вывода массива.
{
    int count = array.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(array[index]+" ");
        index++;
    }

}


 
int[] array = new int[8];

FillArray(array);
PrintArray(array);
Console.WriteLine();