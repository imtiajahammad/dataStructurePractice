using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructurePractice.linkedList;

public class LinkedList
{

    public LinkedList()
    {
    SingleNode<int> firstNode = new SingleNode<int>(){ Data = 10, Link = null};
    SingleLinkedList<int> obj = new SingleLinkedList<int>();
    obj.Traverse();
    obj.AddFirst(firstNode);
    SingleNode<int> secondNode = new SingleNode<int>(){ Data = 2, Link = null };
    obj.AddLast(secondNode);
    SingleNode<int> zeroNode = new SingleNode<int>(){ Data = 3, Link = null };
    obj.AddFirst(zeroNode);
    obj.Traverse();
    obj.find(2);
    obj.sort();
    obj.Traverse();
    }
    
}
public class SingleNode<T>
{
    public T Data { get; set; }
    public SingleNode<T>? Link { get; set; }
}

public class SingleLinkedList<T>
{
    public SingleLinkedList()
    {

    }
    public SingleLinkedList(SingleNode<T> headNode)
    {
        this.Head = headNode;
    }
    public SingleNode<T> Head { get; set; }
    public void AddFirst(SingleNode<T> newNode)
    {
        if(this.Head == null)
        {
            this.Head = newNode;
        }
        else
        {
            newNode.Link = this.Head;
            this.Head = newNode;
        }
    }
    public void AddLast(SingleNode<T> newNode)
    {
        if(this.Head == null)
        {
            this.Head = newNode;
        }
        else
        {
            var temp = Head;
            while(temp.Link != null)
            {
                temp = temp.Link;
            }
            temp.Link = newNode;
        }
    }
    public void Traverse()
    {
        if(Head == null)
        {
            Console.WriteLine("no nodes");
        }
        else
        {
            var temp = Head;
            Console.Write("\n Traversed Nodes => " + temp.Data);
            while(temp.Link != null)
            {
                temp = temp.Link;
                Console.Write(" -> " +temp.Data);
            }
        }
    }
    public void find(T query)
    {
        if(Head == null)
        {
            Console.WriteLine("no nodes");
        }
        else
        {
            var temp = Head;
            do
            {
                if(temp.Data.Equals(query))
                {
                    Console.WriteLine($"\n{query} found");
                    break;
                }
                temp = temp.Link;
            }
            while(temp != null);
        }
    }
    public void sort()
    {
        if(Head == null)
        {
            Console.WriteLine($"\n no nodes");
        }
        else
        {
            var temp = Head;
            do
            {
                Console.Write($"\n sort every -> {temp.Data}");
                /*another loop to run from head */
                var tempNext = temp.Link;
                while(tempNext != null)
                {
                    Console.Write($"\n sort every tempNext-> {tempNext.Data} ");
                    if(tempNext != null && Convert.ToInt64(temp.Data) > Convert.ToInt64(tempNext.Data))
                    {
                        var smaller = tempNext.Data;
                        tempNext.Data = temp.Data;
                        temp.Data = smaller;
                    }
                    tempNext = tempNext?.Link;
                }
                /*another loop to run from head */
                temp = temp.Link;

            }while(temp != null);
        }
    }
}
