// Задача 64: Задайте значение n. 
// Напишите программу, которая выведет все натуральные числа в промежутке от n до 1.
// n = 5 -> "5, 4, 3, 2, 1"
// n = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNumbersToN (int n)
{
if (n == 0) return;
Console.Write(n + " ");
PrintNumbersToN (n - 1);
}

PrintNumbersToN(n);