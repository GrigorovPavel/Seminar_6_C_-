//  Задача 45: 
// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CreateArrayRndInt(int size, int min, int max) // Создаем Метод для Массива с переменными size, max, min 
{
    int[] arr = new int[size]; 
    Random rnd = new Random(); 

    for (int i = 0; i < size; i++) 
    {
        arr[i] = rnd.Next(min, max + 1); 
    }
    return arr; 
}

void PriintArray(int[] arr)
{
    Console.Write("["); 
    for (int i = 0; i < arr.Length; i++) 
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, "); 
        else Console.Write($"{arr[i]}"); 
    }
    Console.WriteLine("]");
}

int[] CopyArray(int[] arr)
{
    int[] newArr = new int[arr.Length]; // Размер КОПИРУЕМОГО Массива как у ИСХОДНОГО
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

int[] array = CreateArrayRndInt(5, 1, 9); 
PriintArray(array);
int[] res = CopyArray(array);
PriintArray(res);
//PriintArray(CopyArray(array));
