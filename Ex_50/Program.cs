// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// заполние двумерного массива
void FillingTheArray(float[,] Array)
    {
        Random random = new Random();
        for(int i=0; i<Array.GetLength(0); i++)
            for(int j=0; j<Array.GetLength(1); j++)
                Array[i,j]=random.Next(0,10);
        return;
    }

// Вывод массива
void OutputTheArray(float[,] Array)
    {
        for(int i=0; i<Array.GetLength(0); i++)
            {
                for(int j=0; j<Array.GetLength(1); j++)
                    Console.Write("[{0}]",string.Join(",",Array[i,j]));
                Console.WriteLine("");
            }
        return;
    }

// Выводим значение элемента
void OutputTheElement(float[,] Array, int a, int b)
    {
        if(a>=0&&b>=0)
            if(a<=Array.GetLength(0)&&b<=Array.GetLength(1))
               {
               Console.Write("Значение элемента - ");
               Console.WriteLine(Array[a,b]);
               return;
               }
        Console.Write("Такого элемента нет!");
        return;
    }

// Программа
Console.WriteLine("Введите значение m - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n - ");
int n = Convert.ToInt32(Console.ReadLine());
float[,] array = new float[m,n];
FillingTheArray(array);
OutputTheArray(array);
Console.WriteLine("Введите позицию элемента - х:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y:");
int y = Convert.ToInt32(Console.ReadLine());
OutputTheElement(array,x,y);
