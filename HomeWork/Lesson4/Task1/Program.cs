//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int NaturalNumber(int number, int step)
{
    int step_num = 1;
    for (int i = 0; i < step; i++)
    {
        step_num *= number;
    }
    return step_num;
}


Console.WriteLine($"Число A в натуральной степени B = {NaturalNumber(ReadInt("Enter a number A: "), ReadInt("Enter a number B: "))}");