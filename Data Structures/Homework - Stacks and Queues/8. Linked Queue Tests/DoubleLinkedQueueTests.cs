using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class DoubleLinkedQueueTests
{
    DoubleLinkedQueue<int> myStack;

    [TestInitialize]
    public void Init()
    {
        //Arrange
        myStack = new DoubleLinkedQueue<int>();
    }

    [TestMethod]
    public void Count_ShouldWorkProperly()
    {
        //Act
        myStack.Enqueue(20);

        //Assert
        Assert.AreEqual(myStack.Count, 1);

        //Act
        myStack.Dequeue();

        //Assert
        Assert.AreEqual(myStack.Count, 0);

    }

    [TestMethod]
    public void PushPop_PushPopElements_ShouldWorkProperly()
    {
        //Act and Assert Push
        for (int i = 1; i <= 1000; i++)
        {
            myStack.Enqueue(i);
            Assert.AreEqual(myStack.Count, i);
        }

        //Act and Assert
        for (int i = 999; i >= 1; i--)
        {
            myStack.Dequeue();
            Assert.AreEqual(myStack.Count, i);
        }
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void Pop_EmptyStack_ShouldThrowException()
    {
        //Assert
        myStack.Dequeue();
    }

    [TestMethod]
    public void PushPop_EmptyStackWithCapacityOne_ShoudIncreaseCapacity()
    {
        myStack = new DoubleLinkedQueue<int>();

        Assert.AreEqual(myStack.Count, 0);

        myStack.Enqueue(1);

        Assert.AreEqual(myStack.Count, 1);

        myStack.Enqueue(2);

        Assert.AreEqual(myStack.Count, 2);

        myStack.Dequeue();

        Assert.AreEqual(myStack.Count, 1);

        myStack.Dequeue();

        Assert.AreEqual(myStack.Count, 0);
    }

    [TestMethod]
    public void ToArray_NonEmptyStack_ShouldReturnProperArrayOfTheStack()
    {
        myStack.Enqueue(7);
        myStack.Enqueue(-2);
        myStack.Enqueue(5);
        myStack.Enqueue(3);

        var returnArray = myStack.ToArray();

        for (int i = 0; i < 4; i++)
        {
            Assert.AreEqual(returnArray[i], myStack.Dequeue());
        }
    }

    [TestMethod]
    public void ToArray_EmptyStack_ShouldReturnProperArray()
    {
        //Arrange
        var myStack = new DoubleLinkedQueue<DateTime>();

        //Act
        var returnArray = myStack.ToArray();

        //Assert
        Assert.IsTrue(!returnArray.Any());
    }
}