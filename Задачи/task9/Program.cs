// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = num % 10;
int N = a1 * 10 + a2;
Console.WriteLine(num);
Console.WriteLine(a1);
Console.WriteLine(a2);
Console.WriteLine(N);