// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a1 = 2, b1 = 3, c1 = 7,
    a2 = 44, b2 = 5, c2 = 78,
    a3 = 22, b3 = 3, c3 = 9;

System.Console.Write("Большее из первой группы чисел: ");

if (a1>b1)
{
    if (a1>c1)
    {
        System.Console.WriteLine(a1);
    }
    else 
    {
        System.Console.WriteLine(c1);
    }
}
else 
{
    if (b1>c1)
    {
        System.Console.WriteLine(b1);
    }
    else 
    {
        System.Console.WriteLine(c1);
    }
}

System.Console.Write("Большее из второй группы чисел: ");

if (a2>b2)
{
    if (a2>c2)
    {
        System.Console.WriteLine(a2);
    }
    else 
    {
        System.Console.WriteLine(c2);
    }
}
else 
{
    if (b2>c2)
    {
        System.Console.WriteLine(b2);
    }
    else 
    {
        System.Console.WriteLine(c2);
    }
}

System.Console.Write("Большее из третьей группы чисел: ");

if (a3>b3)
{
    if (a3>c3)
    {
        System.Console.WriteLine(a3);
    }
    else 
    {
        System.Console.WriteLine(c3);
    }
}
else 
{
    if (b3>c3)
    {
        System.Console.WriteLine(b3);
    }
    else 
    {
        System.Console.WriteLine(c3);
    }
}