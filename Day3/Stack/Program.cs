using System;
public interface IStack
{
    void Push(int item);
    int Pop();
    int Peek();
    bool IsEmpty();
}
class Stack : IStack{
   private class StackNode
   {
        public int data;
        public StackNode Next;
        public StackNode(int value)
        {
            data = value;
            Next = null;
        }
   }
   private StackNode top;
   private int count;
   public Stack()
   {
        top = null;
        count = 0;
   }
   public void Push(int item)
   {
        StackNode node = new StackNode(item);
        node.Next = top;
        top = node;
        count++;
   }
   public int Pop()
   {
        if(IsEmpty())
        {
            throw new InvalidOperationException("The Stack is Empty");
        }
        int value = top.data;
        top = top.Next;
        count--;
        return value;
   }
   public int Peek()
   {
        if(IsEmpty())
        {
            throw new InvalidOperationException("The Stack is Empty");
        }
        return top.data;
   }
   public bool IsEmpty()
   {
        return top == null;
   }
   public void Display()
   {
        if(IsEmpty())
        {
            Console.WriteLine("The Stack is Empty");
            return;
        }
        StackNode currentNode = top;
        Console.WriteLine("Elements in the Stack are:");
        while(currentNode != null)
        {
            Console.WriteLine(currentNode.data);
            currentNode = currentNode.Next;
        }
   }
}
class Program{
    public static void Main(string[] args)
    {
        Stack stack = new Stack();
        stack.Push(10);
        stack.Push(11);
        stack.Push(12);
        stack.Push(13);
        stack.Push(14);
        Console.WriteLine("Stack element Displaying:");
        stack.Display();

        Console.WriteLine($"Peek operation Performerd: {stack.Peek()}");

        Console.WriteLine($"Popped element: {stack.Pop()}");

        Console.WriteLine("stack after popping an element");
        stack.Display();
    }
}