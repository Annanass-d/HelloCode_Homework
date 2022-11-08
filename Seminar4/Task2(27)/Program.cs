// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SetNumber()
{
    System.Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumFigures(int number)
{
    int SumFig = 0;
    int count = 0; // для перебора цифр в числе

    for (int countNum = number; countNum >0; countNum/=10)
    {
        count = countNum %10;
        SumFig += count; 
    }
    return SumFig;
}


int num = SetNumber();
int result = SumFigures(num);
System.Console.WriteLine(result);
