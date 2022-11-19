//ДЗ 6.

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
/*
int PositivInputNum (int m) //Метод подсчета положительных чисел, введенных с клавиатуры.
{   
    int count = 0;
    Console.WriteLine($"Input the {m} numbers:");
    for(int i = 0; i < m; i++)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0) 
            count ++;
    }

    return count;

}

Console.Clear();
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The count of positiv numbers is {PositivInputNum(m)}");
*/
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
