// первый - мой вариант 
// int[] ArrNums(int size, int from, int to){
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++){
//         arr[i] = new Random().Next(from, to + 1);
//     }
//     return arr;
// }

// void print(int[] arr){
//     int size = arr.Length;
//     for (int i = 0; i < size; i++){
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// int Num(int[] arr){
//     int n = 0;
//     for(int i = 0; i < arr.Length; i++){
//         if(arr[i] % 10 == 1 && arr[i] % 7 == 0){
//             n++;
//         }
//     }
//     return n;
// }


// Console.WriteLine("Введите размер массива: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Минемальное значение случайного числа: ");
// int start = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Максимальное значение случайного числа: ");
// int stop = int.Parse(Console.ReadLine()!);
// int[] mass = ArrNums(num, start, stop);

// Console.WriteLine("транслируем массив: ");
// print(mass);

// Console.WriteLine(Num(mass));


// второй вариант:

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

int countNum(int[] arr){
    int count = 0;

    foreach(int number in arr){
        if(number % 10 == 1 && number % 7 == 0){
            count += 1;
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

Console.WriteLine(countNum(mass));

