using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Appart
{
    public partial class Appartement : Form
    {
        int currRowIndex;
        public Appartement()
        {   
            InitializeComponent();
            load();
            button3.Click += new System.EventHandler(ClickedButton);
            
        }

        string parametres = "SERVER=127.0.0.1; DATABASE=appart; UID=root; PASSWORD=";
        private MySqlConnection maconnexion;
        private object txtrowid;
        private string button3WasClicked = "non";
        private int width;

        private void ClickedButton(object sender, EventArgs e)
        {
            button3WasClicked = "oui";
        }




    private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(nomtxt.Text) || string.IsNullOrEmpty(dsctxt.Text) || string.IsNullOrEmpty(comboBox1.Text))
            {
                DialogResult dialogClose = MessageBox.Show("Remplir tous les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                
                string nom = nomtxt.Text;
                string description = dsctxt.Text;
                Objet o = new Objet(nom, description, comboBox1.Text, "Déconnecté", "Eteinte"); //insert lign in database
                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();
                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "SELECT id,nomzone FROM zone where nomzone = @zone";
                cmd.Parameters.AddWithValue("@zone", o.zone);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                String[] zone = new String[2];
                int i = 0;
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        zone[i] = item.ToString();
                        i++;
                    }
                }

                if(zone.Length < 2)
                {
                    zone[0] = "1";
                }
                
                cmd = maconnexion.CreateCommand();
                cmd.CommandText = "INSERT INTO objet (nom,description,zone,statut1,statut2,id_zone)" + "VALUES(@nom,@description,@zone,@statut1,@statut2,@id_zone)";
                cmd.Parameters.AddWithValue("@nom", o.nom);
                cmd.Parameters.AddWithValue("@description", o.description);
                cmd.Parameters.AddWithValue("@zone", o.zone);
                cmd.Parameters.AddWithValue("@statut1", o.statut1);
                cmd.Parameters.AddWithValue("@statut2", o.statut2);
                cmd.Parameters.AddWithValue("@id_zone", zone[0]);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO objet (nom,description,zone,statut1,statut2)" + "VALUES(@nom,@description,@zone,@statut1,@statut2)";
                maconnexion.Close();
                
                load();
                panel5.Refresh();

            }
        }

        private void load()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            //listView.View = View.Details;
            //listView.GridLines = true;
            MySqlConnection maconnexion = new MySqlConnection(parametres);
            maconnexion.Open();
            string sql = "Select id, nom, description, zone, statut1, statut2 from objet";
            MySqlCommand cmd = new MySqlCommand(sql, maconnexion); 
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dataTable=new DataTable();
            da.Fill(dataTable);
            

            int i;
            String[] myArray = new String[6];
            foreach (DataRow dataRow in dataTable.Rows)
            {
                
                i = 0;
                foreach (var item in dataRow.ItemArray)
                {
                    myArray[i] = item.ToString();
                    i++;
                }
                dataGridView1.Rows.Add(myArray[0], myArray[1], myArray[2], myArray[3], myArray[4], myArray[5]);
            }
            maconnexion.Close();
        }
    
        /*private void panel_Paint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            var g = e.Graphics;

            g.FillRectangle(new SolidBrush(Color.FromArgb(0, Color.Black)), p.DisplayRectangle);

            Point[] points = new Point[4];

            points[0] = new Point(Width, Height);
            points[1] = new Point(Width, p.Height - p.Height / 5);
            points[2] = new Point(p.Width - p.Width / 5, p.Height - p.Height / 5);
            points[3] = new Point(p.Width - p.Width / 5, Height);

            Brush brush = new SolidBrush(Color.Red);

            g.FillPolygon(brush, points);
        }*/

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            MySqlConnection maconnexion = new MySqlConnection(parametres);
            maconnexion.Open();
            string sql = "Select statut1, statut2 from objet where zone= 'Zone 1';";
            MySqlCommand cmd = new MySqlCommand(sql, maconnexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            int i;
            var p = sender as Panel;
            var g = e.Graphics;
            String[] myArray = new String[6];

            g.FillRectangle(new SolidBrush(Color.FromArgb(0, Color.Black)), p.DisplayRectangle);

            Point[] points = new Point[4];
            //if()
            Brush brush = new SolidBrush(Color.Red);
            i = 0;
            string stat1, stat2;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                stat1 = dataRow.ItemArray[0].ToString();
                stat2 = dataRow.ItemArray[1].ToString();
                Debug.WriteLine(stat1);
                if (stat1.Equals("Connecte"))
                {
                    brush = new SolidBrush(Color.Green);
                }
                else
                {
                    brush = new SolidBrush(Color.Red);
                }

                points[0] = new Point(0 + i * width / 10, 0 + i * Height / 10);
                points[1] = new Point(0 + i * width / 10, 20 + i * Height / 10);
                points[2] = new Point(20 + i * width / 10, 20 + i * Height / 10);
                points[3] = new Point(20 + i * width / 10, 0 + i * Height / 10);
                Debug.WriteLine(i);
                g.FillPolygon(brush, points);
                ++i;
            }
            g.FillRectangle(new SolidBrush(Color.FromArgb(0, Color.Black)), p.DisplayRectangle);
            g.FillPolygon(brush, points);
            maconnexion.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                nomtxt.Text = row.Cells[0].Value.ToString();
                dsctxt.Text = row.Cells[1].Value.ToString();
                comboBox1.Text = row.Cells[2].Value.ToString();
            }
            //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //currRowIndex = Convert.ToInt32(row.Cells[0].Value);

        }

        private void label12_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*DataGridViewRow row = dataGridView1.CurrentRow;
            if (!row.IsNewRow)
            {
                string c1 = row.Cells["id"].Value.ToString();
                string c2 = row.Cells["nom"].Value.ToString();
                label12.Text = c2;
            }*/
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            currRowIndex = Convert.ToInt32(row.Cells[0].Value);
            nomtxt.Text = row.Cells[1].Value.ToString();
            dsctxt.Text = row.Cells[2].Value.ToString();
            comboBox1.Text = row.Cells[3].Value.ToString();
            comboBox2.Text = row.Cells[4].Value.ToString();
            comboBox3.Text = row.Cells[5].Value.ToString();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            MySqlConnection maconnexion = new MySqlConnection(parametres);
            maconnexion.Open();
            string sql = "Select statut1, statut2 from objet where zone= 'Zone 2';";
            MySqlCommand cmd = new MySqlCommand(sql, maconnexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            int i;
            var p = sender as Panel;
            var g = e.Graphics;
            String[] myArray = new String[6];

            g.FillRectangle(new SolidBrush(Color.FromArgb(0, Color.Black)), p.DisplayRectangle);

            Point[] points = new Point[4];
            //if()
            Brush brush = new SolidBrush(Color.Red);
            i = 0;
            string stat1, stat2;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                stat1 = dataRow.ItemArray[0].ToString();
                stat2 = dataRow.ItemArray[1].ToString();
                Debug.WriteLine(stat1);
                if (stat1.Equals("Connecte"))
                {
                    brush = new SolidBrush(Color.Green);
                }
                else
                {
                    brush = new SolidBrush(Color.Red);
                }

                points[0] = new Point(0 + i * width / 10, 0 + i * Height / 10);
                points[1] = new Point(0 + i * width / 10, 20 + i * Height / 10);
                points[2] = new Point(20 + i * width / 10, 20 + i * Height / 10);
                points[3] = new Point(20 + i * width / 10, 0 + i * Height / 10);
                Debug.WriteLine(i);
                g.FillPolygon(brush, points);
                ++i;
            }
            g.FillRectangle(new SolidBrush(Color.FromArgb(0, Color.Black)), p.DisplayRectangle);
            g.FillPolygon(brush, points);
            maconnexion.Close();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            MySqlConnection maconnexion = new MySqlConnection(parametres);
            maconnexion.Open();
            string sql = "Select statut1, statut2 from objet where zone= 'Zone 3';";
            MySqlCommand cmd = new MySqlCommand(sql, maconnexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            int i;
            var p = sender as Panel;
            var g = e.Graphics;
            String[] myArray = new String[6];

            g.FillRectangle(new SolidBrush(Color.FromArgb(0, Color.Black)), p.DisplayRectangle);

            Point[] points = new Point[4];
            //if()
            Brush brush = new SolidBrush(Color.Red);
            i = 0;
            string stat1, stat2;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                stat1 = dataRow.ItemArray[0].ToString();
                stat2 = dataRow.ItemArray[1].ToString();
                Debug.WriteLine(stat1);
                if (stat1.Equals("Connecte"))
                {
                    brush = new SolidBrush(Color.Green);
                }
                else
                {
                    brush = new SolidBrush(Color.Red);
                }

                points[0] = new Point(0 + i * width / 10, 0 + i * Height / 10);
                points[1] = new Point(0 + i * width / 10, 20 + i * Height / 10);
                points[2] = new Point(20 + i * width / 10, 20 + i * Height / 10);
                points[3] = new Point(20 + i * width / 10, 0 + i * Height / 10);
                Debug.WriteLine(i);
                g.FillPolygon(brush, points);
                ++i;
            }
            g.FillRectangle(new SolidBrush(Color.FromArgb(0, Color.Black)), p.DisplayRectangle);
            g.FillPolygon(brush, points);
            maconnexion.Close();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            MySqlConnection maconnexion = new MySqlConnection(parametres);
            maconnexion.Open();
            string sql = "Select statut1, statut2 from objet where zone= 'Zone 4';";
            MySqlCommand cmd = new MySqlCommand(sql, maconnexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            int i;
            var p = sender as Panel;
            var g = e.Graphics;
            String[] myArray = new String[6];

            g.FillRectangle(new SolidBrush(Color.FromArgb(0, Color.Black)), p.DisplayRectangle);

            Point[] points = new Point[4];
            //if()
            Brush brush = new SolidBrush(Color.Red);
            i = 0;
            string stat1, stat2;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                stat1 = dataRow.ItemArray[0].ToString();
                stat2 = dataRow.ItemArray[1].ToString();
                Debug.WriteLine(stat1);
                if (stat1.Equals("Connecte"))
                {
                    brush = new SolidBrush(Color.Green);
                }
                else
                {
                    brush = new SolidBrush(Color.Red);
                }

                points[0] = new Point(0 + i * width / 10, 0 + i * Height / 10);
                points[1] = new Point(0 + i * width / 10, 20 + i * Height / 10);
                points[2] = new Point(20 + i * width / 10, 20 + i * Height / 10);
                points[3] = new Point(20 + i * width / 10, 0 + i * Height / 10);
                Debug.WriteLine(i);
                g.FillPolygon(brush, points);
                ++i;
            }
            g.FillRectangle(new SolidBrush(Color.FromArgb(0, Color.Black)), p.DisplayRectangle);
            g.FillPolygon(brush, points);
            maconnexion.Close();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            MySqlConnection maconnexion = new MySqlConnection(parametres);
            maconnexion.Open();
            string sql = "Select statut1, statut2 from objet where zone= 'Zone 5';";
            MySqlCommand cmd = new MySqlCommand(sql, maconnexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            int i;
            var p = sender as Panel;
            var g = e.Graphics;
            String[] myArray = new String[6];

            g.FillRectangle(new SolidBrush(Color.FromArgb(0, Color.Black)), p.DisplayRectangle);

            Point[] points = new Point[4];
            //if()
            Brush brush = new SolidBrush(Color.Red);
            i = 0;
            string stat1, stat2;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                stat1 = dataRow.ItemArray[0].ToString();
                stat2 = dataRow.ItemArray[1].ToString();
                Debug.WriteLine(stat1);
                if (stat1.Equals("Connecte"))
                {
                    brush = new SolidBrush(Color.Green);
                }
                else
                {
                    brush = new SolidBrush(Color.Red);
                }

                points[0] = new Point(0 + i * width / 10, 0 + i * Height / 10);
                points[1] = new Point(0 + i * width / 10, 20 + i * Height / 10);
                points[2] = new Point(20 + i * width / 10, 20 + i * Height / 10);
                points[3] = new Point(20 + i * width / 10, 0 + i * Height / 10);
                Debug.WriteLine(i);
                g.FillPolygon(brush, points);
                ++i;
            }
            g.FillRectangle(new SolidBrush(Color.FromArgb(0, Color.Black)), p.DisplayRectangle);
            g.FillPolygon(brush, points);
            maconnexion.Close();
        }

        /*private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                nomtxt.Text = row.Cells[0].Value.ToString();
                dsctxt.Text = row.Cells[1].Value.ToString();
                comboBox1.Text = row.Cells[2].Value.ToString();
            }
        }*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogUpdate = MessageBox.Show("Voulez-vous vraiment modifier cette objet", "Modifier un objet", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogUpdate == DialogResult.OK)
            {

                if (string.IsNullOrEmpty(nomtxt.Text) || string.IsNullOrEmpty(dsctxt.Text) || string.IsNullOrEmpty(comboBox1.Text))
                {
                    DialogResult dialogClose = MessageBox.Show("Remplir tous les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    maconnexion = new MySqlConnection(parametres);
                    maconnexion.Open();

                    MySqlCommand cmd = maconnexion.CreateCommand();
                    cmd.CommandText = "UPDATE objet SET statut1=@statut1, statut2=@statut2 WHERE id=" + currRowIndex;
 
                    cmd.Parameters.AddWithValue("@statut1", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@statut2", comboBox3.Text);

                    cmd.ExecuteNonQuery();
                    
                    maconnexion.Close();
                    nomtxt.Clear(); dsctxt.Clear(); //comboBox1.Clear(); comboBox2.Clear(); comboBox3.Clear();
                    

                }
            }
            load();
            panel5.Refresh();
        }
    }
}
