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
    public partial class AtualizarPr : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=CASSIMIRO;Initial Catalog=Cassimiro.sistem;Integrated Security=True");
        public AtualizarPr()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTTAT_Click(object sender, EventArgs e)
        {
                
                string update = "UPDATE dbo.Produto Set Nome= '" + txtAtNome.Text + "', Preco = '" + txtAtPreco.Text + "', QuantidadeNoEstoque = " + txtAtQTD.Text + " WHERE Nome= '" + cboNome.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(update, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            MessageBox.Show("Item atualizado!", "Adição de item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AtualizarPr_Load(object sender, EventArgs e)
        {
            List<string> nomess = new List<string>();
            string select = $"SELECT Nome from dbo.Produto ";
            SqlCommand cmd = new SqlCommand(select,conn);
           conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nomess.Add(Convert.ToString(dr["Nome"]));
            }
            dr.Close();
            conn.Close();
            cboNome.DataSource = nomess;

        }

        

        private void btMtrit_Click(object sender, EventArgs e)
        {
            conn.Open();
            string select = "SELECT Nome,Preco,QuantidadeNoEstoque FROM dbo.Produto";
            SqlCommand cmd = new SqlCommand(select, conn);
            cmd.CommandType = CommandType.Text;
            conn.Close();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dados = new DataTable();
            da.Fill(dados);
            dtMatualizar.DataSource = dados;
        }

        private void cboNome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            F_principal f = new F_principal();
            this.FindForm().Hide();
            f.Show();
        }
    }
}



