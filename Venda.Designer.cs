
namespace projeto01
{
    partial class Venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venda));
            this.txtVendaqtd = new System.Windows.Forms.TextBox();
            this.cxtcoca = new System.Windows.Forms.CheckBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.Quantidade = new System.Windows.Forms.Label();
            this.cxPepsi = new System.Windows.Forms.CheckBox();
            this.cxSucoLaranja = new System.Windows.Forms.CheckBox();
            this.cxAgua = new System.Windows.Forms.CheckBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.txtComanda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPrecoo = new System.Windows.Forms.Label();
            this.lbMOstraP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVendaqtd
            // 
            this.txtVendaqtd.BackColor = System.Drawing.Color.DarkGray;
            this.txtVendaqtd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVendaqtd.Location = new System.Drawing.Point(251, 12);
            this.txtVendaqtd.Name = "txtVendaqtd";
            this.txtVendaqtd.Size = new System.Drawing.Size(45, 13);
            this.txtVendaqtd.TabIndex = 1;
            this.txtVendaqtd.TextChanged += new System.EventHandler(this.txtVendaqtd_TextChanged);
            // 
            // cxtcoca
            // 
            this.cxtcoca.AutoSize = true;
            this.cxtcoca.BackColor = System.Drawing.Color.Transparent;
            this.cxtcoca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cxtcoca.BackgroundImage")));
            this.cxtcoca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cxtcoca.Location = new System.Drawing.Point(30, 107);
            this.cxtcoca.MaximumSize = new System.Drawing.Size(1000, 2000);
            this.cxtcoca.MinimumSize = new System.Drawing.Size(100, 100);
            this.cxtcoca.Name = "cxtcoca";
            this.cxtcoca.Size = new System.Drawing.Size(100, 100);
            this.cxtcoca.TabIndex = 2;
            this.cxtcoca.Text = "cocacola";
            this.cxtcoca.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.cxtcoca.UseVisualStyleBackColor = false;
            this.cxtcoca.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(12, 61);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(100, 24);
            this.btnVender.TabIndex = 3;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Location = new System.Drawing.Point(183, 15);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(62, 13);
            this.Quantidade.TabIndex = 4;
            this.Quantidade.Text = "Quantidade";
            this.Quantidade.Click += new System.EventHandler(this.Quantidade_Click);
            // 
            // cxPepsi
            // 
            this.cxPepsi.AutoSize = true;
            this.cxPepsi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cxPepsi.BackgroundImage")));
            this.cxPepsi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cxPepsi.Location = new System.Drawing.Point(30, 230);
            this.cxPepsi.MaximumSize = new System.Drawing.Size(1000, 2000);
            this.cxPepsi.MinimumSize = new System.Drawing.Size(100, 100);
            this.cxPepsi.Name = "cxPepsi";
            this.cxPepsi.Size = new System.Drawing.Size(100, 100);
            this.cxPepsi.TabIndex = 5;
            this.cxPepsi.Text = "pepsi";
            this.cxPepsi.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.cxPepsi.UseVisualStyleBackColor = true;
            // 
            // cxSucoLaranja
            // 
            this.cxSucoLaranja.AutoSize = true;
            this.cxSucoLaranja.BackColor = System.Drawing.Color.Transparent;
            this.cxSucoLaranja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cxSucoLaranja.BackgroundImage")));
            this.cxSucoLaranja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cxSucoLaranja.Location = new System.Drawing.Point(162, 118);
            this.cxSucoLaranja.MaximumSize = new System.Drawing.Size(1000, 2000);
            this.cxSucoLaranja.MinimumSize = new System.Drawing.Size(100, 100);
            this.cxSucoLaranja.Name = "cxSucoLaranja";
            this.cxSucoLaranja.Size = new System.Drawing.Size(100, 100);
            this.cxSucoLaranja.TabIndex = 6;
            this.cxSucoLaranja.Text = "sucolaranja";
            this.cxSucoLaranja.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.cxSucoLaranja.UseVisualStyleBackColor = false;
            // 
            // cxAgua
            // 
            this.cxAgua.AutoSize = true;
            this.cxAgua.BackColor = System.Drawing.Color.Transparent;
            this.cxAgua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cxAgua.BackgroundImage")));
            this.cxAgua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cxAgua.Location = new System.Drawing.Point(30, 364);
            this.cxAgua.MaximumSize = new System.Drawing.Size(1000, 2000);
            this.cxAgua.MinimumSize = new System.Drawing.Size(100, 100);
            this.cxAgua.Name = "cxAgua";
            this.cxAgua.Size = new System.Drawing.Size(100, 100);
            this.cxAgua.TabIndex = 7;
            this.cxAgua.Text = "agua";
            this.cxAgua.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.cxAgua.UseVisualStyleBackColor = false;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVoltar.BackgroundImage")));
            this.btVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltar.Location = new System.Drawing.Point(1, 0);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(28, 28);
            this.btVoltar.TabIndex = 13;
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // txtComanda
            // 
            this.txtComanda.BackColor = System.Drawing.Color.DarkGray;
            this.txtComanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComanda.Location = new System.Drawing.Point(103, 12);
            this.txtComanda.Name = "txtComanda";
            this.txtComanda.Size = new System.Drawing.Size(45, 13);
            this.txtComanda.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Comanda";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPrecoo
            // 
            this.lbPrecoo.AutoSize = true;
            this.lbPrecoo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPrecoo.Location = new System.Drawing.Point(342, 17);
            this.lbPrecoo.Name = "lbPrecoo";
            this.lbPrecoo.Size = new System.Drawing.Size(37, 15);
            this.lbPrecoo.TabIndex = 17;
            this.lbPrecoo.Text = "Preço";
            // 
            // lbMOstraP
            // 
            this.lbMOstraP.AutoSize = true;
            this.lbMOstraP.BackColor = System.Drawing.Color.Transparent;
            this.lbMOstraP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMOstraP.Location = new System.Drawing.Point(385, 19);
            this.lbMOstraP.Name = "lbMOstraP";
            this.lbMOstraP.Size = new System.Drawing.Size(19, 13);
            this.lbMOstraP.TabIndex = 20;
            this.lbMOstraP.Text = "00";
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto01.Properties.Resources.fundo_brrr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 477);
            this.Controls.Add(this.lbMOstraP);
            this.Controls.Add(this.lbPrecoo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComanda);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.cxAgua);
            this.Controls.Add(this.cxSucoLaranja);
            this.Controls.Add(this.cxPepsi);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.cxtcoca);
            this.Controls.Add(this.txtVendaqtd);
            this.Name = "Venda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVendaqtd;
        private System.Windows.Forms.CheckBox cxtcoca;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label Quantidade;
        private System.Windows.Forms.CheckBox cxPepsi;
        private System.Windows.Forms.CheckBox cxSucoLaranja;
        private System.Windows.Forms.CheckBox cxAgua;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.TextBox txtComanda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPrecoo;
        private System.Windows.Forms.Label lbMOstraP;
    }
}