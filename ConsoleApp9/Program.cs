//Вариант 20
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());
int[,] mas = new int[n, m];
Random r = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        mas[i, j] = r.Next(0, 2);
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}
int b = 0;
for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < m - 1; j++)
    {
        
        if (mas[i, j] == mas[i + 1, j] && mas[i, j] == mas[i, j + 1] && mas[i, j] == mas[i + 1, j + 1])
            do
            {
                Console.WriteLine("Таблица не является симпатичной");
                b++;
                break;
            } while(b < 1);
        if (b == 1) break;
    }
    if (b == 1) break;
}
if (b == 0) Console.WriteLine("Таблица является симпатичной");