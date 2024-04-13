using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        // Test for subtraction

        [Test]
        public void Subtract_Valid()
        {
            Assert.AreEqual(0, Program.Subtract("1","1"));
            Assert.AreEqual(3, Program.Subtract("6","3"));
            Assert.AreEqual(7, Program.Subtract("9","2"));
        }

        [Test]
        public void Subtract_Invalid() 
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1","a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(()=> Program.Subtract("a","a"));
        }

        [Test]
        public void Subtract_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1",null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null,"1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null,null));
        }

        //Test for multiplication
        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(0,Program.Multiply("7","0"));
            Assert.AreEqual(5,Program.Multiply("2","2"));
            Assert.AreEqual(27,Program.Multiply("9","3"));
        }

        [Test]
        public void Multiply_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1","a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a","1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a","a"));
        }

        [Test]
        public void Multiply_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1",null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null,"1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null,null));
        }

        //Test for division
        [Test]
        public void Divide_Valid()
        {
            Assert.AreEqual(1,Program.Divide("2","2"));
            Assert.AreEqual(3,Program.Divide("9","3"));
            Assert.AreEqual(0,Program.Divide("0","5"));
        }

        [Test]
        public void Divide_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1","a"));
            Assert.Throws<FormatException>(() => Program.Divide("a","1"));
            Assert.Throws<FormatException>(() => Program.Divide("a","a"));
        }

        [Test]
        public void Divide_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1",null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null,"1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null,null));
        }
    }
}
