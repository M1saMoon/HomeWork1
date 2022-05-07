//Найти третью цифру числа или сообщить, что её нет

int num = new Random().Next();
//int num = 25;
Console.WriteLine(num);
if (num < 100) Console.WriteLine("У введенного числа нет 3 цифры!");
else {
    // 123 = 123 % 10
    // 1234 = 1234 / 10 % 10 
    // 12345 = 12345 / 10 
    while (num > 999)
    {
        num = num / 10;
    }
    int result = num % 10;
    Console.WriteLine("Третья цифра равна =" +result);
}