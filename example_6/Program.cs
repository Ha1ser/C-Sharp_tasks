Console.WriteLine("Введите 1 число");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2 число");
int n2 = int.Parse(Console.ReadLine()!);

if (n % n2 == 0) {Console.WriteLine("Кратно");}
else {Console.WriteLine(n % n2);}