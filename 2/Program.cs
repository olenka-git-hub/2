int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!? out N);

// int n = -N;

// while (n <=N)
// {
//     Console.Write($"{n} ");
//     n++;
// }
for (int n = -N; n<=N; n++)
{
    Console.Write($"{n} ");
}

