namespace Teste
{
    partial class frmcarro
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
            this.btncadastro = new System.Windows.Forms.Button();
            this.btnexibir = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.txtabast = new System.Windows.Forms.TextBox();
            this.txtchassi = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtcap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncadastro
            // 
            this.btncadastro.Location = new System.Drawing.Point(136, 350);
            this.btncadastro.Name = "btncadastro";
            this.btncadastro.Size = new System.Drawing.Size(125, 52);
            this.btncadastro.TabIndex = 0;
            this.btncadastro.Text = "Cadastrar";
            this.btncadastro.UseVisualStyleBackColor = true;
            this.btncadastro.Click += new System.EventHandler(this.btncadastro_Click);
            // 
            // btnexibir
            // 
            this.btnexibir.Location = new System.Drawing.Point(344, 350);
            this.btnexibir.Name = "btnexibir";
            this.btnexibir.Size = new System.Drawing.Size(125, 52);
            this.btnexibir.TabIndex = 1;
            this.btnexibir.Text = "Exibir";
            this.btnexibir.UseVisualStyleBackColor = true;
            this.btnexibir.Click += new System.EventHandler(this.btnexibir_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(559, 350);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(125, 52);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(328, 24);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(280, 20);
            this.txtmarca.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Abastecimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade de Portas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chassi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Modelo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Capacidade do Porta-Malas";
            // 
            // txtqtd
            // 
            this.txtqtd.Location = new System.Drawing.Point(328, 204);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(280, 20);
            this.txtqtd.TabIndex = 11;
            // 
            // txtabast
            // 
            this.txtabast.Location = new System.Drawing.Point(328, 167);
            this.txtabast.Name = "txtabast";
            this.txtabast.Size = new System.Drawing.Size(280, 20);
            this.txtabast.TabIndex = 12;
            // 
            // txtchassi
            // 
            this.txtchassi.Location = new System.Drawing.Point(328, 131);
            this.txtchassi.Name = "txtchassi";
            this.txtchassi.Size = new System.Drawing.Size(280, 20);
            this.txtchassi.TabIndex = 13;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(328, 99);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(280, 20);
            this.txtplaca.TabIndex = 14;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(328, 60);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(280, 20);
            this.txtmodelo.TabIndex = 15;
            // 
            // txtcap
            // 
            this.txtcap.Location = new System.Drawing.Point(328, 243);
            this.txtcap.Name = "txtcap";
            this.txtcap.Size = new System.Drawing.Size(280, 20);
            this.txtcap.TabIndex = 16;
            // 
            // frmcarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcap);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtchassi);
            this.Controls.Add(this.txtabast);
            this.Controls.Add(this.txtqtd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.btncadastro);
            this.Name = "frmcarro";
            this.Text = "Cadastro de Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncadastro;
        private System.Windows.Forms.Button btnexibir;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.TextBox txtabast;
        private System.Windows.Forms.TextBox txtchassi;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtcap;
    }
}