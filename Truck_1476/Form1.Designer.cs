namespace Truck_1476
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.notificarError = new System.Windows.Forms.Button();
            this.radionotificarError = new System.Windows.Forms.RadioButton();
            this.calcularMax = new System.Windows.Forms.Button();
            this.radiocalcularMax = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radiocriarGrafo = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.criarGrafo = new System.Windows.Forms.Button();
            this.ClearById = new System.Windows.Forms.Button();
            this.LimparNot = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.calcularTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(647, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(191, 180);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // notificarError
            // 
            this.notificarError.Location = new System.Drawing.Point(754, 366);
            this.notificarError.Name = "notificarError";
            this.notificarError.Size = new System.Drawing.Size(75, 51);
            this.notificarError.TabIndex = 1;
            this.notificarError.Text = "Notificar";
            this.notificarError.UseVisualStyleBackColor = true;
            this.notificarError.Click += new System.EventHandler(this.notificarError_Click);
            // 
            // radionotificarError
            // 
            this.radionotificarError.AutoSize = true;
            this.radionotificarError.Location = new System.Drawing.Point(647, 354);
            this.radionotificarError.Name = "radionotificarError";
            this.radionotificarError.Size = new System.Drawing.Size(53, 17);
            this.radionotificarError.TabIndex = 2;
            this.radionotificarError.TabStop = true;
            this.radionotificarError.Text = "Obras";
            this.radionotificarError.UseVisualStyleBackColor = true;
            // 
            // calcularMax
            // 
            this.calcularMax.Location = new System.Drawing.Point(417, 440);
            this.calcularMax.Name = "calcularMax";
            this.calcularMax.Size = new System.Drawing.Size(75, 40);
            this.calcularMax.TabIndex = 3;
            this.calcularMax.Text = "Calcular";
            this.calcularMax.UseVisualStyleBackColor = true;
            this.calcularMax.Click += new System.EventHandler(this.calcularMax_Click);
            // 
            // radiocalcularMax
            // 
            this.radiocalcularMax.AutoSize = true;
            this.radiocalcularMax.Location = new System.Drawing.Point(647, 377);
            this.radiocalcularMax.Name = "radiocalcularMax";
            this.radiocalcularMax.Size = new System.Drawing.Size(63, 17);
            this.radiocalcularMax.TabIndex = 7;
            this.radiocalcularMax.TabStop = true;
            this.radiocalcularMax.Text = "Transito";
            this.radiocalcularMax.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(666, 308);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(759, 308);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(41, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Notificar Problemas na Via";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ponto A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(756, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ponto B";
            // 
            // radiocriarGrafo
            // 
            this.radiocriarGrafo.AutoSize = true;
            this.radiocriarGrafo.Location = new System.Drawing.Point(647, 400);
            this.radiocriarGrafo.Name = "radiocriarGrafo";
            this.radiocriarGrafo.Size = new System.Drawing.Size(67, 17);
            this.radiocriarGrafo.TabIndex = 13;
            this.radiocriarGrafo.TabStop = true;
            this.radiocriarGrafo.Text = "Acidente";
            this.radiocriarGrafo.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(647, 423);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(70, 17);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Comando";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Capacidade Máxima entre Pontos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ponto B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ponto A";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(475, 308);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(41, 20);
            this.textBox3.TabIndex = 17;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(382, 308);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(43, 20);
            this.textBox4.TabIndex = 16;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(328, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Capacidade = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(694, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Notificações";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(358, 51);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(191, 180);
            this.listView2.TabIndex = 21;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Tile;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(413, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Caminho";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(445, 366);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 20);
            this.label15.TabIndex = 35;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(38, 51);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(193, 254);
            this.textBox6.TabIndex = 38;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(89, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Criar Grafo";
            // 
            // criarGrafo
            // 
            this.criarGrafo.Location = new System.Drawing.Point(93, 322);
            this.criarGrafo.Name = "criarGrafo";
            this.criarGrafo.Size = new System.Drawing.Size(75, 38);
            this.criarGrafo.TabIndex = 40;
            this.criarGrafo.Text = "Criar";
            this.criarGrafo.UseVisualStyleBackColor = true;
            this.criarGrafo.Click += new System.EventHandler(this.criarGrafo_Click);
            // 
            // ClearById
            // 
            this.ClearById.Location = new System.Drawing.Point(726, 476);
            this.ClearById.Name = "ClearById";
            this.ClearById.Size = new System.Drawing.Size(74, 51);
            this.ClearById.TabIndex = 41;
            this.ClearById.Text = "Excluir\r\nNotifcação";
            this.ClearById.UseVisualStyleBackColor = true;
            this.ClearById.Click += new System.EventHandler(this.ClearById_Click);
            // 
            // LimparNot
            // 
            this.LimparNot.Location = new System.Drawing.Point(808, 476);
            this.LimparNot.Name = "LimparNot";
            this.LimparNot.Size = new System.Drawing.Size(78, 51);
            this.LimparNot.TabIndex = 42;
            this.LimparNot.Text = "Limpar\r\nTodas";
            this.LimparNot.UseVisualStyleBackColor = true;
            this.LimparNot.Click += new System.EventHandler(this.LimparNot_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(674, 492);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(43, 20);
            this.textBox5.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(613, 495);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Not. Indice\r\n";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(38, 408);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(193, 104);
            this.textBox7.TabIndex = 45;
            // 
            // calcularTodos
            // 
            this.calcularTodos.Location = new System.Drawing.Point(237, 440);
            this.calcularTodos.Name = "calcularTodos";
            this.calcularTodos.Size = new System.Drawing.Size(75, 40);
            this.calcularTodos.TabIndex = 46;
            this.calcularTodos.Text = "Calcular Todos";
            this.calcularTodos.UseVisualStyleBackColor = true;
            this.calcularTodos.Click += new System.EventHandler(this.calcularTodos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 539);
            this.Controls.Add(this.calcularTodos);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.LimparNot);
            this.Controls.Add(this.ClearById);
            this.Controls.Add(this.criarGrafo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radiocriarGrafo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radiocalcularMax);
            this.Controls.Add(this.calcularMax);
            this.Controls.Add(this.radionotificarError);
            this.Controls.Add(this.notificarError);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button notificarError;
        private System.Windows.Forms.Button calcularMax;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.RadioButton radionotificarError;
        private System.Windows.Forms.RadioButton radiocalcularMax;
        private System.Windows.Forms.RadioButton radiocriarGrafo;
        private System.Windows.Forms.RadioButton radioButton4;

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button criarGrafo;
        private System.Windows.Forms.Button ClearById;
        private System.Windows.Forms.Button LimparNot;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button calcularTodos;
    }
}

