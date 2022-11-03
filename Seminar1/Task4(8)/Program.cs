// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if(num>1){
    for(int i=1;i<=num;i++){
        if(i%2 == 0){
            Console.Write(i + "  ");
        }
}
}
else if(num<-1){
    for(int i=-1;i>=num;i--){
        if(i%2 == 0){
            Console.Write(i + "  ");
        }
}
}
else {
    Console.WriteLine("Введено число в промежутке от -1 до 1");
}
