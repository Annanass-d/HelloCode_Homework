while (true)
{
    Console.ReadLine();
    // Console.Clear();

    System.Console.WriteLine("64) Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
    System.Console.WriteLine("66) Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
    System.Console.WriteLine("68) Задча 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
    System.Console.WriteLine("0) End");

    int task = SetNumber("номер задачи");

    switch (task)
    {
        case 0: return; break;
        case 64: Task64(); break;
        case 66: Task66(); break;
        case 68: Task68(); break;
        default: System.Console.WriteLine("error"); break;
    }

}

// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void Task64()
{
    int num = SetNumber("num");
    FromNumTo1(num);
}

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N (рекурсия).

void Task66()
{
    int M = SetNumber("M");
    int N = SetNumber("N");
    int sum = SumBetweenNumbers(M, N);
    System.Console.WriteLine($"Сумма элементов промежутке между M и N = {sum}");
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

void Task68()
{
    int m = SetNumber("m");
    int n = SetNumber("n");
    int akker = Akkerman(m, n);
    System.Console.WriteLine($"Функция Аккермана = {akker}");
}


int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    else return -1;
}

int SumBetweenNumbers(int num1, int num2)
{
    if (num1 == num2) return num1;
    else return num2 + SumBetweenNumbers(num1, num2 - 1);
}

void FromNumTo1(int num)
{
    if (num < 0) System.Console.WriteLine("Введите число больше 1");
    if (num == 0) return;
    System.Console.Write($" {num} ");
    FromNumTo1(num - 1);
}

int SetNumber(string str)
{
    System.Console.WriteLine($"Введите число {str}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}