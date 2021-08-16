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



namespace projeto01
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=CASSIMIRO;Initial Catalog=Cassimiro.sistem;Integrated Security=True");


        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {


        }



        private void txtLlogin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {

            string select = $"SELECT *from  dbo.Cadastro WHERE Loginuser='{txtLlogin.Text}'";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (txtSsenha.Text == dr["PasswordKey"].ToString())
                {
                    MessageBox.Show("Login efetuado");
                    F_principal Telapr = new F_principal();
                    this.Visible = false;
                    Telapr.Show();
                }
                else
                {
                    MessageBox.Show("Login invalido");
                }

            }
            dr.Close();
            conn.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
} 