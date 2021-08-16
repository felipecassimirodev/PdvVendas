
namespace execWindFor01
{
    partial class Form12
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTADICIONA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lstItens = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BTADICIONA
            // 
            this.BTADICIONA.Location = new System.Drawing.Point(498, 34);
            this.BTADICIONA.Name = "BTADICIONA";
            this.BTADICIONA.Size = new System.Drawing.Size(75, 23);
            this.BTADICIONA.TabIndex = 0;
            this.BTADICIONA.Text = "ADICIONAR";
            this.BTADICIONA.UseVisualStyleBackColor = true;
            this.BTADICIONA.Click += new System.EventHandler(this.BTADICIONA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do produto";
            // 
            // txtNOME
            // 
            this.txtNOME.Location = new System.Drawing.Point(121, 34);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(309, 23);
            this.txtNOME.TabIndex = 2;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(121, 71);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(309, 23);
            this.txtPreco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preço";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(498, 71);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lstItens
            // 
            this.lstItens.FormattingEnabled = true;
            this.lstItens.ItemHeight = 15;
            this.lstItens.Location = new System.Drawing.Point(12, 193);
            this.lstItens.Name = "lstItens";
            this.lstItens.Size = new System.Drawing.Size(776, 244);
            this.lstItens.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstItens);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNOME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTADICIONA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTADICIONA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox lstItens;
    }
}

