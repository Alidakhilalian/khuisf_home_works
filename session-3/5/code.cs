int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(calc(x));

double calc(int x)
{
    double temp = Math.Sqrt(x);
    return temp;
}