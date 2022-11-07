// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// d = √ ((х А – х В)^2 + (у А – у В)^2 + (z A - z B)^2)

System.Console.WriteLine("Введите по пордяку 6 чисел - координаты x,y,z точки A и координаты x,y,z точки B");

double X1 = Convert.ToDouble(Console.ReadLine());
double Y1 = Convert.ToDouble(Console.ReadLine());
double Z1 = Convert.ToDouble(Console.ReadLine());

double X2 = Convert.ToDouble(Console.ReadLine());
double Y2 = Convert.ToDouble(Console.ReadLine());
double Z2 = Convert.ToDouble(Console.ReadLine());

double TwoPointsDistance3D(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    double distance = Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2) + Math.Pow((Z1 - Z2),2));
    return distance;
}

double result = TwoPointsDistance3D(X1, Y1, Z1, X2, Y2, Z2);
System.Console.WriteLine($"Расстояние между точками равно {result}");