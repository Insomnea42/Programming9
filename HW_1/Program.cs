// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1 (используйте рекурсию).

Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Все натуральные числа в промежутке от N до 1: ");
if (n<=0) Console.Write(1);
else VivodDannih(n);
Console.WriteLine();

void VivodDannih(int n)
{
    if (n == 1)
    {
        Console.Write(n + ", ");
    }
    else
    {
        Console.Write(n + ", ");
        n--;
        VivodDannih(n);
    }
}
