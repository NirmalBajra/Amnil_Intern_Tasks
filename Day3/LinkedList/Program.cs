using System;
using System.Collections.Generic;

public interface ILinkedList
{
    void AddNode(int value);
    void displayList();
}
class LinkedListNode{
    public int data;
    public LinkedListNode next;
    public LinkedListNode(int x){
        data = x;
        next = null;
    }
}
public class LinkedList : ILinkedList
{
    private LinkedListNode head;
    private int count;
    public LinkedList(){
        head = null;
        count = 0;
    }
    public void AddNode(int data)
    {
        LinkedListNode node = new LinkedListNode(data);
        node.next = head;
        head = node;
        count++;
    }
    public void displayList()
    {
        LinkedListNode runner = head;
        while(runner != null)
        {
            Console.WriteLine(runner.data);
            runner = runner.next;
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        LinkedList myList = new LinkedList();
        myList.AddNode(12);
        myList.AddNode(22);
        myList.AddNode(32);
        myList.AddNode(45);
        myList.AddNode(44);

        Console.WriteLine("Linked List Data:");
        myList.displayList();
    }
}