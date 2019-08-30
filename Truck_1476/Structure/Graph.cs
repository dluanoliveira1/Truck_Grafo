using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EP.DataStructure
{
    public class Graph : ICloneable
    {
        #region Properties

        public List<Node> Nodes { get; private set; }
        private Dictionary<string, Node> dictionary = new Dictionary<string, Node>();

        #endregion

        #region Constructors

        public Graph()
        {
            this.Nodes = new List<Node>();
        }

        public Graph(List<Node> nodes)
        {
            this.Nodes = nodes;
        }

        #endregion

        #region Methods

        public Node Find(string name)
        {
            if (dictionary.ContainsKey(name))
                    return dictionary[name];

            return this.Nodes.SingleOrDefault(p => p.Name == name);

        }

        public void AddNode(string name)
        {
            this.AddNode(name, 0);
        }

        public void AddNode(string name, double capacity)
        {
            if (Find(name) != null)
                throw new Exception("Já existe um nó com esse nome no grafo!!");

            Node aux = new Node(name, capacity);
            this.Nodes.Add(aux);
            dictionary.Add(name, aux);
        }

        public void AddNode(Node n)
        {
            this.Nodes.Add(n);
        }

        public void RemoveNode(string name)
        {
            Node n = Find(name);
            if (n == null)
                throw new Exception("Não existe um nó com este nome no grafo!!");
            this.Nodes.Remove(n);
        }

        public void AddEdge(string from, string to, double capacity)
        {
            Node f = Find(from);
            Node t = Find(to);
            if ((t != null) || (f != null))
                f.AddEdge(t, capacity);
        }

        public Node[] GetNeighbours(string from)
        {
            Node n = Find(from);
            if (n == null)
                throw new Exception("Não foi possível encontrar o nó no grafo!!");
            return n.Edges.Select(p => p.To).ToArray();
        }

        public void ClearVisited()
        {
            foreach (Node n in this.Nodes)
            {
                n.Parent = null;
                n.Visited = false;
            }
        }

        public bool AllVisited()
        {
            foreach (Node n in this.Nodes)
                if (!n.Visited)
                    return false;
            return true;
        }

        public bool FindPath(List<Node> nodes, string end)
        {
            foreach (Node n in nodes)
                if (n.Name == end) return true;
            return false;
        }

        public object Clone()
        {
            Node[] aux = new Node[this.Nodes.Count];
            this.Nodes.CopyTo(aux);
            return new Graph(aux.ToList());
        }

        #endregion

        #region Algorithms

        public List<Node> BreadthFirstSearch(string begin)
        {
            Node n = Find(begin);
            Queue<Node> queue = new Queue<Node>();
            List<Node> breadth = new List<Node>();

            ClearVisited();
            if (n != null)
            {
                queue.Enqueue(n);
                while (queue.Count() != 0)
                {
                    n = queue.Dequeue();
                    n.Visited = true;
                    breadth.Add(n);
                    foreach (Edge e in n.Edges)
                    {
                        if (e.To.Visited != true)
                        {
                            e.To.Visited = true;
                            e.To.Parent = n;
                            queue.Enqueue(e.To);
                        }
                    }
                }
            }
            else
                throw new Exception("Não foi possivel achar o nó inicial!!");

            return breadth;
        }//Passeio largura

        public List<Node> DepthFirstSearch(string begin)
        {
            Node n = Find(begin);
            Stack<Node> stack = new Stack<Node>();
            List<Node> depth = new List<Node>();

            ClearVisited();
            if (n != null)
            {
                stack.Push(n);
                while (stack.Count != 0)
                {
                    n = stack.Pop();
                    if (n.Visited != true)
                    {
                        n.Visited = true;
                        depth.Add(n);
                    }
                    foreach (Edge e in n.Edges)
                    {
                        if (e.To.Visited != true)
                        {
                            e.To.Parent = n;
                            stack.Push(e.To);
                        }
                    }
                }
            }
            else
                throw new Exception("Não foi possível localizar o nó inicial!!");

            return depth;
        }//Passeio profundidade

        public List<Node> BreadthNewOne(string begin, string end)
        {
            Node n = Find(begin);
            Node a = Find(end);
            Queue<Node> queue = new Queue<Node>();
            List<Node> breadth = new List<Node>();

            ClearVisited();
            if (n != null && a != null)
            {
                queue.Enqueue(n);
                while (n.Name != end)
                {
                    n = queue.Dequeue();
                    n.Visited = true;
                    breadth.Add(n);
                    foreach (Edge e in n.Edges)
                    {
                        if (e.To.Visited != true)
                        {
                            e.To.Visited = true;
                            e.To.Parent = n;
                            queue.Enqueue(e.To);
                        }
                    }
                }
            }
            else
                return null;

            return breadth;
        }//Passeio largura, até encontrar end. 

        public List<Node> Truck_MaxCapacity(string begin, string end)
        {
            List<Node> solution = new List<Node>();
            Node beginNode = Find(begin);
            Node endNode = Find(end);
            Node auxNode = null;
            Edge auxEdge = null;

            if (beginNode == null || endNode == null)
                return null;

            ClearVisited();
            solution.Add(new Node(beginNode.Name, double.MaxValue));
            beginNode.Visited = true;

            while ((solution.Exists(x => x.Name == end)) == false)
            {
                double maxCost = 0;
                foreach (Node node in solution)
                {
                    beginNode = this.Find(node.Name);
                    foreach (Edge edge in beginNode.Edges)
                    {
                        if (maxCost <= edge.Capacity && edge.To.Visited == false)
                        {
                            maxCost = edge.Capacity;
                            auxNode = node;
                            auxEdge = edge;
                        }
                    }
                }

                if (auxNode.NodeQty > auxEdge.Capacity)
                {
                    Node a = new Node(auxEdge.To.Name, auxEdge.Capacity);
                    a.Parent = auxNode;
                    solution.Add(a);
                }
                else
                {
                    Node b = new Node(auxEdge.To.Name, auxNode.NodeQty);
                    b.Parent = auxNode;
                    solution.Add(b);
                }
                auxEdge.To.Visited = true;
            }
            
            return solution;
        }///1ª Forma - Retorna capacidade máxima

        public List<Node> Truck_MaxCapacityList(string begin, string end, ref double maxCap)
        {
            maxCap = 0;
            List<Node> solution = Truck_MaxCapacity(begin, end);

            if (solution == null)
                return null;

            List<Node> result = new List<Node>();
            Node aux = solution.Find(x => x.Name == end);
            maxCap = aux.NodeQty;

            while(aux.Parent != null)
            {
                result.Add(aux);
                aux = aux.Parent;
            }
            result.Add(aux);

            result.Reverse();
            return result;
 
        }//1ª Forma - Retorna o caminho

        public List<Node> GetPath_ByParent(string begin, string end)
        {
            List<Node> nodes = BreadthNewOne(begin, end);
            List<Node> path = new List<Node>();

            Node n = nodes.Find(p => p.Name == begin);
            Node a = nodes.Find(p => p.Name == end);
            a.Parent = null;

            while (n.Parent != null)
            {
                foreach (Edge e in n.Edges)
                {
                    if (e.To == n.Parent)
                    {
                        path.Add(n);
                        n = n.Parent;
                    }
                }
            }

            return path;
        }//Buscar caminho.

        public Graph Max_MST(PriorityQueueEdge edd)
        {
            Graph mst = new Graph();
            PriorityQueueEdge edges = edd;

            while (!edges.IsEmpty())
            {
                Edge e = edges.Dequeue();
                Node n = this.Nodes.Find(p => p.Edges.Exists(q => q.To == e.To && q.From == e.From));
                Node a = mst.Find(n.Name);
                Node b = mst.Find(e.To.Name);

                if (a == null || b == null || !FindPath(mst.BreadthFirstSearch(a.Name), b.Name))
                {
                    if (a == null)
                        mst.AddNode(n.Name);
                    if (b == null)
                        mst.AddNode(e.To.Name);

                    mst.AddEdge(n.Name, e.To.Name, e.Capacity);
                    mst.AddEdge(e.To.Name, n.Name, e.Capacity);
                }
            }

            return mst;
        }//2ª Forma

        public List<Node> Truck_Solution(string source, string sink, List<Edge> edges, ref double maxTruckFlow)
        {
            List<Node> nodes = BreadthNewOne(source, sink);
            List<Node> path = new List<Node>();
            maxTruckFlow = double.MaxValue;

            if (Find(source) == null || Find(sink) == null)
                return null;

            Node n = nodes.Find(p => p.Name == sink);
            Node a = nodes.Find(p => p.Name == source);
            a.Parent = null;

            while (n.Parent != null)
            {
                foreach (Edge e in n.Edges)
                {
                    if (e.To == n.Parent)
                    {
                        edges.Add(e);
                        path.Add(n);
                        n = n.Parent;
                    }
                }
            }
            path.Add(n);

            foreach (Edge e in edges)
            {
                if (maxTruckFlow > e.Capacity)
                    maxTruckFlow = e.Capacity;
            }

            path.Reverse();
            return path.ToList();
        }//2ª Forma

        #endregion
    }
}
