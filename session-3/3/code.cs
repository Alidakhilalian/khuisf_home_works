int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("B M M: " + bmm(num1, num2));
Console.WriteLine("K M M: " + kmm(num1, num2));

int bmm(int num1, int num2)
{
    int temp;
    while (true)
    {
        if (num2 == 0) break;

        temp = num1 % num2;
        num1 = num2;
        num2 = temp;
    }
    return num1;
}
int kmm(int num1, int num2)
{
    int num1_temp = num1, num2_temp = num2, kmm, temp;

    while (true)
    {
        if (num2 == 0) break;

        temp = num1 % num2;
        num1 = num2;
        num2 = temp;
    }

    kmm = (num1_temp * num2_temp) / num1;
    return kmm;
}