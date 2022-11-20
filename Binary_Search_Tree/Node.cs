using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> leftNode;
        public Node<T> rightNode;

        public Node(T data)
        {
            Data = data;
        }
    }
}
