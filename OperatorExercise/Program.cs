using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Create 2 integer variables
            int a = 17;
            int b = 4;

            //2 more integer variables for the Quotient and the Remainder
            int quotient = a / b;
            int remainder = a % b;

            // This is the addition
            static int Add(int a, int b)
            {
                return a + b;
            }

            // This is the Multiplication
            static int Multi(int a, int b)
            {
                return a * b;
            }

            // This is the Substraction
            static int Substract(int a, int b)
            {
                return a - b;
            }


            //Use an if statement
            //17/4 is 4 remainder 1
            static int Quoandremain(int a, int b)
            {
                if (a == 17 && b == 4)
                {
                    return a / b;
                    return a % b;
                }
                else
                {
                    return a;
                }
            }
            // Output of Exercize#1
            Console.WriteLine(" ");
            Console.WriteLine("This is The output of the Exercise");
           
            Console.WriteLine("Addition");
            Console.WriteLine(a + b);
            Console.WriteLine("Substraction");
            Console.WriteLine(a - b);
            Console.WriteLine("Multiplication");
            Console.WriteLine(a * b);
            Console.WriteLine("Quotien Result");
            Console.WriteLine(a / b);
            Console.WriteLine("Modulus Result");
            Console.WriteLine(a % b);

            Console.WriteLine("This one was a confusing one for me");
            Console.WriteLine("I was trying to use the methods and then i gave up ans also I have 5 warnings and can't figure out why");
             }
    }
     
}
 
    
