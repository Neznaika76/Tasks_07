// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// заполние двумерного массива
void FillingTheArray(int[,] Array)
    {
        Random random = new Random();
        for(int i=0; i<Array.GetLength(0); i++)
            for(int j=0; j<Array.GetLength(1); j++)
                Array[i,j]=random.Next(0,10);
        return;
    }

// Вывод массива
void OutputTheArray(int[,] Array)
    {
        for(int i=0; i<Array.GetLength(0); i++)
            {
                for(int j=0; j<Array.GetLength(1); j++)
                    Console.Write(" {0} ",string.Join(",",Array[i,j]));
                Console.WriteLine("");
            }
        return;
    }

// Выводим значение суммы строки
void OutputTheSummStroki(int[,] Array)
    {
        int Summ = 0;
        for(int i=0; i<Array.GetLength(0); i++)
            {
                for(int j=0; j<Array.GetLength(1); j++)
                    Summ = Summ + Array[i,j];
                Console.Write($"Сумма в {i+1} строке = {Summ}     ");
                Summ = Summ / Array.GetLength(1);
                Console.WriteLine($"Среднее арифметическое в {i+1} строке = {Summ}");
                Summ = 0;
            }
        return;
    }

void OutputTheSummStolbech(int[,] Array)
    {
        int Summ = 0;
        int j = 0;
        for(int i=0; i<Array.GetLength(1); i++)
            {
                for(j=0; j<Array.GetLength(0); j++)
                    Summ = Summ + Array[j,i];
                Console.Write($"Сумма в {i+1} столбце = {Summ}     ");
                Summ = Summ / Array.GetLength(0);
                Console.WriteLine($"Среднее арифметическое в {i+1} столбце = {Summ}");
                Summ = 0;
            }
        return;
    }    

// Программа
Console.WriteLine("Введите значение m - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n - ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
FillingTheArray(array);
OutputTheArray(array);
OutputTheSummStroki(array);
Console.WriteLine("_____________________________");
OutputTheSummStolbech(array);
