// ДЗ 1.
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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