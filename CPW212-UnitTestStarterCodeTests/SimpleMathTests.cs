using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW212_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]//+
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            //get expected outcome
            double Result = num1 + num2;
            // Use the DataRow values to test the Add method
            double Answer = SimpleMath.Add(num1, num2);
            Assert.AreEqual(Result, Answer);
        }

        [TestMethod]//*
        [DataRow(5, 10)]
        [DataRow(3, 120)]
        [DataRow(-1, -10)]
        [DataRow(0, 3)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            
            double answer = num1 * num2 ;
            //get expected outcome
            double Result = SimpleMath.Multiply(num1,num2);
            // Use a few pairs of values to test the Multiply method
            Assert.AreEqual(Result, answer);
        }

        [TestMethod]// 1/0
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(1,0)); 
        }

        // TODO: Test Divide method with two valid numbers

        // TODO: Test subtract method with two valid numbers
    }
}