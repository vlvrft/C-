// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int WriteNumber(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + WriteNumber(m, n);
    }
    return result;
}

void SumPrint(int m, int n)
{
    if (m < n) WriteNumber(m - 1, n);
    else WriteNumber(n, m - 1);
    System.Console.WriteLine(WriteNumber(m - 1, n));
}

int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");
SumPrint(m, n);