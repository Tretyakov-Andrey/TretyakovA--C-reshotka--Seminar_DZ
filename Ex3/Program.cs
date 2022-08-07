// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

double a1 = 4, a2 = -3, a3 = 7;
double x1 =  a1%2, x2 = a2%2, x3 = a3%2;


System.Console.WriteLine("Число 1 четное?");
System.Console.Write("Ответ: ");

if (x1 == 0)
{
    System.Console.WriteLine("Да");
}
else System.Console.WriteLine("Нет");

System.Console.WriteLine("Число 2 четное?");
System.Console.Write("Ответ: ");

if (x2 == 0)
{
    System.Console.WriteLine("Да");
}
else System.Console.WriteLine("Нет");

System.Console.WriteLine("Число 3 четное?");
System.Console.Write("Ответ: ");

if (x3 == 0)
{
    System.Console.WriteLine("Да");
}
else System.Console.WriteLine("Нет");


