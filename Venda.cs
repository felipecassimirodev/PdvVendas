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
    public partial class Venda : Form
    {

        private SqlConnection conn = new SqlConnection("Data Source = CASSIMIRO; Initial Catalog = Cassimiro.sistem; Integrated Security = True ");
        public Venda()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //lbMOstraP.Text = "6";

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            string venda = "";
            if (cxtcoca.CheckState == CheckState.Checked)
            {
                venda = cxtcoca.Text;
            }
            if (cxPepsi.CheckState == CheckState.Checked)
            {
                venda = cxPepsi.Text;
            }
            if (cxAgua.CheckState == CheckState.Checked)
            {
                venda = cxAgua.Text;
            }
            if (cxSucoLaranja.CheckState == CheckState.Checked)
            {
                venda = cxSucoLaranja.Text;
            }

            List<Valor1> vq = new List<Valor1>();
            string select = $"SELECT * FROM dbo.Produto where Nome='{venda}'";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Valor1 prop = new Valor1(Convert.ToString(dr["Nome"]), Convert.ToString(dr["Preco"]), Convert.ToInt32(dr["QuantidadeNoEstoque"]));
                vq.Add(prop);
            }
            foreach (var item in vq)
            {
                lbMOstraP.Text = item.Preco;

            }
            conn.Close();
            dr.Close();

            //int aio = Convert.ToInt32(asla.Text);
            //int ad = Convert.ToInt32(txtVendaqtd.Text);
            //int soma = aio * ad;


            string insert = $"INSERT into dbo.cliente (Comanda,Produto,Quantidade,Valor) values ({txtComanda.Text},'{venda}',{txtVendaqtd.Text},'{string.Format("{0:c}", lbMOstraP.Text)}')";
            cmd = new SqlCommand(insert, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            string update = $"UPDATE dbo.Produto Set QuantidadeNoEstoque -= {txtVendaqtd.Text} WHERE Nome='{venda}'";
            cmd = new SqlCommand(update, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            int aio = Convert.ToInt32(lbMOstraP.Text);
            int ad = Convert.ToInt32(txtVendaqtd.Text);
            int soma = aio * ad;
            MessageBox.Show("Foram adicionados" + txtVendaqtd.Text + " " + venda + " na comanda " + txtComanda.Text + "! Valor total" + string.Format("{0:c}", soma));

        }

        private void cmbVenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            F_principal f = new F_principal();
            this.FindForm().Hide();
            f.Show();
        }

        private void txtVendaqtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantidade_Click(object sender, EventArgs e)
        {

        }

        private void Venda_Load(object sender, EventArgs e)
        {

        }
    }
}
