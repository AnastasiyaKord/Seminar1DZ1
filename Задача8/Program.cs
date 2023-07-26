// Задача 8: Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите четное число: ");
string answerA = (Console.ReadLine()) ?? "";
int N = int.Parse(answerA);
int i = 2;

if (0 == N % 2)
{

    while (i <= N)
    {

        Console.Write(i + ", ");
        i = i + 2;
    }
}
else 
Console.WriteLine("Это нечетное число");


