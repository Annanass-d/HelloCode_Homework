// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray(int size, int begin, int last)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(begin, last + 1);
    }
    return array;
}

int SumUnevenPos(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            count += array[i];
        }
    }
    return count;
}


int[] arr = GetRandomArray(6, -100, 101);
System.Console.WriteLine(String.Join(", ", arr));

int result = SumUnevenPos(arr);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {result}");