using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto01
{
    public partial class F_principal : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source = CASSIMIRO; Initial Catalog = Cassimiro.sistem; Integrated Security = True ");
        public F_principal()
        {
            InitializeComponent();
        }
        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPreco);
        }
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text;//.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:c3}", v);
                txt.SelectionStart = txt.Text.Length;
                //CultureInfo.GetCultureInfo("pt-BR"),


            }
            catch (Exception)
            {


            }
        }
        private void BTADICIONA_Click(object sender, EventArgs e)
        {

            string insert = $"INSERT into dbo.Produto (Nome,Preco,QuantidadeNoEstoque) values ('{txtNOME.Text}','{txtPreco.Text}',{txtQuant.Text})";
            SqlCommand cmd = new SqlCommand(insert, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            txtNOME.Clear();
            MessageBox.Show("Item adicionado!", "Adição de item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //lstItens.Items.Clear();
            //List<itemmm> itens = new List<itemmm>();
            //string select = "SELECT * from dbo.Produto";
            //SqlCommand cmd = new SqlCommand(select,conn);
            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    itemmm prop = new itemmm(Convert.ToString(dr["nome"]),Convert.ToInt32(dr["Preco"]),Convert.ToInt32(dr["QuantidadeNoEstoque"]));
            //    itens.Add(prop);
            //}
            //foreach (var item in itens)
            //{
            //    lstItens.Items.Add(item.Nome);
            //    lstItens.Items.Add(item.Preco);
            //    lstItens.Items.Add(item.Quantidade);
            //    lstItens.Items.Add("------------");

            //}
            //dr.Close();
            //conn.Close();


            conn.Open();
            string select = "SELECT Nome,Preco,QuantidadeNoEstoque FROM dbo.Produto";
            SqlCommand cmd = new SqlCommand(select,conn);
            cmd.CommandType = CommandType.Text;
            conn.Close();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dados = new DataTable();
            da.Fill(dados);
            dgvDados.DataSource = dados; //CONVERTER NU
            
        }

        private void BtAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarPr at = new AtualizarPr();
            this.Visible = false;
            at.ShowDialog();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string delete = $"DELETE from dbo.Produto WHERE Nome='{txtNOME.Text}'";
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand(delete,conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            Venda ta = new Venda();
            this.Visible = false;
            ta.ShowDialog();
        }

        private void btFecharMesa_Click(object sender, EventArgs e)
        {
            FechamentoComanda fc = new FechamentoComanda();
            this.Visible = false;
            fc.ShowDialog();


        }
        

        private void F_principal_Load(object sender, EventArgs e)
        {

        }
        

       
    }
}
