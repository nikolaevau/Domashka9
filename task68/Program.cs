// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());


int SumCountFromMToN (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return SumCountFromMToN(m - 1, 1);
    if (m > 0 && n > 0) return SumCountFromMToN(m - 1, SumCountFromMToN(m, n - 1));
return SumCountFromMToN(m, n);
}

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {SumCountFromMToN(m, n)}");