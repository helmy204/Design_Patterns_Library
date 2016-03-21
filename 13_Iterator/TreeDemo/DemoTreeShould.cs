using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _13_Iterator.TreeDemo
{
    [TestFixture]
    public class DemoTreeShould
    {
        [Test]
        public void StartEmpty()
        {
            var myTree = new DemoTree<string>();
            Assert.IsNull(myTree.Value);
        }

        [Test]
        public void StoreValueInRootNode()
        {
            int expectedValue = 1;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);

            Assert.AreEqual(expectedValue, myTree.Value);
        }

        [Test]
        public void StoreSecondValueInLeftNode()
        {
            int expectedValue = 2;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);

            Assert.AreEqual(expectedValue, myTree.LeftChild.Value);
        }

        [Test]
        public void StoreThirdValueInRightNode()
        {
            int expectedValue = 3;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);

            Assert.AreEqual(expectedValue, myTree.RightChild.Value);
        }

        [Test]
        public void StoreForthValueInLeftLeftNode()
        {
            int expectedValue = 4;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);

            Assert.AreEqual(expectedValue, myTree.LeftChild.LeftChild.Value);
        }

        [Test]
        public void StoreFifthValueInLeftRightNode()
        {
            int expectedValue = 5;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);

            Assert.AreEqual(expectedValue, myTree.LeftChild.RightChild.Value);
        }


        [Test]
        public void StoreSixthValueInLeftRightNode()
        {
            int expectedValue = 6;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);

            DisplayTree(myTree);
            Assert.AreEqual(expectedValue, myTree.RightChild.LeftChild.Value);
        }

        [Test]
        public void ListValuesInDepthFirstOrder()
        {
            int expectedValue = 6;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);

            DisplayTree(myTree);
            var valuesString = string.Join(" ", myTree.ToList().ToArray());

            Assert.AreEqual("1 2 4 5 3 6", valuesString);
        }

        [Test]
        public void ListValuesInDepthFirstOrderWithEnumerator()
        {
            int expectedValue = 6;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);

            DisplayTree(myTree);
            var valuesString = string.Join(" ", myTree.ToArray());
            Assert.AreEqual("1 2 4 5 3 6", valuesString);
        }

        [Test]
        public void ListValuesInBreadthFirstOrderWithEnumerator()
        {
            int expectedValue = 6;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);
            myTree.UseBreadthFirstEnumerator = true;

            DisplayTree(myTree);
            var valuesString = string.Join(" ", myTree.ToArray());
            Assert.AreEqual("1 2 3 4 5 6", valuesString);
        }

        [Test]
        public void InitialTreeHasDepthZero()
        {
            var myTree = new DemoTree<int>();
            myTree.Add(1);

            Assert.AreEqual(0, myTree.Depth());
        }

        private DemoTree<int> CreateTreeWithValues(int numberOfValues)
        {
            if (numberOfValues <= 0) return null;

            var tree = new DemoTree<int>(1);

            for (int i = 2 ; i <= numberOfValues; i++)
            {
                tree.Add(i);
            }
            return tree;
        }

        public void DisplayTree(DemoTree<int> tree)
        {
            var serializer = new XmlSerializer(tree.GetType());
            serializer.Serialize(Console.Out, tree);
        }
    }
}
