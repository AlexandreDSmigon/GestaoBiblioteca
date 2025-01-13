namespace GestaoBiblioteca.GUI
{
    partial class FormUtilizador
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
            this.Mensagem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UtilizadorId = new System.Windows.Forms.Label();
            this.Ativo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.BotaoOK = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mensagem
            // 
            this.Mensagem.AutoSize = true;
            this.Mensagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensagem.Location = new System.Drawing.Point(13, 13);
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Size = new System.Drawing.Size(52, 21);
            this.Mensagem.TabIndex = 0;
            this.Mensagem.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // UtilizadorId
            // 
            this.UtilizadorId.AutoSize = true;
            this.UtilizadorId.Location = new System.Drawing.Point(40, 56);
            this.UtilizadorId.Name = "UtilizadorId";
            this.UtilizadorId.Size = new System.Drawing.Size(38, 13);
            this.UtilizadorId.TabIndex = 2;
            this.UtilizadorId.Text = "label3";
            // 
            // Ativo
            // 
            this.Ativo.AutoSize = true;
            this.Ativo.Location = new System.Drawing.Point(366, 56);
            this.Ativo.Name = "Ativo";
            this.Ativo.Size = new System.Drawing.Size(52, 17);
            this.Ativo.TabIndex = 3;
            this.Ativo.Text = "Ativo";
            this.Ativo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "&Nome:";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(85, 93);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(333, 22);
            this.Nome.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "&Email:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(85, 131);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(333, 22);
            this.Email.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "&Username:";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(85, 169);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(252, 22);
            this.Username.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "&Password:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(85, 207);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(333, 22);
            this.Password.TabIndex = 11;
            // 
            // BotaoOK
            // 
            this.BotaoOK.Location = new System.Drawing.Point(262, 246);
            this.BotaoOK.Name = "BotaoOK";
            this.BotaoOK.Size = new System.Drawing.Size(75, 23);
            this.BotaoOK.TabIndex = 12;
            this.BotaoOK.Text = "&OK";
            this.BotaoOK.UseVisualStyleBackColor = true;
            this.BotaoOK.Click += new System.EventHandler(this.BotaoOK_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(343, 246);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 13;
            this.BotaoCancelar.Text = "&Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // FormUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 283);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoOK);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ativo);
            this.Controls.Add(this.UtilizadorId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mensagem);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormUtilizador";
            this.Text = "FormUtilizador";
            this.Load += new System.EventHandler(this.FormUtilizador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mensagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UtilizadorId;
        private System.Windows.Forms.CheckBox Ativo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button BotaoOK;
        private System.Windows.Forms.Button BotaoCancelar;
    }
}