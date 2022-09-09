// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
static uint VivodResult(uint m, uint n)
{
    if (m == 0)
    {
        uint res = 0;
        res = n + 1;
        //Console.Write("A(m,n) = " + res);
        return res;
    }
    else
    {
        if (m != 0 && n == 0)
        {
            return VivodResult(m - 1, 1);
        }
        else //if (m > 0 && n > 0)
        {
            return VivodResult(m - 1, VivodResult(m, n - 1));
        }
    }
}

Console.WriteLine("Введите значение M: ");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
uint n = Convert.ToUInt32(Console.ReadLine());
uint res = 0;

if (m >= 0 && n >= 0)
{
    res = VivodResult(m, n);
    Console.Write("A(m,n) = " + res);
}