// Задача 6: Напишите программу, которая на вход 
// принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите четное число: ");
string answerA = (Console.ReadLine()) ?? "";
int a = int.Parse(answerA);

if (0 == a % 2)
{
    Console.WriteLine($"{answerA} -> да");
}
else
    Console.WriteLine($"{answerA} -> нет");
