/*Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите число М: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

void Sum ( int M, int N, int sum)
{
    if (M > N)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (M++);
    Sum (M, N, sum);
}
Sum (M, N, 0);