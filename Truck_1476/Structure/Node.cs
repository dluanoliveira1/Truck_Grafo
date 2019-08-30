using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.DataStructure
{
    public class Node
    {
        #region Properties
       
        public string Name { get; set; }
        public object Info { get; set; }
        public bool Visited { get; set; }
        public Double NodeQty { get; set; }
        public Node Parent { get; set; }
        public List<Edge> Edges { get; private set; }

        #endregion

        #region Constructors

        public Node()
        {
            this.Edges = new List<Edge>();
        }

        public Node(string name) : this()
        {
            this.Name = name;
        }
 
        public Node(string name, double nodeQty) : this(name)
        {
            this.NodeQty = nodeQty;
        }

        #endregion

        #region Methods

        public void AddEdge (Node to, double capacity)
        {
            this.Edges.Add(new Edge(this, to, capacity));
        }

        public void AddEdge (Node to)
        {
            this.AddEdge(to, 0);
        }

        #endregion

        public override string ToString()
        {
            if (this.Info != null)
            {
                return String.Format("{0}({1})", this.Name, this.Info);
            }
            return this.Name;
        }
    }
}
