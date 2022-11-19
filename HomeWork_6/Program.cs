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

void PointCrossLine(int b1,int k1, int b2, int k2) 
{
    int x = (b2 - b1) / (k1 - k2);
    int y = k1*x + b1;

    Console.WriteLine($"The point of crossing is ({x},{y})"); 
}


Console.Clear();
Console.Write("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

if ((k1 == k2) && (b1 == b2))
    Console.WriteLine("Прямые совпадают!");
    else
        if (k1 == k2)
            Console.WriteLine("Прямые параллельны!");
        else
            PointCrossLine(b1, k1, b2, k2);


