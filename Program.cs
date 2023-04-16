// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Задача 19: программа проверяет является ли введённое пятизначное число палиндромом\n");

while(true) 
{
    Console.WriteLine("Введите целое ПЯТИЗНАЧНОЕ число:\n");
    if(int.TryParse(Console.ReadLine(), out int number)) 
    {
        int absNumber = Math.Abs(number);
        if(absNumber > 9999 && absNumber < 100000) 
        {
            Console.WriteLine(reverse(absNumber.ToString()));
            if(absNumber.ToString() == reverse(absNumber.ToString())) 
            { 
                Console.WriteLine("Да, введённое Вами число " + number + " является палиндромом!");
                break;
            }
            else 
            { 
                Console.WriteLine("Нет, введённое Вами число " + number + " не является палиндромом!");
                break; 
            }
        } 
        else Console.WriteLine("Введённое Вами число " + number + " НЕ является пятизначным!");
    } 
    else Console.WriteLine("Некорректно введено число!");
}

static string reverse (string str) 
{
    char[] charArray = str.ToCharArray();
    Array.Reverse( charArray );
    return new String(charArray);
}