using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.OleDb;


namespace LoginEjercicioClase
{
    public partial class LogIn : Form
    {
        SqlConnection con = new SqlConnection();
        public LogIn()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "" +
                "Data Source=DESKTOP-VHEG681;Initial Catalog=UsuariosDB;Integrated Security=True";
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VHEG681;Initial Catalog=UsuariosDB;Integrated Security=True");
            con.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VHEG681;Initial Catalog=UsuariosDB;Integrated Security=True";
            con.Open();
            string usuario = textBox1.Text;
            string contrasena = textBox2.Text;
            SqlCommand cmd = new SqlCommand("select usuario,contrasena from UsersTB where usuario='" + textBox1.Text + "'and contrasena='" + textBox2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Exitoso");
            }
            else
            {
                MessageBox.Show("Login fallido, revise su usuario y contraseña");
            }
            con.Close();           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
