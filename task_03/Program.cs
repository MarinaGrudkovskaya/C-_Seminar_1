// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.Write("Введите число от 1 до 7: ");
int namber = int.Parse(Console.ReadLine());

if (namber == 1)
{
    Console.WriteLine("1 -> Понедельник");
}
if (namber == 2)
{
    Console.WriteLine("2 -> Вторник");
}
if (namber == 3)
{
    Console.WriteLine("3 -> Среда");
}
if (namber == 4)
{
    Console.WriteLine("4 -> Четверг");
}
if (namber == 5)
{
    Console.WriteLine("5 -> Пятница");
}
if (namber == 6)
{
    Console.WriteLine("6 -> Суббота");
}
if (namber == 7)
{
    Console.WriteLine("7 -> Воскресенье");
}