/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Введите число больше 1: ");
int n = int.Parse(Console.ReadLine());
void Number(int n)
{
    if (n < 0) Console.Write($"{n} - число не натуральное");
    if (n == 0) return;
    Console.Write("{0,4}", n);
    Number(n - 1);
}
Number(n);