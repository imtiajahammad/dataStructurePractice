using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructurePractice.linkedList;

public class SingleNode<T>
{
    public T Data { get; set; }
    public SingleNode<T>? Link { get; set; }
}
