using System;


class MatrixMultiply 
{
    static void Main()
    {
        int[,] a = new int[2, 2];
        Input(a);

        int[,] b = new int[2, 2];
        Input2(b);

        int[,] result = Multiply(a, b);

        Output(result);
    }
    static void Input(int[,] dst)
    {
        int[,] a = new int[2, 2];
        for (int r = 0; r < a.GetLength(0); r++)
        {
            for (int c = 0; c < a.GetLength(1); c++)
            {
                Console.Write("Enter value for [{0},{1}] : ", r, c);
                dst[r, c] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();
    }
    static void Input2(int[,] dst) 
    {
        int[,] b = new int[2, 2];
        for (int r = 0; r < b.GetLength(0); r++)
        {
            for (int c = 0; c < b.GetLength(1); c++)
            {
                Console.Write("Enter value for [{0},{1}] : ", r, c);
                dst[r, c] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();
    }
    static int[,] Multiply(int[,] a, int[,] b)
    {
        int[,] result = new int[2, 2];

        for (int r = 0; r < result.GetLength(0); r++)
        {
            for (int c = 0; c < result.GetLength(1); c++)
            {
                result[r, c] += a[r, 0] * b[0, c] + a[r, 1] * b[1, c];
            }
        }
        return result;
    }
    static void Output(int[,] result)
    {
        for (int r = 0; r < result.GetLength(0); r++)
        {
            for (int c = 0; c < result.GetLength(1); c++)
            {
                Console.Write("{0} ", result[r, c]);
            }
            Console.WriteLine();
        }
    }
}    
