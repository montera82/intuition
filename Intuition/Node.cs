using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuition
{
    public class Node
    {
        public long data;
        public Node left, right;

        public Node(long data)
        {
            this.data = data;
            left = null;
            right = null;

        }
    }
}
