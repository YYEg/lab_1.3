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

            string yourSentence = Logic.Sort("n nn nnn");
            Assert.AreEqual("nnn nn n", yourSentence);
            
        }

        [TestMethod()]
        public void sortTest4Words()
        {

            string yourSentence = Logic.Sort("n nn nnnn nnn");
            Assert.AreEqual("nnnn nnn nn n", yourSentence);


        }

        [TestMethod()]
        public void sortTest5Words()
        {

            string yourSentence = Logic.Sort("nnnnnnnnnnnnnnnnnn n nn nnnn nnn");
            Assert.AreEqual("nnnnnnnnnnnnnnnnnn nnnn nnn nn n", yourSentence);

        }
    }
}