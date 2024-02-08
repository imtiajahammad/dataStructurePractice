using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructurePractice.linkedList;

public class LinkedList
{

    public LinkedList()
    {
    //SingleNode<int> firstNode = new SingleNode<int>(){ Data = 10, Link = null};
    //SingleLinkedList<int> obj = new SingleLinkedList<int>();
    //obj.Traverse();
    //obj.AddFirst(firstNode);
    //SingleNode<int> secondNode = new SingleNode<int>(){ Data = 2, Link = null };
    //obj.AddLast(secondNode);
    //SingleNode<int> zeroNode = new SingleNode<int>(){ Data = 3, Link = null };
    //obj.AddFirst(zeroNode);
    //obj.Traverse();
    //obj.Find(2);
    //obj.Sort();
    //obj.Traverse();
    //obj.InsertAt(1,7);
    //obj.Traverse();
    //obj.TotalSum();
    //obj.TotalSumReversely();
    //obj.Traverse();
    //obj.Reverse();
    //obj.Traverse();
    
    SingleNode<int> tempNode3 = new SingleNode<int>(){ Data = 3, Link = null };
    SingleNode<int> tempNode2 = new SingleNode<int>(){ Data = 2, Link = tempNode3 };
    SingleNode<int> tempNode1 = new SingleNode<int>(){ Data = 1, Link = tempNode2 };

    SingleNode<int> tempNode9 = new SingleNode<int>(){ Data = 9, Link = null };
    SingleNode<int> tempNode8 = new SingleNode<int>(){ Data = 8, Link = tempNode9 };
    SingleNode<int> tempNode7 = new SingleNode<int>(){ Data = 7, Link = tempNode8 };

    SingleLinkedList<int> tempTest = new SingleLinkedList<int>();
    //SingleNode<int> result = tempTest.ZipperList(tempNode1,tempNode7);
    //tempTest.Head = result;
    //tempTest.Traverse();

    SingleLinkedList<int> tempTest2 = new SingleLinkedList<int>(){ Head = tempNode1 };
    //tempTest2.TraverseWithRecursion(tempTest2.Head);

    SingleNode<int> singleNode = new SingleNode<int>(){ Data = 77, Link = null };
    //tempTest2.AddFirstWithRecursion(singleNode);

    SingleNode<int> singleNode2 = new SingleNode<int>(){ Data = 88, Link = null };
    //tempTest2.AddLastWithRecursion(singleNode2,tempTest2.Head);
    //tempTest2.TraverseWithRecursion(tempTest2.Head);


    //tempTest2.FindWithRecursion(89, tempTest2.Head);

    SingleLinkedList<int> firstNodeForResursionTest = new SingleLinkedList<int>();
    firstNodeForResursionTest.AddLast(new SingleNode<int>() { Data = 2, Link = null});
    firstNodeForResursionTest.AddLast(new SingleNode<int>() { Data = 7, Link = null});
    firstNodeForResursionTest.AddLast(new SingleNode<int>() { Data = 5, Link = null});
    firstNodeForResursionTest.AddLast(new SingleNode<int>() { Data = 1, Link = null});
    //firstNodeForResursionTest.SortWithRecursion(firstNodeForResursionTest.Head);

    //firstNodeForResursionTest.InsertAtWithRecursion(1,new SingleNode<int>(){Data=0,Link=null},0,firstNodeForResursionTest.Head);
    
    //firstNodeForResursionTest.ReverseWithRecursion(firstNodeForResursionTest.Head, null);
    //firstNodeForResursionTest.Traverse();


    //firstNodeForResursionTest.TotalSumWithRecursion(firstNodeForResursionTest.Head,0);

    
    
    SingleNode<int> tempNodeFor3 = new SingleNode<int>(){ Data = 3, Link = null };
    SingleNode<int> tempNodeFor2 = new SingleNode<int>(){ Data = 2, Link = tempNodeFor3 };
    SingleNode<int> tempNodeFor1 = new SingleNode<int>(){ Data = 1, Link = tempNodeFor2 };

    SingleNode<int> tempNodeFor9 = new SingleNode<int>(){ Data = 9, Link = null };
    SingleNode<int> tempNodeFor8 = new SingleNode<int>(){ Data = 8, Link = tempNodeFor9 };
    SingleNode<int> tempNodeFor7 = new SingleNode<int>(){ Data = 7, Link = tempNodeFor8 };

    SingleLinkedList<int> demoForTestZipperList = new SingleLinkedList<int>(){ Head =tempNode1};
    demoForTestZipperList.ZipperListWithRecursion(demoForTestZipperList.Head,tempNodeFor7);
    demoForTestZipperList.TraverseWithRecursion(demoForTestZipperList.Head);

    }
    
}