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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
                MySqlConnection con = new MySqlConnection(@"server=localhost;User Id=root;Password=;database=medical;Persist Security Info=True;");
                con.Open();
                string str = "SELECT name FROM employee WHERE password='"+textBox2.Text+"'";
                MySqlCommand cmd = new MySqlCommand(str, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Visible = false;
                    Home obj2 = new Home();
                    obj2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username and Password.");
                }
            
        }
    }
}
