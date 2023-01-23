Console.Write("Введите число N: ");

int N = int.Parse(Console.ReadLine()!);

int a = 0;

while (a < N + 1)
{
    Console.Write(" " + a + " ");
    a = a + 2;
}
