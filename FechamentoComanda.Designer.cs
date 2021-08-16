
namespace projeto01
{
    partial class FechamentoComanda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FechamentoComanda));
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.lbPrecoo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecharComanda = new System.Windows.Forms.TextBox();
            this.btnFecharComanda = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.dgvFechamento = new System.Windows.Forms.DataGridView();
            this.btnMostrarComanda = new System.Windows.Forms.Button();
            this.Comanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechamento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblValorFinal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorFinal.Location = new System.Drawing.Point(116, 412);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(19, 13);
            this.lblValorFinal.TabIndex = 28;
            this.lblValorFinal.Text = "00";
            this.lblValorFinal.Click += new System.EventHandler(this.asla_Click);
            // 
            // lbPrecoo
            // 
            this.lbPrecoo.AutoSize = true;
            this.lbPrecoo.BackColor = System.Drawing.Color.Transparent;
            this.lbPrecoo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPrecoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPrecoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecoo.Location = new System.Drawing.Point(9, 408);
            this.lbPrecoo.Name = "lbPrecoo";
            this.lbPrecoo.Size = new System.Drawing.Size(87, 22);
            this.lbPrecoo.TabIndex = 27;
            this.lbPrecoo.Text = "Valor total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Comanda";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFecharComanda
            // 
            this.txtFecharComanda.BackColor = System.Drawing.Color.DarkGray;
            this.txtFecharComanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecharComanda.Location = new System.Drawing.Point(132, 12);
            this.txtFecharComanda.Name = "txtFecharComanda";
            this.txtFecharComanda.Size = new System.Drawing.Size(45, 13);
            this.txtFecharComanda.TabIndex = 25;
            // 
            // btnFecharComanda
            // 
            this.btnFecharComanda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFecharComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharComanda.Location = new System.Drawing.Point(440, 406);
            this.btnFecharComanda.Name = "btnFecharComanda";
            this.btnFecharComanda.Size = new System.Drawing.Size(129, 24);
            this.btnFecharComanda.TabIndex = 22;
            this.btnFecharComanda.Text = "Fechar comanda";
            this.btnFecharComanda.UseVisualStyleBackColor = false;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVoltar.BackgroundImage")));
            this.btVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltar.Location = new System.Drawing.Point(0, 1);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(28, 28);
            this.btVoltar.TabIndex = 24;
            this.btVoltar.UseVisualStyleBackColor = false;
            // 
            // dgvFechamento
            // 
            this.dgvFechamento.AllowUserToAddRows = false;
            this.dgvFechamento.AllowUserToDeleteRows = false;
            this.dgvFechamento.AllowUserToOrderColumns = true;
            this.dgvFechamento.BackgroundColor = System.Drawing.Color.White;
            this.dgvFechamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFechamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comanda,
            this.Produto,
            this.Quantidade,
            this.Valor});
            this.dgvFechamento.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvFechamento.Location = new System.Drawing.Point(0, 54);
            this.dgvFechamento.Name = "dgvFechamento";
            this.dgvFechamento.ReadOnly = true;
            this.dgvFechamento.Size = new System.Drawing.Size(569, 324);
            this.dgvFechamento.StandardTab = true;
            this.dgvFechamento.TabIndex = 29;
            // 
            // btnMostrarComanda
            // 
            this.btnMostrarComanda.Location = new System.Drawing.Point(202, 9);
            this.btnMostrarComanda.Name = "btnMostrarComanda";
            this.btnMostrarComanda.Size = new System.Drawing.Size(100, 24);
            this.btnMostrarComanda.TabIndex = 31;
            this.btnMostrarComanda.Text = "Mostrar ";
            this.btnMostrarComanda.UseVisualStyleBackColor = true;
            this.btnMostrarComanda.Click += new System.EventHandler(this.btnMostrarComanda_Click);
            // 
            // Comanda
            // 
            this.Comanda.HeaderText = "Comanda";
            this.Comanda.Name = "Comanda";
            this.Comanda.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 200;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // FechamentoComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 469);
            this.Controls.Add(this.btnMostrarComanda);
            this.Controls.Add(this.dgvFechamento);
            this.Controls.Add(this.lblValorFinal);
            this.Controls.Add(this.lbPrecoo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFecharComanda);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btnFecharComanda);
            this.Name = "FechamentoComanda";
            this.Text = "FechamentoComanda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.Label lbPrecoo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFecharComanda;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btnFecharComanda;
        private System.Windows.Forms.DataGridView dgvFechamento;
        private System.Windows.Forms.Button btnMostrarComanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}