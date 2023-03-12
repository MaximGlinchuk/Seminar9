// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumber(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + "," + PrintNumber(start - 1, end));
}

Console.WriteLine(PrintNumber(N,1));