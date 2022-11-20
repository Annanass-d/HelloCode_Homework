while (true)
{
    Console.ReadLine();
    Console.Clear();

    System.Console.WriteLine("47) Задача 47. Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.");
    System.Console.WriteLine("50) Задача 50. Напишите программу, которая на вход принимает число и выводит индекс такого числа в двумерном массиве или говорит, что числа нет.");
    System.Console.WriteLine("52) Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
    System.Console.WriteLine("0) End");

    int task = SetNumber("номер задачи");

    switch (task)
    {
        case 0: return; break;
        case 47: Task47(); break;
        case 50: Task50(); break;
        case 52: Task52(); break;
        default: System.Console.WriteLine("error"); break;
    }

}


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

void Task47()
{
    int row = SetNumber("строк");
    int col = SetNumber("столбцов");
    double[,] matr = GetRandomMatrixDouble(row, col);
    PrintMatrixDouble(matr);
}

// Задача 50. Напишите программу, которая на вход принимает число и выводит индекс такого числа в двумерном массиве или говорит, что числа нет.

void Task50()
{
    int row = SetNumber("строк");
    int col = SetNumber("столбцов");
    System.Console.WriteLine();
    int[,] matr = GetRandomMatrix(row, col, 1, 20);
    PrintMatrix(matr);
    System.Console.WriteLine();
    int num = SetNumber("");
    if (IfElPosition(matr, num))
    {
        PrintElPosition(matr, num);
    }
    else System.Console.WriteLine($"Элемента {num} нет в массиве");
}



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void Task52()
{
    int row = SetNumber("строк");
    int col = SetNumber("столбцов");
    System.Console.WriteLine();
    int[,] matr = GetRandomMatrix(row, col);
    PrintMatrix(matr);
    System.Console.WriteLine();
    double[] result = AvgColumn(matr);
    System.Console.WriteLine($"Среднее арифметичское элементов каждого стоблца : {String.Join("; ", result)}");
}


int SetNumber(string str)
{
    System.Console.WriteLine($"Введите число {str}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] GetRandomMatrix(int rows, int columns, int begin = 1, int last = 10)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(begin, last + 1);
        }
    }
    return matrix;
}

double[,] GetRandomMatrixDouble(int rows, int columns, int begin = 1, int last = 10)
{
    double[,] matrix = new double[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(begin, last + 1) + random.NextDouble();
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(matrix[i, j], 2);
            System.Console.Write(matrix[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}

double[] AvgColumn(int[,] matrix)
{
    double[] avgArr = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            avgArr[j] += matrix[i, j];
        }
    }

    for (int j = 0; j < avgArr.Length; j++)
    {
        avgArr[j] /= matrix.GetLength(0);
        avgArr[j] = Math.Round(avgArr[j], 2);
    }
    return avgArr;
}

bool IfElPosition(int[,] matrix, int number)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                return true;
            }
        }
    }
    return false;
}

void PrintElPosition(int[,] matrix, int number)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                System.Console.WriteLine($"Строка {i}, столбец {j}");
                return; break;
            }
        }
    }
}