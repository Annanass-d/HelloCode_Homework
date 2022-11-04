// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

var random = new Random();
int num = random.Next(100,1000);
System.Console.WriteLine(num);

int numFirstSecond = num / 10;
int numSecond = numFirstSecond % 10;

System.Console.WriteLine(numSecond);