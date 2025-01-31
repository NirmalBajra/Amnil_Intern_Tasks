public class DoublyLinkedList : IDoubleLinkedList
{
    private DoublyLinkedListNode head;
    private DoublyLinkedListNode tail;
    private int count;
    public DoublyLinkedList()
    {
        head = null;
        tail = null;
        count = 0;
    }
    public void AddNode(int value)
    {
        DoublyLinkedListNode node = new DoublyLinkedListNode(value);
        if(head == null)
        {
            head = node;
            tail = node;
        }else{
            node.Next = head;
            head.Prev = node;
            head = node;
        }
        count++;
    }
    public void DisplayList()
    {
        if(head == null)
        {
            Console.WriteLine("The Linked List is empty");
            return;
        }
        DoublyLinkedListNode currentNode = head;
        while(currentNode !=null)
        {
            Console.WriteLine(currentNode.data + " ");
            currentNode = currentNode.Next;
        }
        Console.WriteLine();
    }
    public int GetCount(){
        return count;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        DoublyLinkedList list = new DoublyLinkedList();
        list.AddNode(21);
        list.AddNode(31);
        list.AddNode(27);
        list.AddNode(31);
        list.AddNode(25);
        list.AddNode(41);
        Console.WriteLine("Doubly Linked List Data: ");
        list.DisplayList();

    }
}