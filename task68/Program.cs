int GetSumNums(int num, int num2)
{
    if (num == 0) return num2 + 1;
    if (num != 0 && num2 == 0) return GetSumNums(num - 1, 1);
    if (num > 0 && num2 > 0) return GetSumNums(num - 1, GetSumNums(num, num2 - 1));
    return GetSumNums(num, num2);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInput("Введите число: ");
int num2 = GetInput("Введите число: ");
Console.Write($"m = {num}, n = {num2} -> A(m,n) = ");
Console.Write(GetSumNums(num, num2));