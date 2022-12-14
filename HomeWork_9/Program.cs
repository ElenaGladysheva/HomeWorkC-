//ДЗ 9
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNumbers(n-1);
   
}
Console.Clear();
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());       
ShowNumbers(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
 int SumMtoN (int m, int n)
 {
    if (m <= n) return SumMtoN (m+1, n) + m;
    return 0;
 }
Console.Clear();
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine($"The sum of number is {SumMtoN (m, n)}."); 
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAkkerman(int m, int n)
{
    if (m == 0) return  n+1;
    else 
        if ((m != 0) && (n == 0)) return FunctionAkkerman(m - 1, 1);
        else
            return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));


}

Console.Clear();
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

if(m < 0 || n < 0) Console.WriteLine("Invalid entered values!");
else
    Console.WriteLine(FunctionAkkerman(m, n));