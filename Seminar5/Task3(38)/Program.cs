// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetRandomDoubleArray(int size, int begin, int last)
{
    double[] array = new double[size];
    var random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(begin,last+1) + random.NextDouble();
    }
    return array;
}

double DifMinMaxArray(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    double dif = max - min;
    return dif;
}

double[] arr = GetRandomDoubleArray(6,1,100);
System.Console.WriteLine(String.Join("  ",arr));

double result = DifMinMaxArray(arr);
System.Console.WriteLine($"Разница между макс. и мин. элементами массива = {result}");