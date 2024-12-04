namespace GestaoBiblioteca.GUI
{
    partial class FormAcercaAplicacao
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelNomeAplicacao = new System.Windows.Forms.Label();
            this.LinkRepositorio = new System.Windows.Forms.LinkLabel();
            this.LabelVersao = new System.Windows.Forms.Label();
            this.LabelCopyright = new System.Windows.Forms.Label();
            this.BotaoOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoBiblioteca.Properties.Resources.livros;
            this.pictureBox1.Location = new System.Drawing.Point(24, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LabelNomeAplicacao
            // 
            this.LabelNomeAplicacao.AutoSize = true;
            this.LabelNomeAplicacao.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomeAplicacao.Location = new System.Drawing.Point(198, 23);
            this.LabelNomeAplicacao.Name = "LabelNomeAplicacao";
            this.LabelNomeAplicacao.Size = new System.Drawing.Size(92, 40);
            this.LabelNomeAplicacao.TabIndex = 1;
            this.LabelNomeAplicacao.Text = "label1";
            // 
            // LinkRepositorio
            // 
            this.LinkRepositorio.AutoSize = true;
            this.LinkRepositorio.Location = new System.Drawing.Point(205, 119);
            this.LinkRepositorio.Name = "LinkRepositorio";
            this.LinkRepositorio.Size = new System.Drawing.Size(59, 13);
            this.LinkRepositorio.TabIndex = 2;
            this.LinkRepositorio.TabStop = true;
            this.LinkRepositorio.Text = "linkLabel1";
            this.LinkRepositorio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRepositorio_LinkClicked);
            // 
            // LabelVersao
            // 
            this.LabelVersao.AutoSize = true;
            this.LabelVersao.Location = new System.Drawing.Point(205, 73);
            this.LabelVersao.Name = "LabelVersao";
            this.LabelVersao.Size = new System.Drawing.Size(38, 13);
            this.LabelVersao.TabIndex = 3;
            this.LabelVersao.Text = "label2";
            // 
            // LabelCopyright
            // 
            this.LabelCopyright.AutoSize = true;
            this.LabelCopyright.Location = new System.Drawing.Point(205, 96);
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.Size = new System.Drawing.Size(38, 13);
            this.LabelCopyright.TabIndex = 4;
            this.LabelCopyright.Text = "label3";
            // 
            // BotaoOk
            // 
            this.BotaoOk.Location = new System.Drawing.Point(424, 178);
            this.BotaoOk.Name = "BotaoOk";
            this.BotaoOk.Size = new System.Drawing.Size(75, 23);
            this.BotaoOk.TabIndex = 5;
            this.BotaoOk.Text = "&OK";
            this.BotaoOk.UseVisualStyleBackColor = true;
            this.BotaoOk.Click += new System.EventHandler(this.BotaoOk_Click);
            // 
            // FormAcercaAplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 213);
            this.Controls.Add(this.BotaoOk);
            this.Controls.Add(this.LabelCopyright);
            this.Controls.Add(this.LabelVersao);
            this.Controls.Add(this.LinkRepositorio);
            this.Controls.Add(this.LabelNomeAplicacao);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAcercaAplicacao";
            this.Text = "FormAcercaAplicacao";
            this.Load += new System.EventHandler(this.FormAcercaAplicacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelNomeAplicacao;
        private System.Windows.Forms.LinkLabel LinkRepositorio;
        private System.Windows.Forms.Label LabelVersao;
        private System.Windows.Forms.Label LabelCopyright;
        private System.Windows.Forms.Button BotaoOk;
    }
}