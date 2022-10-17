// ДЗ 1.

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Clear();

Console.Write("Input the first number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int numB = Convert.ToInt32(Console.ReadLine());

int max;
if (numA >= numB)
    max = numA;
else 
    max = numB;
Console.WriteLine($"Max number is {max}");
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Clear();

Console.Write("Input the first number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;

if (numB > max) max = numB;
if (numC > max) max = numC; 

Console.WriteLine($"Max number is {max}");
*/

// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();

Console.Write("Input the integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) 
   Console.WriteLine ("Yes");
else
   Console.WriteLine ("No");