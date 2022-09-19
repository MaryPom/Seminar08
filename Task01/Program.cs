// Задача 1. Найти произведение двух матриц
Console.WriteLine("Введите размер первой матрицы: ");
int[,] a = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write("a[{0},{1}] = ", i, j);
        a[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("Введите размер второй матрицы: ");
int[,] b = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for (int i = 0; i < b.GetLength(0); i++)
{
    for (int j = 0; j < b.GetLength(1); j++)
    {
        Console.Write("b[{0},{1}] = ", i, j);
        b[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}
static int[,] Multiplication(int[,] a, int[,] b)
{
    if(a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i,j] += a[i,k]*b[k,j];
            }
        }
    }
    return r;
}
static void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0} ", a[i,j]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("\nМатрица a: ");
Print(a);
Console.WriteLine("\nМатрица b: ");
Print(b);
Console.WriteLine("\nМатрица c = a * b: ");
int[,] c = Multiplication(a,b);
Print(c);
