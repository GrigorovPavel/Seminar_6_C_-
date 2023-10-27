// Задача 44: 
// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

using System.Diagnostics.Contracts;

int[] ConvertToFibonachiArray(int num)
{
    int[] arr = new int[num];
    //arr[0] = 0; // Массив по умолчанию заполнен нулями
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

void PriintArray(int[] arr)
{
    //Console.Write("["); 
    for (int i = 0; i < arr.Length; i++) 
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, "); 
        else Console.Write($"{arr[i]}"); 
    }
    //Console.Write("]");
}




Console.WriteLine("Введите число больше 1:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 2)  // Проверка введенного числа (Условие)
{
    Console.WriteLine("Некорректный ввод.");
    return; // Выход из проверки, если число не соответствует условию. Выходим из метода Main в точку входа в Метод
}

int[] result = ConvertToFibonachiArray(number);
Console.Write($"{number} -> ");
PriintArray(result);
