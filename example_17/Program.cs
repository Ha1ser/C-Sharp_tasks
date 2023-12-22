﻿int[,] MassNums(int row, int col, int from, int to){

    int[,] arr = new int[row, col];

    for(int i = 0; i < row; i++){
        for(int j = 0; j < col; j++){
            arr[i, j] = new Random().Next(from, to + 1);
        }
    }    
    return arr;
}
void Print(int[,] arr){
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);

    for(int i = 0; i < row; i++){
        for(int j = 0; j < col; j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
        
    }
    Console.WriteLine();
}

void ou(int[,] arr){
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    double q;
    for(int i = 0; i < row; i++){

        q = 0;  // индекс строк не считается 
        for(int j = 0; j < col; j++)
            q += arr[i, j];
        Console.WriteLine($"{Math.Round(q / col, 2)}; ");
    }        
}

Console.Write("Введите кол-во строк: ");     // размер двухмерного массива
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col_num = int.Parse(Console.ReadLine()!);

Console.Write("Введите минемальное значение случайного числа: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, col_num, start, stop);

Print(mass);

ou(mass);