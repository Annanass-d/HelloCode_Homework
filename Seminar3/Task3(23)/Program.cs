// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("Введите число:");
double num = Convert.ToDouble(Console.ReadLine());

if (num <= 0){
    System.Console.WriteLine("Введен ноль или отрицательное число, введите другое число");
}

for (double i = 1; i <= num; i++)
{
    double result = Math.Pow(i, 3);
    System.Console.Write(result + "  ");
}