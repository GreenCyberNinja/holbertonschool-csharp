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
    public void Print()
    {
        if (head != null)
        {
            Node nav = head;
            while (nav != null)
            {
                Console.WriteLine($"{nav.value}");
                nav = nav.next;
            }
        }
        else
            Console.WriteLine("Queue is empty");
    }
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
            return head.value;
    }
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            Node ghost =  head;
            head = head.next;
            count--;
            return ghost.value;
        }
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
       public T value = default(T);
        public Node next = null;
        public Node(T newV)
        {
            this.value = newV;
        }
    }
}