//Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/* void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
}
Console.Write("Input a natural number N: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <=0) Console.Write("Not a natural number  ");
ShowNums(num); */

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/* int SumBetweenNums(int m, int n)
{
    if (m == n) 
        return n;
    return n + SumBetweenNums(m, n - 1);
}
    
Console.Write("Input a natural number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a natural number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of elements between {m} and {n} is {SumBetweenNums(m, n)}"); */

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermannFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
return AckermannFunction(m, n);
}
Console.Write("Input a positive number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a positive number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ackermann function for numbers ({m},{n}) = {AckermannFunction(m, n)}");