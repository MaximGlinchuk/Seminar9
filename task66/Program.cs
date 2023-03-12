// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int PrintNumber(int start, int end)
{
    if (start == end) return start;
    return (start + PrintNumber(start + 1, end));
}
Console.WriteLine("Сумма равна:");
Console.WriteLine(PrintNumber(M,N));