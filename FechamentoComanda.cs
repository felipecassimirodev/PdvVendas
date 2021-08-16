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
    public partial class FechamentoComanda : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source = CASSIMIRO; Initial Catalog = Cassimiro.sistem; Integrated Security = True ");
        public FechamentoComanda()
        {
            InitializeComponent();
        }

        private void btnMostrarComanda_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //string select = $"SELECT * FROM dbo.Cliente WHERE Comanda ={txtFecharComanda.Text} ";
            //SqlCommand cmd = new SqlCommand(select,conn);
            //cmd.CommandType = CommandType.Text;
            //conn.Close();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dados = new DataTable();
            //da.Fill(dados);
            //dgvFechamento.DataSource = dados;
            dgvFechamento.Rows.Clear();
            string select = $"SELECT * FROM dbo.Cliente WHERE Comanda ={txtFecharComanda.Text} ";
            SqlCommand cmd = new SqlCommand(select,conn);
            double somaFinal = 0;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //string formata = $"{dr[4].ToString():c}";
                string[] temp = { dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),dr[4].ToString() } ;
                //somaFinal += Convert.ToDouble(dr[4].ToString());
                dgvFechamento.Rows.Add(temp);
            }
            dr.Close();
            conn.Close();
            lblValorFinal.Text = somaFinal.ToString();

        }

        private void asla_Click(object sender, EventArgs e)
        {
            
        }
    }
}
