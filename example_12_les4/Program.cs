int[] ArrNums(int size, int from, int to){
    int[] arr = new int[size];

    for (int i = 0; i < size; i++){
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr;
}

void print(int[] arr){
    int size = arr.Length;
    for (int i = 0; i < size; i++){
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

bool isPrime(int number){
    if (number < 2){ return false;}
    for (int i = 2; i <= Math.Sqrt(number); i++){
        if (number % i == 0) return false;
    }
    return true;
}

int SimpleNum(int[] arr){
    int count = 0;

    foreach(int number in arr){
        if (isPrime(number)){
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите размер массива: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Минемальное значение случайного числа: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Максимальное значение случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);
int[] mass = ArrNums(num, start, stop);

Console.WriteLine("транслируем массив: ");
print(mass);

int res = SimpleNum(mass);
Console.WriteLine(res);

