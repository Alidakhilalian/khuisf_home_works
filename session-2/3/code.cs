int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
double result = 0;
result = Math.Sqrt(Math.Pow(Math.Abs(x - y), Math.Abs(y)));
Console.WriteLine(result);