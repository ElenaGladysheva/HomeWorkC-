// Дз 3.

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance3D(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double result;
    result = Math.Sqrt(Math.Pow((xB-xA),2)+Math.Pow((yB-yA),2)+Math.Pow((zB-zA),2));
    result = Math.Round(result,2);
    return result;
}
Console.Clear();
Console.Write("Input coordinate xA: ");
double inputXA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate yA: ");
double inputYA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate zA: ");
double inputZA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate xB: ");
double inputXB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate yB: ");
double inputYB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate zB: ");
double inputZB = Convert.ToDouble(Console.ReadLine());

double result = Distance3D(inputXA, inputYA, inputZA, inputXB, inputYB, inputZB);
Console.WriteLine(result);

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
void DegreeCube(int num)
{
    int current = 1;
    while (current <= num)
    {
        double result = Math.Pow(current,3);
        Console.Write(result + " ");
        current++;
        
    } 
}
Console.Clear();
Console.Write("Input the integer positiv number: ");
int inputNum = Convert.ToInt32(Console.ReadLine());
if (inputNum <= 0)
   Console.WriteLine("Wrong number!");
else
   DegreeCube(inputNum);
*/

