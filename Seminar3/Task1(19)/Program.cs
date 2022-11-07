// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите положительное пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());

void CheckPalindromeNumber(int num)
{
    int firstNum = num / 10000;
    int secondNum = (num / 1000) % 10; // 12821/1000 = 12, 12 % 10 = 2
    int fourthNum = (num % 100) / 10; // 12821 % 100 = 21, 21/10 = 2
    int fifthNum = num % 10;

    if (firstNum == fifthNum && secondNum == fourthNum)
    {
        Console.WriteLine($"Число {num} - палиндром");
    }
    else
    {
        Console.WriteLine($"Число {num} - не палиндром");
    }
}

int firstNum = num / 10000;

if (firstNum >0 && firstNum < 10) // проверка, явялется ли число пятизначным
{
    CheckPalindromeNumber(num);
}
else
{
    Console.WriteLine("Введено не пятизначное число или отрицательное");
}