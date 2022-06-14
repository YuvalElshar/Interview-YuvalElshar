//Implement Linked list of int by given interface, 
//implement reverse method without additional arrays or collections:
public class Node
{
    public int Data;
    public Node Next;
}
public class LinkedList : IMyList
{
    public Node Head { get; set; }
    public void Add(int elm) //add to the beginning of the list
    {
        Node newNode = new Node();
        newNode.Data = elm;
        newNode.Next = Head;
        Head = newNode;
    }

    public void PrintAll()
    {
        Node current = Head;
        Console.Write("[ ");

        while (current != null)
        {
            Console.Write(current.Data+" ");
            current = current.Next;
        }
        Console.WriteLine("]");
    }

    public void Reverse()
    {

        Node prev = null;
        Node current = Head; 
        Node next = null;

        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }

        Head = prev;
    }
    public static void Main()
    {
        LinkedList linkedList = new LinkedList();
        linkedList.Add(3);
        linkedList.Add(2);
        linkedList.Add(1);
        linkedList.Add(0);
        linkedList.PrintAll();
        linkedList.Reverse();
        linkedList.PrintAll();
    }
}
public interface IMyList
{
    Node Head { get; set; }

    void Add(int elm);   // add new element
    void PrintAll();   //print all list
    void Reverse(); // reverse list, implement without using helpers collection\arrays  
}


