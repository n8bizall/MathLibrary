using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathematicsLibrary;

namespace MathematicsLibrary.Test
{
    [TestClass]
    public class TestLib
    {
        MathLib mathlib;

        [TestInitialize]
        public void Initialization()
        {
            mathlib = new MathLib();
        }

        [TestMethod]
        public void AddTest()
        {
            Assert.AreEqual(4.5, mathlib.Add(1.5, 3.0));
            Assert.AreEqual(9, mathlib.Add(4.5, 4.5));
            Assert.AreEqual(1.4, mathlib.Add(2.7, -1.3), 0.1);
        }

        [TestMethod]
        public void SubtractTest()
        {
            Assert.AreEqual(4.2, mathlib.Subtract(7.4, 3.2),0.1);
            Assert.AreEqual(-7.8, mathlib.Subtract(-9.3, -1.5),0.1);
            Assert.AreEqual(23.8, mathlib.Subtract(20.1, -3.7), 0.1);
        }
        [TestMethod]
        public void MultiplyTest()
        {
            Assert.AreEqual(57.66, mathlib.Multiply(9.3, 6.2),0.1);
            Assert.AreEqual(-56.12, mathlib.Multiply(-9.2, 6.1),0.1);
            Assert.AreEqual(10, mathlib.Multiply(-2.5, -4),0.1);
        }
       
        [TestMethod]
        public void DivideTest()
        {
            Assert.AreEqual(2, mathlib.Divide(8, 4));
            Assert.AreEqual(9, mathlib.Divide(81, 9));
            Assert.AreEqual(1, mathlib.Divide(10, 10));
        }
        [TestMethod]
        public void SquareTest()
        {
            Assert.AreEqual(4, mathlib.Square(2));
            Assert.AreEqual(81, mathlib.Square(9));
            Assert.AreEqual(100, mathlib.Square(10));
        }
        [TestMethod]
        public void InverseTest()
        {
            Assert.AreEqual(4.84, mathlib.Square(2.2), 0.1);
            Assert.AreEqual(82.81, mathlib.Square(-9.1), 0.1);
            Assert.AreEqual(100, mathlib.Square(10));
        }
        [TestMethod]
        public void NegateTest()
        {
            Assert.AreEqual(-2.2, mathlib.Multiply(2.2, -1), 0.1);
            Assert.AreEqual(9.5, mathlib.Multiply(-9.5, -1), 0.1);
            Assert.AreEqual(-10.3, mathlib.Multiply(10.3, -1), 0.1);
        }

    } }
