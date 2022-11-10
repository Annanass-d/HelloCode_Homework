// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArray(int size, int begin, int last)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(begin, last+1);
    }
    return array;
}

int CountEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0){
            count++;
        }
    }
    return count;
}


int[] arr = GetRandomArray(6,100,1000);
System.Console.WriteLine(String.Join(", ",arr));

int result = CountEvenNum(arr);
System.Console.WriteLine($"Четных чисел в массиве: {result}");

