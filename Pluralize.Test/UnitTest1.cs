using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace Pluralize.Test
{
    [TestClass]
    public class ExtensionMethodTest
    {
        [TestMethod]
        public void Pluralize_works_for_0()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(0));
        }

        [TestMethod]
        public void Pluralize_works_for_1()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form1", toPluralize.Pluralize(1));
        }

        [TestMethod]
        public void Pluralize_works_for_2()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form2", toPluralize.Pluralize(2));
        }

        [TestMethod]
        public void Pluralize_works_for_3()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form2", toPluralize.Pluralize(3));
        }

        [TestMethod]
        public void Pluralize_works_for_4()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form2", toPluralize.Pluralize(4));
        }

        [TestMethod]
        public void Pluralize_works_for_5()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(5));
        }

        [TestMethod]
        public void Pluralize_works_for_6()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(6));
        }

        [TestMethod]
        public void Pluralize_works_for_10()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(10));
        }

        [TestMethod]
        public void Pluralize_works_for_11()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(11));
        }

        [TestMethod]
        public void Pluralize_works_for_12()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(12));
        }

        [TestMethod]
        public void Pluralize_works_for_20()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(20));
        }

        [TestMethod]
        public void Pluralize_works_for_21()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(21));
        }

        [TestMethod]
        public void Pluralize_works_for_22()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form2", toPluralize.Pluralize(22));
        }

        [TestMethod]
        public void Pluralize_works_for_25()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(25));
        }

        [TestMethod]
        public void Pluralize_works_for_100()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(100));
        }

        [TestMethod]
        public void Pluralize_works_for_101()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(101));
        }

        [TestMethod]
        public void Pluralize_works_for_102()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form2", toPluralize.Pluralize(102));
        }

        [TestMethod]
        public void Pluralize_works_for_103()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form2", toPluralize.Pluralize(103));
        }

        [TestMethod]
        public void Pluralize_works_for_104()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form2", toPluralize.Pluralize(104));
        }

        [TestMethod]
        public void Pluralize_works_for_105()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(105));
        }

        [TestMethod]
        public void Pluralize_works_for_106()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(106));
        }

        [TestMethod]
        public void Pluralize_works_for_110()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(110));
        }

        [TestMethod]
        public void Pluralize_works_for_111()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(111));
        }

        [TestMethod]
        public void Pluralize_works_for_112()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(112));
        }

        [TestMethod]
        public void Pluralize_works_for_120()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(120));
        }

        [TestMethod]
        public void Pluralize_works_for_121()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(121));
        }

        [TestMethod]
        public void Pluralize_works_for_122()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form2", toPluralize.Pluralize(122));
        }

        [TestMethod]
        public void Pluralize_works_for_125()
        {
            string toPluralize = "form1|form2|form3";
            Assert.AreEqual("form3", toPluralize.Pluralize(125));
        }
    }
}
