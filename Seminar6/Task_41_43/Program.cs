System.Console.WriteLine("41) Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
System.Console.WriteLine("43) Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
System.Console.WriteLine("0) End");

int numTask = GetNumFromUser("task");

switch (numTask)
{
    case 0: return; break;
    case 41: Task41(); break;
    case 43: Task43(); break;
    default: System.Console.WriteLine("error"); break;
}



// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Task41()
{
    System.Console.WriteLine("Введите М чисел подряд через пробел");
    string str = Console.ReadLine();
    string[] arr = str.Split(" ");

    int[] array = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = Convert.ToInt32(arr[i]);
    }

    int result = CountPositiveNum(array);
    System.Console.WriteLine($"Введено чисел больше 0: {result}");
}



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Task43()
{
    int k1 = GetNumFromUser("k1");
    int b1 = GetNumFromUser("b1");
    int k2 = GetNumFromUser("k2");
    int b2 = GetNumFromUser("b2");

    int[,] A = new int[2, 2] // матрица системы
    {
    {k1, -1},
    {k2, -1},
    };
    // PrintArray(A);

    int[,] B = new int[2, 1] // столбец свободных коэффициентов
    {
    {-b1},
    {-b2},
    };
    // PrintArray(B);

    double detA = A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0]; // определители матрицы
    double detX = A[0, 0] * B[1, 0] - B[0, 0] * A[1, 0];
    double detY = B[0, 0] * A[1, 1] - A[0, 1] * B[1, 0];

    double X = detX / detA;
    double Y = detY / detA;

    System.Console.WriteLine($"Точка пересечения прямых имеет координаты ({X};{Y})");
}



int CountPositiveNum(int[] arrr)
{
    int count = 0;
    for (int i = 0; i < arrr.Length; i++)
    {
        if (arrr[i] > 0) count++;
    }
    return count;
}

int GetNumFromUser(string str)
{
    System.Console.WriteLine($"Введите число {str}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}