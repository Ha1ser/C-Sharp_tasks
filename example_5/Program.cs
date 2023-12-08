int i = int.Parse(Console.ReadLine()!);

int a_3 = i % 10; // третья цифра
int a_2 = i % 100 / 10; // вторая цифра

Console.Write(Math.Pow(a_2, a_3));
