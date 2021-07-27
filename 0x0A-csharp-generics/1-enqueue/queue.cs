using System;


class Queue<T>
{
    Node head;
    Node tail;
    int count;
    public string CheckType()
    {
        return typeof(T).ToString();
    }
    public void Enqueue(T value)
    {
        Node newN = new Node(value);
        if (head == null)
        {
            head = newN;
            tail = newN;
        }
        else
        {
            tail.next = newN;
            tail = newN;
        }
        count++;
    }
    public int Count()
    {
        return count;
    }
    public class Node
    {
        T value = default(T);
        public Node next = null;
        public Node(T newV)
        {
            this.value = newV;
        }
    }
}
