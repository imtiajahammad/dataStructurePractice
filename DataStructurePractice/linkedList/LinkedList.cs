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