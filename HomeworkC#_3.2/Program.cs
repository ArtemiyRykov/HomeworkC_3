//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int xA = Cordinate("x", "A");
int yA = Cordinate("y", "A");
int zA = Cordinate("z", "A");
int xB = Cordinate("x", "B");
int yB = Cordinate("y", "B");
int zB = Cordinate("z", "B");

double squareX = SquareNumber(xA,xB);
double squareY = SquareNumber(yA,yB);
double squareZ = SquareNumber(zA,zB);

double distance = Math.Sqrt(squareX + squareY + squareZ);
Console.WriteLine($"Расстояние между точками равно = {distance}");




int Cordinate(string coorName, string pointName)
{
    Console.WriteLine($"Введите координаты {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double SquareNumber(double number1, double number2)
{
    return Math.Pow((number1 - number2), 2);
}



