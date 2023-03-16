namespace DataStructureDemoStackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
           StackLinkedList stackLinkedList = new StackLinkedList();
           stackLinkedList.Push(70);
           stackLinkedList.Push(30);
           stackLinkedList.Push(56);
           stackLinkedList.Display();
        }
    }
}