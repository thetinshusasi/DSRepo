using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DS.LinkedList
{
    public class CustomLinkedList<T> : ICollection<T>
    {
        public LLNode<T> Head { get; set; }

        public LLNode<T> Tail { get; set; }

        public int Count { get; private set; }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }


        public void AddToFirst(T value)
        {
            var node = new LLNode<T>(value);
            node.Next = Head;
            Head = node;
            Count++;
            if (Count == 1)
            {
                Tail = node;
            }
        }
        public void AddToLast(T value)
        {
            var node = new LLNode<T>(value);

            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            Count++;
        }

        public void RemoveFromFirst()
        {

            if (Count == 0)
            {
                Console.WriteLine("No elements to remove");

            }
            else
            {
                Count--;
                Head = Head.Next;
                if (Count == 0)
                {
                    Tail = null;
                }
            }
        
        }
        public void RemoveFromLast()
        {
            if (Count == 0)
            {
                Console.WriteLine("No elements to remove");

            }
            else
            {
                Count--;
                if (Count == 0)
                {
                    Head = Tail = null;
                }
                else
                {
                    var currNode = Head;
                    while(currNode.Next!= Tail)
                    {
                        currNode = currNode.Next;
                    }
                    currNode.Next = null;
                    Tail = currNode;
                }
            }
        }

        public void Add(T item)
        {
            AddToFirst(item);
        }

        public void Clear()
        {
            Head = Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void PrintLinkedList()
        {
            var current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ==> ");
                current = current.Next;
            }
            Console.Write("null");
        }


        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
        }



    }
}
