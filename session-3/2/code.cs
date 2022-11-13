int age = Convert.ToInt32(Console.ReadLine());
int age_temp = age;
int years = 0;
int months = 0;
int weeks = 0;
int days = 0;
for(;years < age / 360; years++)
{
    age_temp -= 360;
}
age = age_temp;
for (; months < age / 30; months++)
{
    age_temp -= 30;
}
age = age_temp;
for (; weeks < age / 7; weeks++)
{
    age_temp -= 7;
}
age = age_temp;
for (; days < age; days++)
{
    age_temp -= 1;
}
Console.WriteLine("Years: {0}, Months: {1}, Weeks: {2}, Days: {3}", years, months, weeks, days);