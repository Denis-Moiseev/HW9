int GetSumNums(int num, int num2)
{
    if (num == num2) return num;
    return num2 + GetSumNums(num, num2 - 1);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInput("Введите число: ");
int num2 = GetInput("Введите число: ");
Console.Write($"M = {num}; N = {num2} -> ");
Console.Write(GetSumNums(num, num2));