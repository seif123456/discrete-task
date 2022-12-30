using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum, lastNum, i, j, flag;
            Console.WriteLine("enter the first number");
             firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("end the last number");
            lastNum= int.Parse(Console.ReadLine());
            Console.WriteLine("\n the prime numbers between {0} and {1}",firstNum,lastNum);
            for (i = firstNum; i <= lastNum; i++)
            {
                if (i == 0 || i == 1)
                    continue;
                flag = 0;
                for (j = 2; j<=i/2;j++)
                {
                    if(i%j==0)
                    {
                        flag = 1;
                        break;
                    }

                }
                if (flag == 0)
                    Console.Write("{0}  ", i);

            } 
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}
