//  Задача 27: Напишите программу, 
// которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberSum(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;   
}

Console.WriteLine($"Сумма цифр в числе {NumberSum(ReadInt("Enter a number: "))}");
