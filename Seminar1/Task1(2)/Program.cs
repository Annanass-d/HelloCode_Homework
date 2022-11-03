// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2){
    Console.WriteLine("Первое число больше второго");
}
else if (num2>num1){
    Console.WriteLine("Второе число больше первого");
}
else {
    Console.WriteLine("Числа равны");
}