//    Показать натуральные числа от 1 до N, N задано
/*
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
string NumbersRec(int a, int N)
{
    if (a <= N) return $"{a} " + NumbersRec(a + 1, N);
    else return String.Empty;
}
Console.WriteLine(NumbersRec(1, N));
*/

//    Показать натуральные числа от N до 1, N задано
/*
void PrintNumber(int n)
{
    if (n < 1) return;
    Console.Write(n + " ");
    PrintNumber(n - 1);
}
PrintNumber(19);
*/

//    Показать натуральные числа от M до N, N и M заданы
/*
void PrintNumber(int m, int n)
{
    if (n < m) return;
    PrintNumber(m, n - 1);
    Console.Write(n + " ");
}
PrintNumber(3, 22);
*/

//    Найти сумму элементов от M до N, N и M заданы
/*
int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
}
Console.WriteLine(Sum(10, 20));
*/

//    Найти сумму цифр числа
/*
int SumDigits(int number)
{
    if (number < 1) return 0;
    int result = 0;
    return SumDigits(number / 10) + number % 10;
}
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Sum digits: {SumDigits(number)}");
*/

//    Написать программу вычисления функции Аккермана
/*
int Ack(int m, int n)
{
    if (m > 6 || n > 6 || m < 0 || n < 0) return -1;

    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ack(m - 1, 1);
    }
    else
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
}
Console.WriteLine(Ack(1, 1));
*/

//    Написать программу возведения числа А в целую стень B
/*
int DegreeOfNum(int numA, int numB)
{
    if (numB < 1) return 1;
    return numA * (DegreeOfNum(numA, numB - 1));
}

Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine());

Console.WriteLine($"Число {numA} в степени {numB} равно: {DegreeOfNum(numA, numB)}");
*/

//    Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
//    Первые два элемента последовательности задаются пользователем.

int N = 10;
int a = 5;
int b = 8;
int Metod(int x, int y, int num)
{
    if (num == 1) return x;
    if (num == 2) return y;
    return Metod(x, y, num - 1) + Metod(x, y, num - 2);
}
for (int i = 1; i < N; i++)
{
    Console.Write(Metod(a, b, i) + " ");
}
