using System;


namespace Recursion
{
    class Program
    {
        // Recursion occurs when a method is called within itself


        static void Main(string[] args)
        {
            int answer4Factorial = 0;
            answer4Factorial = Factorial(3);
            Console.WriteLine("Answer is: " + answer4Factorial); // Factorial - 3 = 3 * 2 * 1


            float powerOfResult = 0;
            powerOfResult = Power(2, 3);
            Console.WriteLine("\n2 to the power of 3 is: " + powerOfResult); // Result of 2 to the power of 3

            Console.ReadKey();
        }
        private static int Factorial(int factorialNum)
        {
            // Exit condition here

            if (factorialNum == 1)
            {
                return 1;
            }
            return factorialNum * Factorial(factorialNum - 1);

            /*  Factorial(3) -> 3 * Factorial(2)
                                    Factorial(2) -> 2 * Factorial(1)
                                                        Factorial(1) -> 1               */
        }
        private static float Power(float num, int powerOf)
        {
            // Exit condition here
            if (powerOf == 1)
                return num;
            return num * Power(num, powerOf - 1);

            // Power(2,3) -> 2 * Power(2,2)
            //                   Power(2,2) -> 2 * Power(2,1)
            //                                     Power(2,1) -> 2 

        }
    }
}
// Retrieved from https://www.youtube.com/watch?v=E7MMHAgxT5Q&t=243s