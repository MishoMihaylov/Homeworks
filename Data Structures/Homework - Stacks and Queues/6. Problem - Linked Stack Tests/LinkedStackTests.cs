using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class LinkedStackTests
{
    LinkedStack<int> myStack;

    [TestInitialize]
    public void Init()
    {
        //Arrange
        myStack = new LinkedStack<int>();
    }

    [TestMethod]
    public void Count_ShouldWorkProperly()
    {
        //Act
        myStack.Push(20);

        //Assert
        Assert.AreEqual(myStack.Count, 1);

        //Act
        myStack.Pop();

        //Assert
        Assert.AreEqual(myStack.Count, 0);

    }

    [TestMethod]
    public void PushPop_PushPopElements_ShouldWorkProperly()
    {
        //Act and Assert Push
        for (int i = 1; i <= 1000; i++)
        {
            myStack.Push(i);
            Assert.AreEqual(myStack.Count, i);
        }

        //Act and Assert
        for (int i = 999; i >= 1; i--)
        {
            myStack.Pop();
            Assert.AreEqual(myStack.Count, i);
        }
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void Pop_EmptyStack_ShouldThrowException()
    {
        //Assert
        myStack.Pop();
    }

    [TestMethod]
    public void PushPop_EmptyStackWithCapacityOne_ShoudIncreaseCapacity()
    {
        myStack = new LinkedStack<int>();

        Assert.AreEqual(myStack.Count, 0);

        myStack.Push(1);

        Assert.AreEqual(myStack.Count, 1);

        myStack.Push(2);

        Assert.AreEqual(myStack.Count, 2);

        myStack.Pop();

        Assert.AreEqual(myStack.Count, 1);

        myStack.Pop();

        Assert.AreEqual(myStack.Count, 0);
    }

    [TestMethod]
    public void ToArray_NonEmptyStack_ShouldReturnProperArrayOfTheStack()
    {
        myStack.Push(7);
        myStack.Push(-2);
        myStack.Push(5);
        myStack.Push(3);

        var returnArray = myStack.ToArray();

        for (int i = 0; i < 4; i++)
        {
            Assert.AreEqual(returnArray[i], myStack.Pop());
        }
    }

    [TestMethod]
    public void ToArray_EmptyStack_ShouldReturnProperArray()
    {
        //Arrange
        var myStack = new LinkedStack<DateTime>();

        //Act
        var returnArray = myStack.ToArray();

        //Assert
        Assert.IsTrue(!returnArray.Any());
    }
}
