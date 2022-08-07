// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b =10 -> max =10
// // a = -9 b = -3 -> max = -3

int a1 = 5, b1 = 7, a2 = 2, b2 = 10, a3 = -9, b3 = -3;

System.Console.Write("Большее число в первой паре: ");

if (a1 > b1) 
{
    System.Console.WriteLine(a1);
}
else 
{
    System.Console.WriteLine(b1);
}

System.Console.Write("Большее число во второй паре: ");

if (a2 > b2) 
{
    System.Console.WriteLine(a2);
}
else 
{
    System.Console.WriteLine(b2);
}

System.Console.Write("Большее число в третьей паре: ");

if (a3 > b3) 
{
    System.Console.WriteLine(a3);
}
else 
{
    System.Console.WriteLine(b3);
}