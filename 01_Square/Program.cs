//По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите число:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a == b * b)
{
    Console.WriteLine("Да, число a = b^2 :");
}
else {
    Console.WriteLine("Нет, число a != b^2 :");
}