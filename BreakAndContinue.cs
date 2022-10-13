using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoopExample
{
    [TestClass]
    public class BreakAndContinue
    {
        [TestMethod]
        public void Break_Keyword()
        {
            int total = 0;
            for (int nValue = 0; nValue < 10; nValue++)
            {
                if(nValue == 5)
                {
                    break;
                }
                total += nValue;

            }
            Console.WriteLine(total);
            Assert.AreEqual(10,total);
        }
    }
}
