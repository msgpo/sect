﻿using System;
using EllipticCurveTool.EC;
using NUnit.Framework;

namespace EllipticCurveToolTests
{
    public class MathTest
    {
        [Test]
        public void TestCubicSolve()
        {
            double result1 = MathExtensions.SolveReducedCubicEquation(2, 2)[0];
            Assert.AreEqual(Math.Round(result1, 2), -0.77);
        }

        [Test]
        public void TestModulo()
        {
            Assert.AreEqual(5.Mod(3), 2);
            Assert.AreEqual(42.Mod(42), 0);
            Assert.AreEqual(5.Mod(-3), 2);
        }

        [Test]
        public void TestIsPrime()
        {
            Assert.IsTrue(5.IsPrime());
            Assert.IsTrue(7.IsPrime());
            Assert.IsTrue(11.IsPrime());
            Assert.IsTrue(2.IsPrime());
            Assert.IsFalse(1.IsPrime());
            Assert.IsFalse(1.IsPrime());
            Assert.IsFalse(4.IsPrime());
            Assert.IsFalse(42.IsPrime());
            Assert.IsFalse(21.IsPrime());
        }

        [Test]
        public void TestMultInv()
        {
            Assert.AreEqual(5.MultInv(7), 3);
            Assert.AreEqual(2.MultInv(8), 0);  // no inverse
            Assert.AreEqual(2.MultInv(5), 3);
        }

        [Test]
        public void TestGetBinaryRepresentation()
        {
            Assert.AreEqual(0.GetBinaryRepresentation(), "0");
            Assert.AreEqual(1.GetBinaryRepresentation(), "1");
            Assert.AreEqual(42.GetBinaryRepresentation(), "101010");
            Assert.AreEqual((-42).GetBinaryRepresentation(), "101010");  // we care only about absolute value
        }
    }
}
