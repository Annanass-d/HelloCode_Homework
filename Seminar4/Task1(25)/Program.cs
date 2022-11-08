// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int SetNumber(string str)
{
    System.Console.WriteLine($"Введите число {str}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int NumAPowB (int numA, int numB)
{
    int result = numA;
    for (int i = 1; i < numB; i++)
    {
        result = result * numA;
    }
    return result;
}

int numberA = SetNumber("A");
int numberB = SetNumber("B");
int res = NumAPowB(numberA,numberB);
System.Console.WriteLine(res);