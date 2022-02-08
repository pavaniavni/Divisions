using System;
public class InfiniteDivisions
{
    public static void Main(string[] args)
    {
        int n1, n2;
        do
        {
            Console.WriteLine("Enter the First Number : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 != 0)
            {
                Console.WriteLine("Enter the Second Number : ");
                n2 = Convert.ToInt32(Console.ReadLine());
                if (n2 == 0)
                {
                    Console.WriteLine("You cannot divide by 0");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The Division is {0}", n1 / n2);
                    Console.WriteLine("The Rest is {0}", n1 % n2);
                    Console.WriteLine();
                }
            }
        }while (n1 != 0);
        Console.WriteLine("0 is not possible!");
    }
}