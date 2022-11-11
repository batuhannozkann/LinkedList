// See https://aka.ms/new-console-template for more information
var iter = new Node();
var root = new Node();
var lastnode = new Node();
iter = root;
root.Data = 10;
root.Next = new Node() { Data = 20,Back=iter};
root.Next.Next = new Node() { Data = 30 , Back = iter.Next};
root.Next.Next.Next = new Node() { Data = 40, Back = iter.Next.Next };
while(iter !=null)
{
    Console.WriteLine(iter.Data);
    if (iter.Next == null)
    {
        lastnode = iter;
    }
    iter = iter.Next;
    
}
while(lastnode!=root)
{
    Console.WriteLine(lastnode.Data);
    lastnode = lastnode.Back;
}
Console.WriteLine(root.Data);
; public class Node
{
    public  int Data { get; set; }
    public  Node Back { get; set; }
    public  Node Next  { get; set; }

}