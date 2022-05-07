// Показать вторую цифру трёхзначного числа

Console.Write("Ввести трехзначное число:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(num /10 %10);