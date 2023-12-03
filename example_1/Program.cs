
String aStr, bStr;
Console.Write("Введите число 1: ");
aStr = Console.ReadLine();
Console.Write("Введите число 2: ");
bStr = Console.ReadLine();

int a = int.Parse(aStr);
int b = int.Parse(bStr);

if (a == b * b) {
    Console.WriteLine("True");
}
else { Console.WriteLine("False");}






