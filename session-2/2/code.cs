int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int temp = 0;

if(num1 < num2 + num3)
{
    temp++;
}
if(num2 < num1 + num3)
{
    temp++;
} 
if(num3 < num1 + num2)
{
    temp++;
}

if(temp == 3)
{
    Console.WriteLine(num1+num2+num3);
} else
{
    Console.WriteLine("Not possible");
}