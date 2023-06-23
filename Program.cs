void Number1()
{
Console.WriteLine("Введите размер m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер n: ");
int colomns = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [rows,colomns];
for(int i = 0;i<matrix.GetLength(0);i++)
{
    for(int j=0;j<matrix.GetLength(1);j++)
    {
        matrix[i,j]=new Random().Next(1,10);
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine();
}

void Number2()
{
    Console.WriteLine("Введите размер m: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите размер n: ");
    int colomns = Convert.ToInt32(Console.ReadLine());
    int [,] matrix = new int [rows,colomns];
    for(int i = 0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
        {
            matrix[i,j]=new Random().Next(1,10);
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Введите m которое вас интересует: ");
    int i2=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите n которое вас интересует: ");
    int j2=Convert.ToInt32(Console.ReadLine());
    if((i2==matrix.GetLength(0)-1)&&(j2==matrix.GetLength(1)-1))
    {
        Console.WriteLine($"Тут стоит число : {matrix[i2,j2]}");
    }
    else
    {
        Console.WriteLine("Такой строки нет.");
    }
}
void Number3()
{
    Console.WriteLine("Введите размер m: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите размер n: ");
    int colomns = Convert.ToInt32(Console.ReadLine());
    int [,] matrix = new int [rows,colomns];
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
        {

            matrix[i,j]=new Random().Next(1,10);
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.Write("Среднее арифметическое каждого столбца: ");
    double sum=0;
    double sum2=0;
    for(int j=0;j<matrix.GetLength(1);j++)
    {
        for(int i=0;i<matrix.GetLength(0);i++)
        {
            sum=sum+matrix[i,j];
        }
        sum2=sum/matrix.GetLength(0)-1;
        if(j==matrix.GetLength(0))
        {
            Console.Write(sum+".");
        }
        else
        {
        Console.Write(sum2+"; " );
        }

    }
}
Number1();
Number2();
Number3();