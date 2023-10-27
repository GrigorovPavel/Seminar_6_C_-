// Задача 40: 
// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите первую сторону:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону:");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону:");
int numC = Convert.ToInt32(Console.ReadLine());

bool IsExistTriangle(int a, int b, int c)
{
    // if (a < b + c && b < a + c && c < a + b) return true;
    // return false; или сразу
    return a < b + c && b < a + c && c < a + b;
}

bool isExistTriangle = IsExistTriangle(numA, numB, numC);
Console.WriteLine(isExistTriangle ? "Треугольник существует" : "Треугольник не существует");
// Вывод с помощю ТЕРНАРНОГО оператора 