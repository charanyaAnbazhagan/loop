using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoopExample
{
    [TestClass]
    public class ForLoop
    {
        [TestMethod]
        public void Test_For_Loop()
        {
            int inner;
            for( int outer = 0;outer < 3;outer++)
            {
                for(inner = 10;inner > 5; inner--)
                    Console.WriteLine($"Outer: {outer}\tInner: { inner}");

            }

        }
        [TestMethod]
        public void Strange_For_Loop()
        {
            for (int counter = 0, val1 = 10; counter < val1; counter++)
                {

            }
            int count2 = 0;
            for (;count2 < 100;count2 += 10)
            {

            }
            for(int j = 0; ; j++)
            {

            }

        }
    }
}
