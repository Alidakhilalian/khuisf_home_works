using System;

namespace Test1
{
    class Program
    {
        public static void Main()
        {
            const int value = 10; //change value for increase or decrease matrix size
            int[,] num = new int[value, value];
            int[,] num2 = new int[value, value];

            for (int i = 0; i < value; i++)
            {
                for (int j = 0; j < value; j++)
                {
                    Console.Write("Enter " + (i+1).ToString() + "/" + (j+1).ToString() +": ");
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < value; i++)
            {
                for (int j = 0; j < value; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            num2[i, j] = num[i, j + 1] + num[i + 1, j];
                        }
                        else if (j == value - 1)
                        {
                            num2[i, j] = num[i, j - 1] + num[i + 1, j];
                        }
                        else
                        {
                            num2[i, j] = num[i, j - 1] + num[i, j + 1] + num[i + 1, j];
                        }
                    }
                    else if(i == value - 1)
                    {
                        if (j == 0)
                        {
                            num2[i, j] = num[i, j + 1] + num[i - 1, j];
                        }
                        else if (j == value - 1)
                        {
                            num2[i, j] = num[i, j - 1] + num[i - 1, j];
                        }
                        else
                        {
                            num2[i, j] = num[i, j - 1] + num[i, j + 1] + num[i - 1, j];
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            num2[i, j] = num[i, j + 1] + num[i - 1, j] + num[i + 1, j];
                        }
                        else if (j == value - 1)
                        {
                            num2[i, j] = num[i, j - 1] + num[i - 1, j] + num[i + 1, j];
                        }
                        else
                        {
                            num2[i, j] = num[i, j - 1] + num[i, j + 1] + num[i - 1, j] + num[i + 1, j];

                        }
                    }
                }
            }

            Console.Write("\n");

            Console.WriteLine("Base Matrix:");
            for (int i = 0; i < value; i++)
            {
                for (int j = 0; j < value; j++)
                {
                    Console.Write(num[i, j]);
                }
                Console.Write("\n");
            }

            Console.Write("\n");

            Console.WriteLine("Flags Matrix:");
            for (int i = 0; i < value; i++)
            {
                for (int j = 0; j < value; j++)
                {
                    Console.Write(num2[i, j]);
                }
                Console.Write("\n");
            }

        }
    }
}