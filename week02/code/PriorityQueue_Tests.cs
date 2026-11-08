using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priority levels.
    // Expected Result: Items should be removed in descending priority order.
    // Defect(s) Found: Original code skipped the last queue item when searching
    // for the highest priority and failed to remove dequeued items.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 3);
        priorityQueue.Enqueue("High", 5);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());

         Assert.AreEqual("[]", priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Add items with equal priorities and one item with a lower priority.
    // Expected Result: Equal priorities follow FIFO order.
    // Defect(s) Found: Original code did not remove dequeued items
    // and did not preserve FIFO ordering for equal priorities.
    public void TestPriorityQueue_2()
     {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First", 4);
        priorityQueue.Enqueue("Second", 4);
        priorityQueue.Enqueue("Third", 2);

        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());

        Assert.AreEqual("[]", priorityQueue.ToString());
    }

    private int GetQueueLength(PriorityQueue queue)
    {
        return queue.ToString() == "[]" ? 0 : -1;
    }

    // Add more test cases as needed below.
}