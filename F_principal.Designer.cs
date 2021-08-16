
namespace projeto01
{
    partial class F_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_principal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.BTADICIONA = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.BtAtualizar = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btFecharMesa = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(338, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(338, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço";
            // 
            // txtNOME
            // 
            this.txtNOME.Location = new System.Drawing.Point(435, 22);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(159, 20);
            this.txtNOME.TabIndex = 3;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(435, 50);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(159, 20);
            this.txtPreco.TabIndex = 4;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // BTADICIONA
            // 
            this.BTADICIONA.FlatAppearance.BorderSize = 0;
            this.BTADICIONA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTADICIONA.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTADICIONA.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTADICIONA.Location = new System.Drawing.Point(3, 104);
            this.BTADICIONA.Name = "BTADICIONA";
            this.BTADICIONA.Size = new System.Drawing.Size(120, 34);
            this.BTADICIONA.TabIndex = 5;
            this.BTADICIONA.Text = "Adicionar";
            this.BTADICIONA.UseVisualStyleBackColor = true;
            this.BTADICIONA.Click += new System.EventHandler(this.BTADICIONA_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMostrar.Location = new System.Drawing.Point(3, 155);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(120, 35);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(338, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(435, 79);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(159, 20);
            this.txtQuant.TabIndex = 8;
            // 
            // BtAtualizar
            // 
            this.BtAtualizar.FlatAppearance.BorderSize = 0;
            this.BtAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAtualizar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAtualizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtAtualizar.Location = new System.Drawing.Point(3, 206);
            this.BtAtualizar.Name = "BtAtualizar";
            this.BtAtualizar.Size = new System.Drawing.Size(120, 34);
            this.BtAtualizar.TabIndex = 9;
            this.BtAtualizar.Text = "Atualizar item";
            this.BtAtualizar.UseVisualStyleBackColor = true;
            this.BtAtualizar.Click += new System.EventHandler(this.BtAtualizar_Click);
            // 
            // btndelete
            // 
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btndelete.Location = new System.Drawing.Point(3, 265);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(120, 34);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Deletar";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btsair
            // 
            this.btsair.FlatAppearance.BorderSize = 0;
            this.btsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsair.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair.ForeColor = System.Drawing.Color.Gainsboro;
            this.btsair.Location = new System.Drawing.Point(0, 440);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(120, 32);
            this.btsair.TabIndex = 11;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDados.Location = new System.Drawing.Point(200, 162);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(410, 249);
            this.dgvDados.StandardTab = true;
            this.dgvDados.TabIndex = 12;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btFecharMesa);
            this.panel1.Controls.Add(this.btnVenda);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BTADICIONA);
            this.panel1.Controls.Add(this.btnMostrar);
            this.panel1.Controls.Add(this.btsair);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.BtAtualizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 577);
            this.panel1.TabIndex = 13;
            // 
            // btFecharMesa
            // 
            this.btFecharMesa.FlatAppearance.BorderSize = 0;
            this.btFecharMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFecharMesa.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFecharMesa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btFecharMesa.Location = new System.Drawing.Point(0, 376);
            this.btFecharMesa.Name = "btFecharMesa";
            this.btFecharMesa.Size = new System.Drawing.Size(141, 32);
            this.btFecharMesa.TabIndex = 16;
            this.btFecharMesa.Text = "Fechar mesa";
            this.btFecharMesa.UseVisualStyleBackColor = true;
            this.btFecharMesa.Click += new System.EventHandler(this.btFecharMesa_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.FlatAppearance.BorderSize = 0;
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVenda.Location = new System.Drawing.Point(0, 322);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(120, 32);
            this.btnVenda.TabIndex = 15;
            this.btnVenda.Text = "Venda";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::projeto01.Properties.Resources.logo_empresa;
            this.pictureBox2.Location = new System.Drawing.Point(417, 451);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(200, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 30);
            this.panel2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(138, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Lista de produtos";
            // 
            // F_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNOME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "F_principal";
            this.Text = "Cassimiro\'s  System";
            this.Load += new System.EventHandler(this.F_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button BTADICIONA;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Button BtAtualizar;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btFecharMesa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}