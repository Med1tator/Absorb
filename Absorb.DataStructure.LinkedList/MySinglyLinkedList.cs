using System;
using System.Collections.Generic;
using System.Text;

namespace Absorb.DataStructure.LinkedList
{
    /// <summary>
    /// 单向链表
    /// </summary>
    public class MySinglyLinkedList
    {
        public MySinglyLinkedListNode Head { get; set; }
        public int Size { get; private set; }
        
        public void Add(object obj)
        {
            if (Head == null)
            {
                Head.Value = obj;
            }
            else
            {
                MySinglyLinkedListNode temp = Head;
                while (temp.Next!=null)
                {
                    temp = temp.Next;
                }
                temp.Value = obj;
            }

            Size++;
        }

    }
}
