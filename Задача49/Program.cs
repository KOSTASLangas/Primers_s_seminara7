// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++) // цикл с 4 по 9 строки отвечает за заполнение массива
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        //array[i,j] = Convert.ToInt32(Console.ReadLine()); // ввод чисел для заполнения массива с клавиатуры
        array [i, j] = new Random().Next (2, 11);  // ввод чисел для заполнения рандомом
        if (i % 2 == 1 && j % 2 == 1)
        array [i, j] = array[i, j] * array[i, j]; 
    }
}

for (int i = 0; i < array.GetLength(0); i++) // цикл с 11 по 16 строки отвечает за вывод всего массива в виде таблицы
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}

