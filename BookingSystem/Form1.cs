using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }




        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
            string user = tbUsername.Text;
            string pass = tbPassword.Text;
            Database db = new Database();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM userfield WHERE Username = '"+tbUsername.Text+"' AND Password = '"+tbPassword.Text+"' AND Usertype = '"+cbUsertype.SelectedItem.ToString()+"' ", db.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            if (dt.Rows[0][0].ToString()=="1")
            {
                MessageBox.Show("Username and Password is Correct! Gumana ka1","info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (cbUsertype.SelectedItem.Equals("Admin"))
                {
                    Form2 home = new Form2();
                    home.Show();
                    this.Hide();
                }
                else if (cbUsertype.SelectedItem.Equals("Employee"))
                {
                    Form2 home = new Form2();
                    home.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Username and Password is Incorrect!", "alter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            home.Show();
            this.Hide();
        }
    }
}
