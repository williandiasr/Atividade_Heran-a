namespace Teste
{
    partial class frmcadastro
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
            this.btncarro = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btncaminhao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncarro
            // 
            this.btncarro.Location = new System.Drawing.Point(35, 154);
            this.btncarro.Name = "btncarro";
            this.btncarro.Size = new System.Drawing.Size(161, 72);
            this.btncarro.TabIndex = 0;
            this.btncarro.Text = "Carro";
            this.btncarro.UseVisualStyleBackColor = true;
            this.btncarro.Click += new System.EventHandler(this.btncarro_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(306, 154);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(161, 72);
            this.btnsair.TabIndex = 1;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btncaminhao
            // 
            this.btncaminhao.Location = new System.Drawing.Point(581, 154);
            this.btncaminhao.Name = "btncaminhao";
            this.btncaminhao.Size = new System.Drawing.Size(161, 72);
            this.btncaminhao.TabIndex = 2;
            this.btncaminhao.Text = "Caminhão";
            this.btncaminhao.UseVisualStyleBackColor = true;
            this.btncaminhao.Click += new System.EventHandler(this.btncaminhao_Click);
            // 
            // frmcadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncaminhao);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncarro);
            this.Name = "frmcadastro";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncarro;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btncaminhao;
    }
}

