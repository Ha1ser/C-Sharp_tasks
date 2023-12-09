/*Напишите программу, которая выводит третью с конца
цифру заданного числа или сообщает, что третьей цифры
нет. */

void ThirdNum(int num){
    if (num < 100) {
        Console.WriteLine("третьей цифры нет"); 
        return;
    }
    //while (num > 999)
      //  num /= 10;
    Console.WriteLine(num % 10);
    //return;
    }


int a = int.Parse(Console.ReadLine()!);
ThirdNum(a);
