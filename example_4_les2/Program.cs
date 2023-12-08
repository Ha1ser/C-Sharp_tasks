/*Напишите программу, которая принимает на вход
трёхзначное число и удаляет вторую цифру этого
числа. */

//мое решение:
/*Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

int a_1 = n / 100; 
int a_2 = n % 10;

Console.Write(a_1);
Console.WriteLine(a_2);*/

//решение общ
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(n / 100 * 10 + n % 10);


