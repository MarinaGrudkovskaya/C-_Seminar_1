// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число: ");
int namber = int.Parse(Console.ReadLine());

int nam = -namber;
int count = - namber;
while (count < namber+1 )
{
    Console.Write(nam +" ");
    count++;
    nam++;
}

