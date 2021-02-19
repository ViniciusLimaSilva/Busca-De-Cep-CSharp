
namespace BuscaCepXML
{
    partial class Busca_Cep
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busca_Cep));
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_Logradouro = new System.Windows.Forms.TextBox();
            this.txt_UF = new System.Windows.Forms.TextBox();
            this.LinkGitHub = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_busca = new System.Windows.Forms.Button();
            this.label_git = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(62, 39);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(100, 20);
            this.txt_cep.TabIndex = 0;
            this.txt_cep.TextChanged += new System.EventHandler(this.txt_cep_TextChanged);
            this.txt_cep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cep_keypress);
            // 
            // txt_cidade
            // 
            this.txt_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.Location = new System.Drawing.Point(78, 114);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(116, 22);
            this.txt_cidade.TabIndex = 2;
            this.txt_cidade.TextChanged += new System.EventHandler(this.txt_cidade_TextChanged);
            // 
            // txt_Logradouro
            // 
            this.txt_Logradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Logradouro.Location = new System.Drawing.Point(117, 76);
            this.txt_Logradouro.Name = "txt_Logradouro";
            this.txt_Logradouro.Size = new System.Drawing.Size(203, 22);
            this.txt_Logradouro.TabIndex = 3;
            this.txt_Logradouro.TextChanged += new System.EventHandler(this.txt_Logradouro_TextChanged);
            // 
            // txt_UF
            // 
            this.txt_UF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UF.Location = new System.Drawing.Point(252, 154);
            this.txt_UF.Name = "txt_UF";
            this.txt_UF.Size = new System.Drawing.Size(34, 22);
            this.txt_UF.TabIndex = 4;
            this.txt_UF.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // LinkGitHub
            // 
            this.LinkGitHub.AutoSize = true;
            this.LinkGitHub.Font = new System.Drawing.Font("Open Sans", 7.25F, System.Drawing.FontStyle.Bold);
            this.LinkGitHub.Location = new System.Drawing.Point(249, 193);
            this.LinkGitHub.Name = "LinkGitHub";
            this.LinkGitHub.Size = new System.Drawing.Size(71, 14);
            this.LinkGitHub.TabIndex = 6;
            this.LinkGitHub.TabStop = true;
            this.LinkGitHub.Text = "Vinicius lima";
            this.LinkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Github_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "CEP:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Logradouro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "UF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "CIdade:";
            // 
            // btn_busca
            // 
            this.btn_busca.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_busca.Location = new System.Drawing.Point(193, 37);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(62, 22);
            this.btn_busca.TabIndex = 13;
            this.btn_busca.Text = "Buscar";
            this.btn_busca.UseVisualStyleBackColor = false;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_click);
            // 
            // label_git
            // 
            this.label_git.AutoSize = true;
            this.label_git.Location = new System.Drawing.Point(159, 194);
            this.label_git.Name = "label_git";
            this.label_git.Size = new System.Drawing.Size(93, 13);
            this.label_git.TabIndex = 14;
            this.label_git.Text = "Desenvolvido por:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bairro.Location = new System.Drawing.Point(74, 154);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(116, 22);
            this.txt_bairro.TabIndex = 15;
            this.txt_bairro.TextChanged += new System.EventHandler(this.txt_bairro_TextChanged);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Limpar.Location = new System.Drawing.Point(261, 37);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(62, 22);
            this.btn_Limpar.TabIndex = 16;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_click);
            // 
            // Busca_Cep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(325, 212);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.label_git);
            this.Controls.Add(this.btn_busca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LinkGitHub);
            this.Controls.Add(this.txt_UF);
            this.Controls.Add(this.txt_Logradouro);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.txt_cep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Busca_Cep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca de Cep";
            this.Load += new System.EventHandler(this.Busca_Cep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_Logradouro;
        private System.Windows.Forms.TextBox txt_UF;
        private System.Windows.Forms.LinkLabel LinkGitHub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.Label label_git;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Button btn_Limpar;
    }
}

