// Задача 42: 
// Напишите программу, которая 
// будет преобразовывать десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

int ConvertDecemalToBinary(int num)
{
    int res = 0;
    int mult = 1; // Добавляем множитель для увеличения результата каждой ИТЕРАЦИИ
    while (num > 0)
    {
        res = res + num % 2 * mult; 
        num = num / 2;
        mult = mult * 10;
    }
    return res;

}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = ConvertDecemalToBinary(number);
Console.WriteLine(result);