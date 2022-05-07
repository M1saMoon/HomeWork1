//По заданному номеру дня недели вывести его название

Console.WriteLine("Ввести день недели: ");
int daynumber = int.Parse(Console.ReadLine());
if (daynumber == 1)
{
    Console.WriteLine("День с номером 1 - Понедельник");
}
if (daynumber == 2)
{
    Console.WriteLine("День с номером 2 - Вторник");
}
if (daynumber == 3)
{
    Console.WriteLine("День с номером 3 - Среда");
}
if (daynumber == 4)
{
    Console.WriteLine("День с номером 4 - Четверг");
}
if (daynumber == 5)
{
    Console.WriteLine("День с номером 5 - Пятница");
}
if (daynumber == 6)
{
    Console.WriteLine("День с номером 6 - Суббота");
}
if (daynumber == 7)
{
    Console.WriteLine("День с номером 7 - Воскресенье");
}