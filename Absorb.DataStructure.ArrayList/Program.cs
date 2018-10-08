using System;

namespace Absorb.DataStructure.ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();
            list.Add(0); list.Add(1); list.Add(2); list.Add(3); list.Add(4); list.Add(5); list.Add(6); list.Add(7); list.Add(8); list.Add(9);

            Console.WriteLine(list.Get(4));

            list.Set(2, 12);

            list.RemoveAt(6);
            list.RemoveAt(6);
            Console.WriteLine(list.Get(list.Size));
            for (int i = 0; i < list.Size; i++)
            {
                Console.WriteLine(list.Get(i));
            }

            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }
}
