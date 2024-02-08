using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructurePractice.linkedList;

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
    
    #region conditionally
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
    public void Find(T query)
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
    public void Sort()
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
    public void InsertAt(int index, T value)
    {
        if(Head == null)
        {
            Console.WriteLine($"\n no nodes");
            return;
        }
        int count = 0;
        var current = Head;
        SingleNode<T>? previous = null;
        while(current != null && count != index )
        {
            count++;
            previous = current;
            current= current.Link;
        }
        SingleNode<T> newNode = new SingleNode<T>(){ Data = value, Link = null };
        newNode.Link = current;
        if(previous!=null){
            previous.Link = newNode;
            return;
        }
        Head = newNode;
        
    }
    public void Reverse()
    {
        if(Head == null)
        {
            Console.WriteLine($"No nodes! ");
        }
        SingleNode<T> headNode = new SingleNode<T>(){ Data = Head.Data, Link = null };
        var temp = Head.Link;
        while(temp != null)
        {
            SingleNode<T> newNode = new SingleNode<T>(){ Data = temp.Data, Link = headNode };
            headNode =  newNode;

            temp = temp.Link;
        }
        Head = headNode;

    }
    public void TotalSum()
    {
        if(Head == null){
            Console.WriteLine($"\nNo nodes!");
        }
        var temp = Head;
        int totalSum = 0;
        while(temp != null)
        {
            totalSum = totalSum + Convert.ToInt32(temp.Data);
            temp = temp.Link;
        }
        Console.WriteLine($"\nTotal Sum is -> {totalSum}");
    }
    public void TotalSumReversely()
    {
        //make it reverse and then sum it
        if(Head == null)
        {
            Console.WriteLine($"\nNo nodes!");
        }
        var temp = Head.Link;
        SingleNode<T> headNode = Head;headNode.Link = null;
        while(temp != null)
        {
            SingleNode<T> newNode = new SingleNode<T>(){ Data = temp.Data, Link = headNode};
            headNode = newNode;
            temp = temp.Link;
        }
        Head = headNode;
        temp = Head;
        int totalSum = 0;
        while(temp != null)
        {
            totalSum = totalSum + Convert.ToInt32(temp.Data);
            temp = temp.Link;
        }
        Console.WriteLine($"\n TotalSumReversely Sum is -> {totalSum}");
    }
    public SingleNode<T> ZipperList(SingleNode<T> list1Head, SingleNode<T> list2Head)
    {
        if(list1Head == null || list2Head == null)
        {
            if(list1Head == null)
            {
                return list2Head;
            }
            else
            {
                return list1Head;
            }
        }
        var temp1 = list1Head;
        var temp2 = list2Head;
        int count = 1;
        SingleNode<T> zippedHead = new SingleNode<T>(){ Data = temp1.Data, Link = null };
        var zippedTemp = zippedHead;
        temp1 = temp1.Link;
        while(temp1 != null || temp2 != null)
        {
            if(temp1 == null)
            {
                zippedTemp.Link = temp2;
                return zippedHead;
            }
            if(temp2 == null)
            {
                zippedTemp.Link = temp1;
                return zippedHead;
            }
            count++;
            if(count%2 == 0)
            {
                SingleNode<T> singleNode = new SingleNode<T>(){ Data = temp2.Data, Link= null};
                zippedTemp.Link = singleNode;
                zippedTemp = zippedTemp.Link;
                temp2 = temp2.Link;
            }
            else
            {
                SingleNode<T> singleNode = new SingleNode<T>(){ Data = temp1.Data, Link= null};
                zippedTemp.Link = singleNode;
                zippedTemp = zippedTemp.Link;
                temp1 = temp1.Link;

            }
        }
        return zippedHead;
    }
    #endregion conditionally

    #region recursion ways
    public void TraverseWithRecursion(SingleNode<T> singleNode)
    {
        if(Head == null)
        {
            Console.WriteLine("No nodes");
            return;
        }
        Console.Write(" -> " +singleNode.Data);
        if(singleNode.Link != null)
        {
            TraverseWithRecursion(singleNode.Link);
        }
    }
    public void AddFirstWithRecursion(SingleNode<T> newNode)
    {
        if(Head == null)
        {
            Console.WriteLine($"No nodes!");
            return;
        }
        newNode.Link = Head;
        Head= newNode;
    }
    public void AddLastWithRecursion(SingleNode<T> newNode, SingleNode<T> traversalNode)
    {
        if(Head == null)
        {
            Console.WriteLine($"No nodes!");
            return;
        }
        if(traversalNode.Link != null)
        {
            AddLastWithRecursion(newNode,traversalNode.Link);
        }
        else
        {
            traversalNode.Link = newNode;
        }
    }
    public void FindWithRecursion(T query, SingleNode<T> traversalNode)
    {
        if(Head == null){
            Console.WriteLine($"\n No nodes!");
            return;
        }
        if(!traversalNode.Data.Equals(query) && traversalNode.Link != null)
        {
            FindWithRecursion(query, traversalNode.Link);
        }
        else if(traversalNode.Data.Equals(query)){
            Console.WriteLine($"\n {query} found");
            return;
        }
        else{
            Console.WriteLine($"\n {query} not found!");
        }
    }
    public void SortWithRecursion(SingleNode<T> traverseNode)
    {
        if(Head == null)
        {
            Console.WriteLine($"\n No nodes!");
        }
        if(traverseNode.Link != null)
        {
            var current = Head;
            while(current != null && current.Link != null)
            {
                var next = current.Link;
                if(Convert.ToInt32(current.Data)>Convert.ToInt32(next.Data))
                {
                    var temp = current.Data;
                    current.Data = next.Data;
                    next.Data = temp;
                }
                current = current.Link;
            }
            SortWithRecursion(traverseNode.Link);
        }

        
    }
    public void InsertAtWithRecursion(int index, SingleNode<T> newNode, int count, SingleNode<T> currentNode)
    {
        if(Head == null || currentNode == null){
            Console.WriteLine($"No nodes!");
            return;
        }
        if(index == 0 )
        {
            newNode.Link= Head;
            Head = newNode;
            return;
        }
        if(index-1 == count)
        {
            newNode.Link = currentNode.Link;
            currentNode.Link = newNode; 
            return;
        }
        InsertAtWithRecursion(index,newNode,count+1,currentNode.Link);
    }
    public void ReverseWithRecursion(SingleNode<T> headNode,SingleNode<T> reversedNode)
    {
        if(headNode == null){
            Head = reversedNode;
            return;
        }
        SingleNode<T> newNode = new SingleNode<T>(){ Data = headNode.Data, Link = reversedNode };
        ReverseWithRecursion(headNode.Link,newNode);
    }
    public void TotalSumWithRecursion(SingleNode<T> traversalNode, int totalSum)
    {
        if(traversalNode ==null)
        {
            Console.WriteLine($"\nTotal sum is: {totalSum}");
            return;
        }
        TotalSumWithRecursion(traversalNode.Link, totalSum + Convert.ToInt32(traversalNode.Data));
    }
    public SingleNode<T> ZipperListWithRecursion(SingleNode<T> list1Head, SingleNode<T> list2Head)
    {
        if(list1Head == null && list2Head == null)
        {
            return null;
        }
        if(list1Head == null)
        {
            return list2Head;
        }
        if(list2Head == null)
        {
            return list1Head;
        }
        var list1next = list1Head.Link;
        var list2next = list2Head.Link;
        list1Head.Link = list2Head;
        list2Head.Link = ZipperListWithRecursion(list1next,list2next);
        return list1Head;
    }
    #endregion recursion ways
}