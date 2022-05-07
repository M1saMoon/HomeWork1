//Показать четные числа от 1 до N

Console.Write("Введите диапазон n:");
int n = int.Parse(Console.ReadLine());
int count = 2;
Console.WriteLine($"Четные числа от 1 до {n}:");
while (count <= n)
{
    Console.Write(count + " ");
    count = count + 2;
}