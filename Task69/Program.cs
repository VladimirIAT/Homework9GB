// Проверка возможности составления предложения из другого предложения
using static System.Console;
Clear();

Write("Введите строку исходник ");
var str = ReadLine()!;
var strWithoutSpaces = str.Replace(" ", "");
char[] varArray = strWithoutSpaces.ToCharArray();
Array.Sort(varArray);
Write("Введите строку которую требуется получить ");
var str1 = ReadLine()!;
var strWithoutSpaces1 = str1.Replace(" ", "");
char[] varArray1 = strWithoutSpaces1.ToCharArray();
Array.Sort(varArray1);

Comparison(varArray, varArray1);

void Comparison(char[] inArray1, char[] inArray2)
{
    if (inArray1.Length == inArray2.Length)
    {
        int p = 0;
        for (int i = 0; i < inArray1.Length; i++)
    {
        if (inArray1[i] == inArray2[i])
        {
            p++;  
        } 
    }
    if (p == inArray1.Length)
    {WriteLine("Возможно");} else {WriteLine("Не возможно");}    
    } else 
    {
        WriteLine("Не возможно");
    }
}