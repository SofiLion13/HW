// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int c = Convert.ToInt32(Console.ReadLine());

if (c<a & a>b)
{
    Console.Write(a);
}
if (c<b & b>a);
{
    Console.Write(b);
}
if (b<c & c>a);
{
    Console.Write(c);
}