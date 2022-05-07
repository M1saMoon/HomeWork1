//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

//Console.Write("Введите двухзначное число: ");
//int n = int.Parse(Console.ReadLine());

int n = new Random().Next(10,100);
Console.WriteLine(n);
if (n > 9 && n < 100)
{
    int a = n / 10;
    int b = n % 10;
    if (a > b) Console.WriteLine($"Наибольшая цифра {a}");
    else Console.WriteLine("В числе "+ n + " Наибольшая цифра: " + b);
}
else Console.WriteLine("Ввели не правильное число");