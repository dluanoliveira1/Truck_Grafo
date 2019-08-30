using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.DataStructure
{
    /// <summary>
    /// Arco não direcionado
    /// </summary>
    public class Edge
    {
        #region Properties

        public Node To { get; private set; }
        public Node From { get; private set; }
        public double Capacity { get; set; }
        public double auxCapacity { get; set; }
        public object Info { get; set; }

        #endregion

        #region Constructors

        public Edge(Node from, Node to, double capacity)
        {
            this.From = from;
            this.To = to;
            this.Capacity = capacity;
            this.auxCapacity = capacity;
        }

        public Edge(Node from, Node to) : this(from, to, 0) { }

        #endregion

        public string ToString(string problem)
        {
            return String.Format(" ( Via {0} ) ={1}=> ( Via {2} )", this.From, problem, this.To);
        }
    }
}
