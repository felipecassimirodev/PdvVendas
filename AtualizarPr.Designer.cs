
namespace projeto01
{
    partial class AtualizarPr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizarPr));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAtNome = new System.Windows.Forms.TextBox();
            this.txtAtQTD = new System.Windows.Forms.TextBox();
            this.txtAtPreco = new System.Windows.Forms.TextBox();
            this.BTTAT = new System.Windows.Forms.Button();
            this.cboNome = new System.Windows.Forms.ComboBox();
            this.dtMatualizar = new System.Windows.Forms.DataGridView();
            this.btMtrit = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtMatualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(293, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Novo Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(293, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Novo Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(293, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantidade";
            // 
            // txtAtNome
            // 
            this.txtAtNome.Location = new System.Drawing.Point(385, 14);
            this.txtAtNome.Name = "txtAtNome";
            this.txtAtNome.Size = new System.Drawing.Size(143, 20);
            this.txtAtNome.TabIndex = 6;
            // 
            // txtAtQTD
            // 
            this.txtAtQTD.Location = new System.Drawing.Point(385, 108);
            this.txtAtQTD.Name = "txtAtQTD";
            this.txtAtQTD.Size = new System.Drawing.Size(143, 20);
            this.txtAtQTD.TabIndex = 7;
            // 
            // txtAtPreco
            // 
            this.txtAtPreco.Location = new System.Drawing.Point(385, 64);
            this.txtAtPreco.Name = "txtAtPreco";
            this.txtAtPreco.Size = new System.Drawing.Size(143, 20);
            this.txtAtPreco.TabIndex = 8;
            // 
            // BTTAT
            // 
            this.BTTAT.BackColor = System.Drawing.Color.Transparent;
            this.BTTAT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTTAT.BackgroundImage")));
            this.BTTAT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTTAT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTTAT.Location = new System.Drawing.Point(422, 134);
            this.BTTAT.Name = "BTTAT";
            this.BTTAT.Size = new System.Drawing.Size(47, 45);
            this.BTTAT.TabIndex = 9;
            this.BTTAT.UseVisualStyleBackColor = false;
            this.BTTAT.Click += new System.EventHandler(this.BTTAT_Click);
            // 
            // cboNome
            // 
            this.cboNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNome.FormattingEnabled = true;
            this.cboNome.Location = new System.Drawing.Point(49, 7);
            this.cboNome.Name = "cboNome";
            this.cboNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboNome.Size = new System.Drawing.Size(121, 21);
            this.cboNome.TabIndex = 12;
            this.cboNome.SelectedIndexChanged += new System.EventHandler(this.cboNome_SelectedIndexChanged);
            // 
            // dtMatualizar
            // 
            this.dtMatualizar.AllowUserToAddRows = false;
            this.dtMatualizar.AllowUserToDeleteRows = false;
            this.dtMatualizar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtMatualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMatualizar.Location = new System.Drawing.Point(12, 198);
            this.dtMatualizar.Name = "dtMatualizar";
            this.dtMatualizar.ReadOnly = true;
            this.dtMatualizar.Size = new System.Drawing.Size(350, 228);
            this.dtMatualizar.TabIndex = 13;
            // 
            // btMtrit
            // 
            this.btMtrit.Location = new System.Drawing.Point(12, 169);
            this.btMtrit.Name = "btMtrit";
            this.btMtrit.Size = new System.Drawing.Size(75, 23);
            this.btMtrit.TabIndex = 14;
            this.btMtrit.Text = "Mostrar itens";
            this.btMtrit.UseVisualStyleBackColor = true;
            this.btMtrit.Click += new System.EventHandler(this.btMtrit_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVoltar.BackgroundImage")));
            this.btVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltar.Location = new System.Drawing.Point(2, 3);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(28, 27);
            this.btVoltar.TabIndex = 15;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // AtualizarPr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto01.Properties.Resources.fundo_brrr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 438);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btMtrit);
            this.Controls.Add(this.dtMatualizar);
            this.Controls.Add(this.cboNome);
            this.Controls.Add(this.BTTAT);
            this.Controls.Add(this.txtAtPreco);
            this.Controls.Add(this.txtAtQTD);
            this.Controls.Add(this.txtAtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AtualizarPr";
            this.Text = "AtualizarPr";
            this.Load += new System.EventHandler(this.AtualizarPr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMatualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAtNome;
        private System.Windows.Forms.TextBox txtAtQTD;
        private System.Windows.Forms.TextBox txtAtPreco;
        private System.Windows.Forms.Button BTTAT;
        private System.Windows.Forms.ComboBox cboNome;
        private System.Windows.Forms.DataGridView dtMatualizar;
        private System.Windows.Forms.Button btMtrit;
        private System.Windows.Forms.Button btVoltar;
    }
}