using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EP.DataStructure;

namespace Truck_1476
{
    public partial class Form1 : Form
    {
        Graph g = new Graph();
        Graph gaux = new Graph();
        Graph gp;


        private PriorityQueueEdge edgePr = new PriorityQueueEdge();
        static int count = 1;
        static int graphCreated = 0;

        public Form1()
        {
            InitializeComponent();
        }

        #region Buttoms

        private void notificarError_Click(object sender, EventArgs e)
        {
            if (graphCreated == 1)
            {
                string pontoA = textBox1.Text;
                string pontoB = textBox2.Text;
                int auxCount = 0;

                Node a = g.Find(pontoA);

                if (radionotificarError.Checked || radiocalcularMax.Checked || radiocriarGrafo.Checked || radioButton4.Checked)
                {
                    if (g.Find(pontoA) != null && g.Find(pontoB) != null)
                    {
                        foreach (Edge ed in a.Edges)
                        {
                            if (ed.To.Name == pontoB)
                            {
                                ed.Capacity = 0;

                                foreach (Edge edd in ed.To.Edges)
                                {
                                    if (edd.To.Name == pontoA)
                                    {
                                        edd.Capacity = 0;
                                        auxCount = 1;
                                    }
                                }

                                if (radionotificarError.Checked)
                                    listView1.Items.Add(count + "." + ed.ToString("Obras"));

                                if (radiocalcularMax.Checked)
                                    listView1.Items.Add(count + "." + ed.ToString("Transito"));

                                if (radiocriarGrafo.Checked)
                                    listView1.Items.Add(count + "." + ed.ToString("Acidente"));

                                if (radioButton4.Checked)
                                    listView1.Items.Add(count + "." + ed.ToString("Comando"));

                                count++;
                                ClearPath();
                                textBox1.Text = "";
                                textBox2.Text = "";
                            }
                        }

                        if (auxCount == 0)
                            MessageBox.Show("Pontos não estão conectados", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Pontos não encotrados", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Escolha o problema encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Primeiramente crie o Mapa (Grafo)", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void calcularMax_Click(object sender, EventArgs e)
        {
            if (graphCreated == 1)
            {
                if (textBox3.Text != "" && textBox4.Text != "")
                {
                    listView2.Items.Clear();
                    if (listView1.Items.Count > 0)
                    {
                        double maxTrcukFlow = 0;
                        List<Node> ns = g.Truck_MaxCapacityList(textBox4.Text, textBox3.Text, ref maxTrcukFlow);

                        if (ns != null)
                        {
                            label15.Text = maxTrcukFlow.ToString();
                            foreach (Node n in ns)
                            {
                                listView2.Items.Add("Go => " + n.Name);
                            }
                        }
                        else
                            MessageBox.Show("Pontos não encotrados", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        double maxTruckFlow = 0;
                        List<Edge> ed = new List<Edge>();
                        List<Node> list = gp.Truck_Solution(textBox4.Text, textBox3.Text, ed, ref maxTruckFlow);

                        if (list == null)
                            MessageBox.Show("Pontos não encotrados", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        else
                        {
                            ClearPath();
                            label15.Text = maxTruckFlow.ToString();
                            foreach (Node st in list)
                            {
                                listView2.Items.Add("Go => " + st.Name);
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Digite os valores", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Primeiramente crie o Mapa (Grafo)", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void criarGrafo_Click(object sender, EventArgs e)
        {
            g = new Graph();
            gaux = new Graph();

            string[] entrada = textBox6.Text.Split('\n');
            string[] entrada1 = entrada[0].Split('\r');
            string[] entrada2 = entrada1[0].Split();

            int in_Nodes = Convert.ToInt32(entrada2[0]);
            int in_Edges = Convert.ToInt32(entrada2[1]);
            int in_Sedes = Convert.ToInt32(entrada2[2]);

            for (int i = 1; i <= in_Nodes; i++)
            {
                g.AddNode(i.ToString());
                gaux.AddNode(i.ToString());
            }

            if (entrada.Count() - 1 == in_Edges)
            {
                int count = 0;
                foreach (string x in entrada)
                {
                    if (count == 1)
                    {
                        string[] entrada3 = x.Split('\r');
                        string[] entrada4 = entrada3[0].Split();
                        Edge e1 = new Edge(g.Find(entrada4[0]), g.Find(entrada4[1]), Convert.ToDouble(entrada4[2]));
                        Edge e2 = new Edge(g.Find(entrada4[0]), g.Find(entrada4[1]), Convert.ToDouble(entrada4[2]));

                        if (e1 != null && e2 != null)
                        {
                            g.AddEdge(entrada4[0], entrada4[1], Convert.ToDouble(entrada4[2]));
                            g.AddEdge(entrada4[1], entrada4[0], Convert.ToDouble(entrada4[2]));
                            gaux.AddEdge(entrada4[0], entrada4[1], Convert.ToDouble(entrada4[2]));
                            gaux.AddEdge(entrada4[1], entrada4[0], Convert.ToDouble(entrada4[2]));
                            edgePr.Enqueue(new Edge(g.Find(entrada4[0]), g.Find(entrada4[1]), Convert.ToDouble(entrada4[2])));
                            edgePr.Enqueue(new Edge(g.Find(entrada4[1]), g.Find(entrada4[0]), Convert.ToDouble(entrada4[2])));
                        }

                        else
                        {
                            MessageBox.Show("Não foram encontrados os Pontos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBox6.Text = "";
                            break;
                        }

                    }

                    if (count == 0)
                        count = 1;
                }
                gp = g.Max_MST(edgePr);
                textBox6.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                listView1.Items.Clear();
                ClearPath();
                graphCreated = 1;
                MessageBox.Show("Grafo Criado com Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Entrada errada para Criação do Mapa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void calcularTodos_Click(object sender, EventArgs e)
        {
            if(graphCreated == 1 &&  textBox7.Text != "")
            {
                ClearPath();
                string[] ent = textBox7.Text.Split('\n');
                foreach (string x in ent)
                {
                    string[] ent1 = x.Split('\r');
                    string[] ent2 = ent1[0].Split();

                    double maxTruckFlow = 0;
                    List<Edge> ed = new List<Edge>();
                    List<Node> list = g.Truck_MaxCapacityList(ent2[0], ent2[1], ref maxTruckFlow); 

                    if (list == null)
                        MessageBox.Show("Pontos não encotrados", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    else
                    {
                        foreach (Node st in list)
                        {
                            listView2.Items.Add("Go => " + st.Name);
                        }
                        listView2.Items.Add("Capacidade Máxima: " +  maxTruckFlow.ToString());
                    }
                    listView2.Items.Add("____________________________");
                }
                textBox7.Text = "";
            }
        }

        #endregion

        #region Methods

        private void ClearPath()
        {
            listView2.Items.Clear();
            textBox3.Text = "";
            textBox4.Text = "";
            label15.Text = "";
        }

        private void LimparNot_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ClearPath();
            count = 1;
            foreach (Node nodes in gaux.Nodes)
            {
                foreach (Edge ed in nodes.Edges)
                {
                    edgePr.Enqueue(ed);
                }
            }
            g = gaux.Max_MST(edgePr);
        }

        private void ClearById_Click(object sender, EventArgs e)
        {
            ClearPath();
            textBox1.Text = "";
            textBox2.Text = "";
            int indice = Convert.ToInt32(textBox5.Text);
            string x = listView1.Items[indice - 1].ToString();
            string[] nameNode = x.Split();

            string noddeA = nameNode[4];
            string noddeB = nameNode[9];

            Node a = g.Find(noddeA);
            
            foreach(Edge eg in a.Edges)
            {
                if (eg.To.Name == noddeB)
                    eg.Capacity = eg.auxCapacity;
            }
            listView1.Items.RemoveAt(indice - 1);
            textBox5.Text = "";
        }

        #endregion

        #region KeyPress

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) && e.KeyChar != 32)
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                e.Handled = true;
        }


        #endregion

    }
}

