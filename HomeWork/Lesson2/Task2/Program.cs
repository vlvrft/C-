 // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введи число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

if (threeDigitNumber >= 100)
{
    string stringNumber = Convert.ToString(threeDigitNumber);
    Console.WriteLine(threeDigitNumber);
    Console.WriteLine("третья цифра этого числа -> " + stringNumber[2]);
}
else
{
    Console.WriteLine(threeDigitNumber);
    System.Console.WriteLine("Третье число отсутвует");  
}





