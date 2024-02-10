using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructurePractice.linkedList;

public class DoublyLinkedList<T>
{
    public DoublyLinkedList()
    {
        
    }
    public DoublyLinkedList(DoublyNode<T> headNode)
    {
        this.Head = headNode;
    }
    public DoublyNode<T> Head { get; set; }
    public void Add(DoublyNode<T> newNode)
    {
        if(Head == null)
        {
            Console.WriteLine($"No nodes");
            return;
        }
        newNode.NextLink= Head.NextLink;
        newNode.PreviousLink = Head;
        Head.NextLink=newNode;
    }
    public void Traverse()
    {
        if(Head == null)
        {
            Console.WriteLine($"No nodes");
            return;
        }
        Console.WriteLine($"\n -> {Head.Data}");
        var temp = Head.NextLink;
        while(temp != null)
        {
            Console.WriteLine($" -> {temp.Data}");
            if(temp.NextLink == Head)
            {
                return;
            }
            temp = temp.NextLink;
        }
    }
    public void Find(T query)
    {
        if(Head == null)
        {
            Console.WriteLine($"No nodes");
            return;
        }
        var temp = Head;
        while(temp != null)
        {
            if( Convert.ToInt32(temp.Data) == Convert.ToInt32(query))
            {
                Console.WriteLine($" {query} found!");
                return;
            }
            if(temp.NextLink == Head)
            {
                Console.WriteLine($" {query} not found!");
                return;
            }
            temp = temp.NextLink;
        }
    }
}