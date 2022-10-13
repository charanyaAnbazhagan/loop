using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoopExample
{
    [TestClass]
    public class WhileLoop
    {
        [TestMethod]
        public void Test_While_loop()
        {
            int number = 1;
            while (number < 11)
            {
                Console.WriteLine(number);
                number++;

            }
        }
        [TestMethod]
        public void Test_Operator()
        {
            int number = 1;
            Console.WriteLine("post Increment Number {0}", number++);
            Console.WriteLine("pre Increment Number {0}", ++number);
            Console.WriteLine("Post Decrement Number {0}", number--);
            Console.WriteLine("Pre Decrement Number {0}", --number);
        }

        [TestMethod]
        public void Test_Sentintal_Loop_Controller()
        {
            string Invalue = "";
            while (Invalue != "-99")
            {
                Console.Write("\nEnter value (_99 to exit):");
                Invalue = Console.ReadLine();

            }
            Console.ReadKey();


        }
        [TestMethod]
        public void Nested_Loop()
        {
            int number1 = 1;
            int number2 = 1;
            while (number1 <= 5)
            {
                while (number2 <= number1)
                {
                    Console.WriteLine(number2);
                    number2++;


                    //Console.WriteLine(number2);
                }
                number1++;
            }

        }
        [TestMethod]
        public void Nested_Loops()
        {
            int outer = 0;
            while(outer<3)
            {
                int inner = 10;
                while(inner<5)
                {
                    Console.WriteLine($"Outer: {outer}  \tInner: { inner}");
                    inner--;
                    
                }
                outer--;
            }

        }
    } }