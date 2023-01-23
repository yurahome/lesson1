// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine()!);

if (a < b)
{
    Console.WriteLine("Меньшее число " + a + " Большее число " + b);
}
else
{
    Console.WriteLine("Меньшее число " + b + " Большее число " + a);
}