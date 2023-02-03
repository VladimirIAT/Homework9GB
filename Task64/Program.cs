//Задача 64: Напишите программу, которая реализует рекурсивный метод вывода всех натуральных числел в промежутке от N до 1.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using static System.Console;
Clear();
Write(GetNumbers1(10));

string GetNumbers1(int num) 
{
    if (num == 1) return num.ToString();
    else
    return $"{num}, {GetNumbers1(num - 1)}";
}
