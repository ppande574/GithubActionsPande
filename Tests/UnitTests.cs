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
        [Test]
        public void Subtract_Valid_Pratik_Pande()
        {
            Assert.AreEqual(3, Program.Subtract("7", "4"));
            Assert.AreEqual(-5, Program.Subtract("10", "15"));
            Assert.AreEqual(12, Program.Subtract("36", "24"));
        }
        
        [Test]
        public void Subtract_Invalid_Pratik_Pande()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("b", "2"));
            Assert.Throws<FormatException>(() => Program.Subtract("c", "d"));
        }
        
        Test]
        public void Subtract_Null_Pratik_Pande()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }
        
        
        [Test]
        public void Multiply_Valid_Pratik_Pande()
        {
            Assert.AreEqual(3, Program.Multiply("1", "3"));
            Assert.AreEqual(12, Program.Multiply("6", "2"));
            Assert.AreEqual(100, Program.Multiply("10", "10"));
        }
        
        
        [Test]
        public void Multiply_Invalid_Pratik_Pande()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }
        
        [Test]
        public void Multiply_Null_Pratik_Pande()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }
        
        
        [Test]
        public void Divide_Valid_Pratik_Pande()
        {
            Assert.AreEqual(4, Program.Divide("8", "2"));
            Assert.AreEqual(3, Program.Divide("6", "2"));
            Assert.AreEqual(1, Program.Divide("10", "10"));
        }
        
        [Test]
        public void Divide_Invalid_Pratik_Pande()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }
        
        
        [Test]
        public void Multiply_Null_Pratik_Pande()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }
        
        
        [Test]
        public void Power_Valid_Pratik_Pande()
        {
            Assert.AreEqual(64, Program.Power("8", "2"));
            Assert.AreEqual(36, Program.Power("6", "2"));
            Assert.AreEqual(1000, Program.Power("10", "3"));
        }
        
        [Test]
        public void Power_Invalid_Pratik_Pande()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }
        
        [Test]
        public void Power_Null_Pratik_Pande()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }
        
    }
}
