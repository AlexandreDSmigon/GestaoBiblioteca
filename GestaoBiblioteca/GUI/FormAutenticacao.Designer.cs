namespace GestaoBiblioteca.GUI
{
    partial class FormAutenticacao
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
            this.LabelNomeAplicacao = new System.Windows.Forms.Label();
            this.ImagemAplicacao = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Utilizador = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.BotaoOk = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.LabelFeedback = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemAplicacao)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNomeAplicacao
            // 
            this.LabelNomeAplicacao.AutoSize = true;
            this.LabelNomeAplicacao.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomeAplicacao.Location = new System.Drawing.Point(175, 9);
            this.LabelNomeAplicacao.Name = "LabelNomeAplicacao";
            this.LabelNomeAplicacao.Size = new System.Drawing.Size(92, 40);
            this.LabelNomeAplicacao.TabIndex = 0;
            this.LabelNomeAplicacao.Text = "label1";
            // 
            // ImagemAplicacao
            // 
            this.ImagemAplicacao.Image = global::GestaoBiblioteca.Properties.Resources.livros;
            this.ImagemAplicacao.Location = new System.Drawing.Point(146, 65);
            this.ImagemAplicacao.Name = "ImagemAplicacao";
            this.ImagemAplicacao.Size = new System.Drawing.Size(151, 120);
            this.ImagemAplicacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImagemAplicacao.TabIndex = 1;
            this.ImagemAplicacao.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Utilizador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // Utilizador
            // 
            this.Utilizador.Location = new System.Drawing.Point(111, 221);
            this.Utilizador.Name = "Utilizador";
            this.Utilizador.Size = new System.Drawing.Size(257, 22);
            this.Utilizador.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(111, 258);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(257, 22);
            this.Password.TabIndex = 4;
            // 
            // BotaoOk
            // 
            this.BotaoOk.Location = new System.Drawing.Point(274, 356);
            this.BotaoOk.Name = "BotaoOk";
            this.BotaoOk.Size = new System.Drawing.Size(75, 23);
            this.BotaoOk.TabIndex = 6;
            this.BotaoOk.Text = "OK";
            this.BotaoOk.UseVisualStyleBackColor = true;
            this.BotaoOk.Click += new System.EventHandler(this.BotaoOk_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(355, 356);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 7;
            this.BotaoCancelar.Text = "Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // LabelFeedback
            // 
            this.LabelFeedback.AutoSize = true;
            this.LabelFeedback.Location = new System.Drawing.Point(108, 299);
            this.LabelFeedback.Name = "LabelFeedback";
            this.LabelFeedback.Size = new System.Drawing.Size(38, 13);
            this.LabelFeedback.TabIndex = 5;
            this.LabelFeedback.Text = "label4";
            // 
            // FormAutenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 391);
            this.Controls.Add(this.LabelFeedback);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoOk);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Utilizador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImagemAplicacao);
            this.Controls.Add(this.LabelNomeAplicacao);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAutenticacao";
            this.Text = "FormAutenticacao";
            this.Load += new System.EventHandler(this.FormAutenticacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagemAplicacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNomeAplicacao;
        private System.Windows.Forms.PictureBox ImagemAplicacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Utilizador;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button BotaoOk;
        private System.Windows.Forms.Button BotaoCancelar;
        private System.Windows.Forms.Label LabelFeedback;
    }
}