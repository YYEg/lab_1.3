using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void sortTest3Words()
        {
            
            string yourSentence = "n nn nnn";
            string[] checkArray = { "nnn", "nn", "n" };
            

            string [] outArray = Logic.Sort(yourSentence);
                
            Assert.AreEqual(checkArray[0], outArray[0]);
            Assert.AreEqual(checkArray[1], outArray[1]);
            Assert.AreEqual(checkArray[2], outArray[2]);


        }

        [TestMethod()]
        public void sortTest4Words()
        {

            string yourSentence = "n nnnn nnn nn";
            string[] checkArray = { "nnnn", "nnn", "nn", "n" };


            string[] outArray = Logic.Sort(yourSentence);

            Assert.AreEqual(checkArray[0], outArray[0]);
            Assert.AreEqual(checkArray[1], outArray[1]);
            Assert.AreEqual(checkArray[2], outArray[2]);
            Assert.AreEqual(checkArray[3], outArray[3]);


        }

        [TestMethod()]
        public void sortTest5Words()
        {

            string yourSentence = "n nnnn nnn nn nnnnn";
            string[] checkArray = { "nnnnn", "nnnn", "nnn", "nn", "n" };


            string[] outArray = Logic.Sort(yourSentence);

            Assert.AreEqual(checkArray[0], outArray[0]);
            Assert.AreEqual(checkArray[1], outArray[1]);
            Assert.AreEqual(checkArray[2], outArray[2]);
            Assert.AreEqual(checkArray[3], outArray[3]);
            Assert.AreEqual(checkArray[4], outArray[4]);


        }
    }
}