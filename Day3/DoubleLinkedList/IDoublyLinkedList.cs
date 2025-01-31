using System;
public interface IDoubleLinkedList
{
    void AddNode(int value);
    void DisplayList();
    int GetCount();
}
class DoublyLinkedListNode
{
    public int data;
    public DoublyLinkedListNode Next; // References to the next node
    public DoublyLinkedListNode Prev; // References to the prev node
    
    public DoublyLinkedListNode(int x)
    {
        data = x;
        Next = null;
        Prev = null;
    }
}
