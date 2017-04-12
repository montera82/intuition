using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Intuition;

namespace BSTTests
{
    
    [TestClass]
    public class BinaryTreeImpTest
    {
        [TestMethod]
        public void shouldFindClosestSmallestNode()
        {
            BinaryTreeImp.toFind = 45;
            long expectedValue = 42;

            BinaryTreeImp bTree = new BinaryTreeImp();
            Node iniRoot = bTree.addNode(11);

            bTree.insertNode(bTree.root, iniRoot);
            bTree.insertNode(bTree.root, bTree.addNode(3));
            bTree.insertNode(bTree.root, bTree.addNode(54));
            bTree.insertNode(bTree.root, bTree.addNode(6));
            bTree.insertNode(bTree.root, bTree.addNode(42));
            bTree.insertNode(bTree.root, bTree.addNode(95));
            bTree.insertNode(bTree.root, bTree.addNode(2));
            bTree.insertNode(bTree.root, bTree.addNode(45));
            bTree.insertNode(bTree.root, bTree.addNode(24));
            bTree.insertNode(bTree.root, bTree.addNode(23));
            bTree.insertNode(bTree.root, bTree.addNode(34));

            

            bTree.findSmallestClosetNode(bTree.root);

            Assert.AreEqual(expectedValue, BinaryTreeImp.lastVisit);
        }
    }
}
