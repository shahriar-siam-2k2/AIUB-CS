using System;

namespace oop2_o_ {
    internal class midTask01 {
        static void Main(string[] args) {
            Console.WriteLine("Enter the the first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the desired operator:");
            char c = Convert.ToChar(Console.ReadLine());

            if (c == '+') {
                Console.WriteLine("Result = " + (a + b));
            }
            else if (c == '-') {
                Console.WriteLine("Result = " + (a - b));
            }
            else if (c == '*') {
                Console.WriteLine("Result = " + (a * b));
            }
            else if (c == '/') {
                if (b == 0) {
                    Console.WriteLine("Second number cannot be 0");
                }
                else {
                    Console.WriteLine("Result = " + (a / b));
                }
            }
            else {
                Console.WriteLine("Not an operator");
            }
        }
    }
}