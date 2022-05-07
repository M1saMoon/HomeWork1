//Удалить вторую цифру трёхзначного числа

Console.Write("Введите 3х значное число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99 && n < 1000)
{
    //654 = a b c = a * 100 + b * 10 + c 
    //64 = a c = a * 10 + c

Console.WriteLine((n / 100) * 10 + n % 10);
}
else Console.WriteLine("Введено не 3х значное число!");