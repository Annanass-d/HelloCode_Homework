// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int SetNumber()
{
    System.Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = SetNumber();
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    System.Console.Write("[ ");
    while (position < count)
    {
        Console.Write(col[position] + "  ");
        position++;
    }
    System.Console.WriteLine("]");
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);