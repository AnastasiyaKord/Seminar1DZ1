// Задача 2: Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Write("Введите первое число a: ");
string answerA = (Console.ReadLine()) ?? "";
int a = int.Parse(answerA);
int min;
int max;

Console.WriteLine("Введите второе число b: ");
string answerB = (Console.ReadLine()) ?? "";
int b = int.Parse(answerB);

if (a < b)
{
   min = a; max = b;
    Console.WriteLine($"a = {answerA}; b = {answerB} -> min = {min}; max = {max}");
}
else
{
    min = b; max = a;
}

