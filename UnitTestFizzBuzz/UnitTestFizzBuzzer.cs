using FizzBuzz.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestFizzBuzz
{
    [TestClass]
    public class UnitTestFizzBuzzer
    {
        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(4)]
        [DataRow(7)]
        public void FizzBuzz_Shouldbe_(int number)
        {
            
            FizzBuzzer fizzBuzzer = new FizzBuzzer();
            //Act
            string result = fizzBuzzer.GetValue(number);
            //Assert
            Assert.AreEqual(number.ToString(), result);
        }
       
        
        [TestMethod]
        [DataRow(3)]
        [DataRow(6)]
        public void FizzBuzz_Shouldbe_Fizz(int number)
        {
            
            FizzBuzzer fizzBuzzer = new FizzBuzzer();

            string result = fizzBuzzer.GetValue(number);

            Assert.AreEqual("Fizz", result);
        }
        

        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]
        public void FizzBuzz_Shouldbe_Buzz(int number)
        {
            
            FizzBuzzer fizzBuzzer = new FizzBuzzer();

            string result = fizzBuzzer.GetValue(number);

            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        [DataRow(15)]
        [DataRow(30)]
        public void FizzBuzz_Shouldbe_FizzBuzz(int number)
        {

            FizzBuzzer fizzBuzzer = new FizzBuzzer();

            string result = fizzBuzzer.GetValue(number);

            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
