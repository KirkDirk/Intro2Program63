// Задача 63: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string PrintNumber(int i, int num)
{
    if (i < num) return ($"{i} " + PrintNumber(i + 1, num));
    else return Convert.ToString(num);
}

Console.Clear();
Console.WriteLine("Введите значение N (целое, положительное):");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа в промежутке от 1 до {number}:");
Console.WriteLine(PrintNumber(1, number));