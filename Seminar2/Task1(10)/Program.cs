// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num >99 && num<1000)
{
    int numFirstSecond = num / 10;
    int numSecond = numFirstSecond % 10;
    System.Console.WriteLine(numSecond);
}
else
{
    System.Console.WriteLine("Число не трехзначное");
}
