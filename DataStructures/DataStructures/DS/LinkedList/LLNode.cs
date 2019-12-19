using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DS.LinkedList
{
    public class LLNode<T>
    {
        public T Data { get; set; }
        public LLNode<T> Next { get; set; }
        public LLNode(T value)
        {
            Data = value;
        }
    }
}
