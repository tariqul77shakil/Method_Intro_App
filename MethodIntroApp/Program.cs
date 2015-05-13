using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = Console.ReadLine();
            //string address = Console.ReadLine();
            //Console.WriteLine(GetData(name,address));

            
            
            Console.WriteLine("Enter first number.");
            int fstn = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            int sstn = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\n\n*******  Calculator  **********\n\n");
            double resultadd = Addition(fstn, sstn);
            Console.WriteLine("{0} + {1} = {2}",fstn,sstn,resultadd);
            
            
            double resultsub = Substraction(fstn, sstn);
            Console.WriteLine("{0} - {1} = {2}", fstn, sstn, resultsub);

            double resultmul = Multiplication(fstn, sstn);
            Console.WriteLine("{0} * {1} = {2}", fstn, sstn, resultmul);

            double resultdiv = Divition(fstn, sstn);
            Console.WriteLine("{0} / {1} = {2}", fstn, sstn, resultdiv);

                
            
            Console.ReadKey();
        }

        static string GetData(string name, string address)
        {
            return "Hi "+name+", How are you? You live in "+address;
        }

        static double Addition(int firstNum, int lastNum)
        {
            return firstNum + lastNum;
        }
        static double Substraction(int firstNum, int lastNum)
        {
            return firstNum - lastNum;
        }

        static double Multiplication(int firstNum, int lastNum)
        {
            return firstNum * lastNum;
        }

        static double Divition(int firstNum, int lastNum)
        {
            double f = firstNum;
            double l = lastNum;
            return f/l;
        }
    }
}
