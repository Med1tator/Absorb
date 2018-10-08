using System;
using System.Collections.Generic;
using System.Text;

namespace Absorb.DataStructure.ArrayList
{
    /// <summary>
    /// 数组集合
    /// </summary>
    public class MyArrayList
    {
        object[] objs = new object[4];
        public int Size { get; private set; }

        public void Add(object obj)
        {
            if (Size >= objs.Length)
            {
                object[] temp = new object[Size * 3 / 2 + 1];
                for (int i = 0; i < Size; i++)
                {
                    temp[i] = objs[i];
                }
                objs = temp;
            }
            objs[Size] = obj;
            Size++;
        }

        public void Set(int index, object obj)
        {
            if (index < 0 || index >= Size)
            {
                throw new IndexOutOfRangeException();
            }

            objs[index] = obj;
        }

        public object Get(int index)
        {
            if (index < 0 || index >= Size)
            {
                throw new IndexOutOfRangeException();
            }

            return objs[index];
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Size)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < Size-1; i++)
            {
                objs[i] = objs[i + 1];
            }
            Size--;
        }

        public void Clear()
        {
            Size = 0;
            objs = new object[4];
        }
    }
}
