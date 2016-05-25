using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace BasicAlgorithms.Test
{
    [TestFixture]
    public class SearchTest
    {
        [Test]
        public void ContainsShouldFindAllElements()
        {
            int[] myArray = { 7, 5, 3, 2, 9, 11, 19, 0, 60, 4 };

            Assert.That(Program.Contains(myArray, 11), Is.True);
            Assert.That(Program.Contains(myArray, 7), Is.True);
            Assert.That(Program.Contains(myArray, 4), Is.True);
            Assert.That(Program.Contains(myArray, 0), Is.True);
            Assert.That(Program.Contains(myArray, -17), Is.False);

        }



    }
}
