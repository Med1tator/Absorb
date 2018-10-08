using System;
using System.Collections.Generic;
using System.Text;

namespace Absorb.DataStructure.LinkedList
{
    public class MySinglyLinkedListNode
    {
        public object Value { get; set; }
        public MySinglyLinkedListNode Next { get; set; }

        public MySinglyLinkedListNode()
        { }

        public MySinglyLinkedListNode(object obj)
        {
            Value = obj;
        }
    }
}
