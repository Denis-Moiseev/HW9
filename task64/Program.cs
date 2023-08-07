int ShowIntegers(int n)
{
    if (n == 1) return 1;
    Console.Write($"{n}, ");
    return ShowIntegers(n - 1);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInput("Введите число: ");
Console.Write($"N = {num} -> ");
Console.Write(ShowIntegers(num));