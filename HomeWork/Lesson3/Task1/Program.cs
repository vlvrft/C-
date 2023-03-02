// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
System.Console.WriteLine("Введите пятизнаное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numb = Convert.ToString(num);

while(true)
{
    if(numb.Length == 5)
    {
        if(numb[0] == numb[4] && numb[1] == numb[3])
        {
            System.Console.WriteLine("Число является палиндромом");
            break;
        }
        else
        {
            System.Console.WriteLine("Число не является палиндромом");
            break;
        }
    }
    else
    {
        System.Console.WriteLine("Вы ввели не пятизначное число");
        return;
    }
    
}


