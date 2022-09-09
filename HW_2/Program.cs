// Задайте значения M и N. Напишите программу, которая найдёт 
//  сумму натуральных элементов в промежутке от M до N (используйте рекурсию).

Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Cумму натуральных элементов в промежутке от M до N: ");
int sum = 0;
if (m <= 0 & n <= 0) Console.Write("Нет натуральных чисел");
else if (0 < m && m < n) VivodDannih(m, n, sum);
else if (0 < m && m == n) Console.Write(m + n);
else if (0 > m) VivodDannih(1, n, sum);
Console.WriteLine();


void VivodDannih(int m, int n, int sum)
{
    if (m == n)
    {
        sum += m;
        Console.Write(sum);
    }
    else
    {
        sum += m;
        m++;
        VivodDannih(m, n, sum);
    }
}
