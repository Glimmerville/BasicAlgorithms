using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BasicAlgorithms.Test
{
    [TestFixture]
    class LinkedListTest
    {
        [Test]
        public void BasicTestsOfLinkedList()
        {
            LinkedList A = new LinkedList();
            A.Add(3);
            A.Add(7);
            A.Add(7);
            A.Add(8);
            A.Add(12);
            A.Add(9);
            A.Add(2);

            Assert.That(A.Length, Is.EqualTo(7));
            Assert.That(A.GetItem(3), Is.EqualTo(8));
        }
    }
}
