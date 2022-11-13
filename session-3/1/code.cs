int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(calc(x));

double calc(int x)
{
    double result =  Math.Pow(x, 2);
    return result;
}