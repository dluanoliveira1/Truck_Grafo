using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.DataStructure
{
    public class PriorityQueueEdge
    {
        #region Properties

        /// <summary>
        /// Lista ligada que será usada como fila
        /// </summary>
        private LinkedList<Edge> Queue = new LinkedList<Edge>();

        #endregion

        #region Methods

        public bool IsEmpty()
        {
            return Queue.Count == 0;
        }
        
        public void Enqueue(Edge e)
        {
            if (this.IsEmpty())
                Queue.AddFirst(e);

            else if (e.Capacity < Queue.ElementAt(0).Capacity)
                Queue.AddFirst(e);

            else if (e.Capacity > Queue.ElementAt(Queue.Count - 1).Capacity)
                Queue.AddLast(e);

            else
            {
                int i = GetIndex(e.Capacity, 0, Queue.Count - 1);
                
                if (i >= Queue.Count)
                    i = Queue.Count - 1;

                Edge aux = Queue.ElementAt(i);
                Queue.AddBefore(Queue.Find(aux), e);
            }
        }

        public int GetIndex(double v, int begin, int end)
        {
            int i = (begin + end) / 2;
            double p = Queue.ElementAt(i).Capacity;

            if (p == v)
                return i;

            if (begin == end)

                if (v > p)
                    return i + 1;
                else
                    return i;

            if (end < begin)
                return end + 1;

            else
            {
                if (p < v)
                    return GetIndex(v, i + 1, end);
                else
                    return GetIndex(v, begin, i - 1);
            }
        }

        public Edge Dequeue()
        {
            if (!this.IsEmpty())
            {
                Edge e = Queue.Last();
                Queue.RemoveLast();
                return e;
            }
            throw new Exception("Fila vazia!!");
        }

        public int Count()
        {
            return Queue.Count();
        }

        public Edge Peek()
        {
            return Queue.First();
        }

        #endregion

    }
}
