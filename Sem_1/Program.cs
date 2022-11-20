/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.WriteLine("input numberA");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input numberB");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
    Console.WriteLine(numA);

else

    Console.WriteLine(numB);*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.WriteLine("input number");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int numC = Convert.ToInt32(Console.ReadLine());
int max = numA;

if (numB > numA) max = numB;
if (numC > numB) max = numC;

Console.WriteLine(max);*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Console.WriteLine("input number");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("число является чётным");
}
else

Console.WriteLine("число является не чётным");

Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

Console.WriteLine("Введите значение ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
int K = 1;



while (true)
{
    if (i % 2 == 0)

        Console.Write(i + " ");
    K++;

    if (K > N)

        break;


    i++

}*/










