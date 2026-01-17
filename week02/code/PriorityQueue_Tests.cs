using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: enqueue multiple items with different priorities
    // Expected Result: highest priority removed first
    // Defect(s) Found: Dequeue didn’t remove the highest priority correctly.
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Alice", 2);
        pq.Enqueue("Bob", 5);
        pq.Enqueue("Charlie", 3);

        Assert.AreEqual("Bob", pq.Dequeue());
        Assert.AreEqual("Charlie", pq.Dequeue());
        Assert.AreEqual("Alice", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: enqueue items with same priority, check FIFO order
    // Expected Result: items with same priority dequeued in order they were added
    // Defect(s) Found: FIFO wasn’t preserved for items with the same priority.
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Alice", 3);
        pq.Enqueue("Bob", 3);
        pq.Enqueue("Charlie", 2);

        Assert.AreEqual("Alice", pq.Dequeue());
        Assert.AreEqual("Bob", pq.Dequeue());
        Assert.AreEqual("Charlie", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: empty queue throws error
    // Expected Result: InvalidOperationException thrown
    //Defect(s) Found: none
    public void TestPriorityQueue_EmptyQueue()
    {
        var pq = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => pq.Dequeue(), "The queue is empty.");
    }
}