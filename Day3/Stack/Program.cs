using System;
public interface IStack
{
    void Push(int item);
    void Pop();
    void Peek();
}
class stack : IStack{
    private List<int> items = new List<int>(); 
    public void Push(int item){
        items.Add(item);
    }
}
class Program{

}