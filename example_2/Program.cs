/*Задание 3*. Работа в сессионных залах
Семинар 1. Знакомство с языками программирования
Напишите программу, которая принимает на вход
трёхзначное целое число и на выходе показывает сумму
первой и последней цифры этого числа.
*/

Console.Write("Введите трехзначное число: ");
String aStr = Console.ReadLine();
int a = int.Parse(aStr);


int resalt1 = (a / 100); //первая цыфра есть
int resalt2 = (a % 10);
int osnResalt = resalt1 + resalt2;

Console.WriteLine("sum первой и третьей цыфры = " + osnResalt);



/* int n = int.Parse(Console.ReadLine()!);  // код в две строки
Console.WriteLine(n / 100 + n % 10);  */
