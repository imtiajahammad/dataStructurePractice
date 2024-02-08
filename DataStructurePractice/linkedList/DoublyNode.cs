using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructurePractice.linkedList;

public class DoublyNode<T>
{
    public T Data { get; set; }
    public SingleNode<T>? PreviousLink { get; set; }
    public SingleNode<T>? NextLink { get; set; }
}
