// Задача 4: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите Первое число: ");
string answerA = (Console.ReadLine()) ?? "";
int a = int.Parse(answerA);
int max;

Console.Write("Введите Второе число: ");
string answerB = (Console.ReadLine()) ?? "";
int b = int.Parse(answerB);

Console.Write("Введите Третье число: ");
string answerC = (Console.ReadLine()) ?? "";
int c = int.Parse(answerC);

if (a > b)
{
    max = a;
}
else if (b > c)
{
    max = b;
}
else
    max = c;

Console.WriteLine($"{answerA}, {answerB}, {answerC} -> {max}");