// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

System.Console.WriteLine("Введите цифру, обозначающую день недели:");
int num = Convert.ToInt32(Console.ReadLine());

if (num >=1 & num <=5)
{
    System.Console.WriteLine("Это не выходной");
}
else if (num >5 && num <8)
{
    System.Console.WriteLine("Это выходной");
}
else
{
    System.Console.WriteLine("Неподходящее число");
}