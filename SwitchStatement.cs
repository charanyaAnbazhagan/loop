using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoopExample
{
    [TestClass]
    public class SwitchStatement
    {
        [TestMethod]
        public void Test_Switch_Statement()
        {
            int weekDay = 4;
            string testDay = "";
            switch (weekDay)
            {
                case 1:
                    testDay = "Monday";
                    break;
                case 2:
                    testDay = "Tuesday";
                    break;
                case 3:
                    testDay = "Wednesday";
                    break;
                case 4:
                    testDay = "Thursday";
                    break;
                case 5:
                    testDay = "Friday";
                    break;
                default:
                    testDay = "Not monday through Fridaty";
                    break;
            }
            StringAssert.Equals(testDay, "Thursday");


        }
    }
}