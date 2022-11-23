while (true)
{
    Console.ReadLine();
    Console.Clear();

    System.Console.WriteLine("54) Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
    System.Console.WriteLine("56) Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
    System.Console.WriteLine("58) Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
    System.Console.WriteLine("60) Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
    System.Console.WriteLine("62) Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");
    System.Console.WriteLine("0) End");

    int task = SetNumber("номер задачи");

    switch (task)
    {
        case 0: return; break;
        case 54: Task54(); break;
        case 56: Task56(); break;
        case 58: Task58(); break;
        case 60: Task60(); break;
        case 62: Task62(); break;
        default: System.Console.WriteLine("error"); break;
    }

}


// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Task54()
{
    int rows = SetNumber("строк");
    int columns = SetNumber("столбцов");
    int[,] matr = GetRandomMatrix(rows, columns);
    PrintMatrix(matr);
    System.Console.WriteLine();
    PrintMatrix(SortRows(matr));
}

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Task56()
{
    int rows = SetNumber("строк");
    int columns = SetNumber("столбцов");
    int[,] matr = GetRandomMatrix(rows, columns);
    PrintMatrix(matr);
    System.Console.WriteLine();
    System.Console.WriteLine("Сумма строк:");
    int[,] sumR = SumRow(matr);
    PrintMatrix(sumR);
    MaxSum(sumR);

}

// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

void Task58()
{
    int[,] matr1 = GetRandomMatrix(2, 2);
    PrintMatrix(matr1);
    System.Console.WriteLine();
    int[,] matr2 = GetRandomMatrix(2, 2);
    PrintMatrix(matr2);
    // int[,] matr1 = new int[,]
    // {
    //                 {2,4},
    //                 {3,2},
    // };
    // PrintMatrix(matr1);
    // System.Console.WriteLine();
    // int[,] matr2 =
    // {
    //                 {3,4},
    //                 {3,3},
    // };
    // PrintMatrix(matr2);
    System.Console.WriteLine();
    PrintMatrix(MatrixProduct(matr1, matr2));
}


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void Task60()
{
    int[,,] array3d = GetRandomCube(2, 2, 2);
    PrintCube(array3d);
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

void Task62()
{
    PrintMatrix(SpireMatrix(4));
}


int[,] SpireMatrix(int n)
{
    int[,] matr = new int[n, n];
    int row = matr.GetLength(0);
    int col = matr.GetLength(1);
    int r = 0;
    int c = 0;
    int value = 1;
    matr[0, 0] = value;
    value++;
    int temp = 0;
    while (value <= n * n)
    {
        for (int i = c + 1; i < col && matr[r, i] == 0; i++)
        {
            matr[r, i] = value;
            value++;
            temp = i;
        }
        c = temp;
        for (int i = r + 1; i < row && matr[i, c] == 0; i++)
        {
            matr[i, c] = value;
            value++;
            temp = i;
        }
        r = temp;
        for (int i = c - 1; i > -1 && matr[r, i] == 0; i--)
        {
            matr[r, i] = value;
            value++;
            temp = i;
        }
        c = temp;
        for (int i = r - 1; i > 0 && matr[i, c] == 0; i--)
        {
            matr[i, c] = value;
            value++;
            temp = i;
        }
        r = temp;
    }
    return matr;
}

int[,,] GetRandomCube(int rows, int columns, int planes, int begin = 10, int last = 99)
{
    int[,,] cube = new int[rows, columns, planes];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < planes; k++)
            {
                cube[i, j, k] = GetUniqueValue(cube, begin, last, i, j, k);
            }
        }
    }
    return cube;
}

int GetUniqueValue(int[,,] matrix, int min, int max, int i, int j, int k)
{
    var rnd = new Random();
    int value = default;
    bool exist = true;
    while (exist)
    {
        bool _break = false;
        value = rnd.Next(min, max + 1);
        for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
        {
            if (_break) { break; }
            for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
            {
                if (_break) { break; }
                for (int k1 = 0; k1 < matrix.GetLength(2); k1++)
                {
                    if (matrix[i1, j1, k1] == value) { _break = true; break; }
                    if (i1 == i && j1 == j && k1 == k) { exist = false; }
                }
            }
        }
    }
    return value;
}

void PrintCube(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            System.Console.Write("| ");
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                System.Console.Write($"{cube[i, j, k]}({i},{j},{k}) | ");
            }
            System.Console.WriteLine();
        }
    }
}

int[,] MatrixProduct(int[,] matrixA, int[,] matrixB)
{
    int rowA = matrixA.GetLength(0);
    int colA = matrixA.GetLength(1);
    int rowB = matrixB.GetLength(0);
    int colB = matrixB.GetLength(1);

    if (colA != rowB) throw new Exception("Матрицы нельзя перемножить");

    int[,] matrixC = new int[rowA, colB];
    for (int i = 0; i < rowA; i++)
    {
        for (int j = 0; j < colB; j++)
        {
            for (int k = 0; k < rowB; k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

int[,] SumRow(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] sumRows = new int[rows, 1];
    int count = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            count += matrix[i, j];
        }
        sumRows[i, 0] = count;
        count = 0;
    }
    return sumRows;
}

void MaxSum(int[,] matrix)
{
    int min = matrix[0, 0];
    int indexMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (matrix[i, 0] < min)
        {
            min = matrix[i, 0];
            indexMin = i;
        }
    }
    System.Console.WriteLine($"Строка с индексом {indexMin} имеет наименьшеую сумму, равную {min}");
}

int[,] SortRows(int[,] matrix)
{
    int[,] arrangeMatrix = matrix;
    int rows = arrangeMatrix.GetLength(0);
    int columns = arrangeMatrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = j + 1; k < columns; k++)
            {
                if (matrix[i, j] > matrix[i, k])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
    return arrangeMatrix;
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
