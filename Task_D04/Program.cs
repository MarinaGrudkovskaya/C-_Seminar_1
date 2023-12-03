// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа через пробел - ");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int num3 = int.Parse(Console.ReadLine()!);
// Console.WriteLine(num1+num2+num3);
if (num1 > num2 && num1 >num3 )
{
    Console.WriteLine("max -> " + num1);
}
if (num2 > num1 && num2 >num3 )
{
    Console.WriteLine("max -> " + num2);
}
if (num3 > num2 && num3 >num1 )
{
    Console.WriteLine("max -> " + num3);
}