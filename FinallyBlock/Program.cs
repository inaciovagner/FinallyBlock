using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value of A : ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Enter value of B : ");
            int B = int.Parse(Console.ReadLine());
            try
            {
                int C = A / B;
                Console.WriteLine("C = {0} / {1} = {2}", A, B, C);
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("Can't divide a number by 0");
            }
            finally
            {
                Console.WriteLine("A = {0}\nB = {1}", A, B);
            }
        }
    }
}
