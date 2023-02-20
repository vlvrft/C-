 
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да 
// 7 -> да 
// 1 -> нет

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 1:
        System.Console.WriteLine("Понедельник-не выходной");
        break;
    case 2:
        System.Console.WriteLine("Вторник-не выходной");
        break;
    case 3:
        System.Console.WriteLine("Среда-не выходной");
        break;
    case 4:
        System.Console.WriteLine("Четверг-не выходной");
        break;
    case 5:
        System.Console.WriteLine("Пятница-не выходной");
        break;
    case 6:
        System.Console.WriteLine("Суббота-выходной");
        break;
    case 7:
        System.Console.WriteLine("Воскресенье-выходной");
        break;
    default:
        System.Console.WriteLine("Такого дня недели нет");
        break;
}


