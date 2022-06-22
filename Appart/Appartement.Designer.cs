namespace Appart
{
    partial class Appartement
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dsctxt = new System.Windows.Forms.TextBox();
            this.nomtxt = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(670, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 732);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(145, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 32);
            this.label12.TabIndex = 15;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nom,
            this.Column3,
            this.Column4,
            this.statut1,
            this.statut2});
            this.dataGridView1.Location = new System.Drawing.Point(29, 413);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(647, 159);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.Name = "nom";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "description";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "zone";
            this.Column4.Name = "Column4";
            // 
            // statut1
            // 
            this.statut1.HeaderText = "statut1";
            this.statut1.Name = "statut1";
            // 
            // statut2
            // 
            this.statut2.HeaderText = "statut2";
            this.statut2.Name = "statut2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.dsctxt);
            this.panel2.Controls.Add(this.nomtxt);
            this.panel2.Location = new System.Drawing.Point(76, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 155);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zone";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 31);
            this.button3.TabIndex = 13;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Zone 1",
            "Zone 2",
            "Zone 3",
            "Zone 4",
            "Zone 5"});
            this.comboBox1.Location = new System.Drawing.Point(72, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dsctxt
            // 
            this.dsctxt.Location = new System.Drawing.Point(292, 44);
            this.dsctxt.Name = "dsctxt";
            this.dsctxt.Size = new System.Drawing.Size(162, 22);
            this.dsctxt.TabIndex = 1;
            // 
            // nomtxt
            // 
            this.nomtxt.Location = new System.Drawing.Point(72, 44);
            this.nomtxt.Name = "nomtxt";
            this.nomtxt.Size = new System.Drawing.Size(154, 22);
            this.nomtxt.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Démarrer",
            "Eteindre"});
            this.comboBox3.Location = new System.Drawing.Point(368, 276);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(162, 24);
            this.comboBox3.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Connecte",
            "Deconnecte"});
            this.comboBox2.Location = new System.Drawing.Point(148, 276);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 24);
            this.comboBox2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Statut 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Statut 1";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(12, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(183, 182);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chambre";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(213, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(171, 182);
            this.panel7.TabIndex = 1;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cuisine";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(402, 20);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(168, 182);
            this.panel8.TabIndex = 2;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Salle de bain";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(70, 231);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 186);
            this.panel9.TabIndex = 3;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(65, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sallon";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.label10);
            this.panel10.Location = new System.Drawing.Point(314, 231);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(201, 186);
            this.panel10.TabIndex = 4;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(60, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Chambre";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(32, 123);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(585, 449);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(-2, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 732);
            this.panel3.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SteelBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(215, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Appartement";
            // 
            // Appartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 728);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Appartement";
            this.Text = "Appartement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox dsctxt;
        private System.Windows.Forms.TextBox nomtxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
    }
}

