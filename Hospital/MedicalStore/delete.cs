using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MedicalStore
{
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Doctor")
            {
                MySqlConnection con = new MySqlConnection(@"server=localhost;User Id=root;Password=;database=medical;Persist Security Info=True;");
                con.Open();

                string str = "DELETE FROM doctor WHERE doct_id = '" + textBox1.Text + "'";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Doctor Record Delete Successfully");

            }
            
                if (comboBox1.SelectedItem.ToString() == "Patient")
                {
                    MySqlConnection con = new MySqlConnection(@"server=localhost;User Id=root;Password=;database=medical;Persist Security Info=True;");
                    con.Open();

                    string str = "DELETE FROM patient WHERE pat_id = '" + textBox1.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Patient Record Delete Successfully");

                }
        }
    }
}
