int value = Convert.ToInt32(Console.ReadLine());
int benefit = Convert.ToInt32(Console.ReadLine());
int target = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(calc(value, benefit, target));

int calc(int value, int benefit, int target)
{
    float temp = value;
    int years = 0;

    while (true)
    {
        if (temp >= target)
        {
            break;
        }
        else
        {
            temp += (temp * benefit) / 100;
            years++;
        }
    }
    return years;
}