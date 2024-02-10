using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructurePractice.linkedList;

public class DoublyNode<T>
{
    public T Data { get; set; }
    public DoublyNode<T>? PreviousLink { get; set; }
    public DoublyNode<T>? NextLink { get; set; }
}
