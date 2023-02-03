//Задача 66: Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
using static System.Console;
Clear();
WriteLine(SumNum(10,20));

int SumNum(int m, int n) 
{
    if (m == n) return n;
    else
    return SumNum(m + 1, n) + m;
}
