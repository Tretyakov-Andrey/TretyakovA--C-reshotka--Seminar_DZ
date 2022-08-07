//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int n = new Random().Next(10,20);

System.Console.Write("Выбранное число: ");
System.Console.WriteLine(n);

if (n%2 != 0) {n=n-1;} //если число будет не четным изначально, я хочу, чтобы оно было четным

while (n>0)
{
    System.Console.Write(n);
    System.Console.Write(" | ");
    n=n-2;
}


