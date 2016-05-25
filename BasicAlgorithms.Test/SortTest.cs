using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BasicAlgorithms.Test
{
    [TestFixture]
    class SortTest
    {
        [Test]
        public void SortShouldSort()
        {
            int[] unsorted = { 12, 3, 0, 82, 25, 11 };
            int[] sorted = { 0, 3, 11, 12, 25, 82 };

            Assert.That(Program.BubbleSort(unsorted), Is.EqualTo(sorted));
        }
    }
}
