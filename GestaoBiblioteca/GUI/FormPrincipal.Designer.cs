namespace GestaoBiblioteca
{
    partial class FormPrincipal
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
            this.LabelTituloAplicacao = new System.Windows.Forms.Label();
            this.LabelSubtituloAplicacao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BotaoUtilizadores = new System.Windows.Forms.Button();
            this.BotaoCatalogo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDaAplicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTituloAplicacao
            // 
            this.LabelTituloAplicacao.AutoSize = true;
            this.LabelTituloAplicacao.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTituloAplicacao.Location = new System.Drawing.Point(287, 29);
            this.LabelTituloAplicacao.Name = "LabelTituloAplicacao";
            this.LabelTituloAplicacao.Size = new System.Drawing.Size(92, 40);
            this.LabelTituloAplicacao.TabIndex = 0;
            this.LabelTituloAplicacao.Text = "label1";
            // 
            // LabelSubtituloAplicacao
            // 
            this.LabelSubtituloAplicacao.AutoSize = true;
            this.LabelSubtituloAplicacao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubtituloAplicacao.Location = new System.Drawing.Point(189, 80);
            this.LabelSubtituloAplicacao.Name = "LabelSubtituloAplicacao";
            this.LabelSubtituloAplicacao.Size = new System.Drawing.Size(288, 25);
            this.LabelSubtituloAplicacao.TabIndex = 1;
            this.LabelSubtituloAplicacao.Text = "Sistema de Gestão de Bibliotecas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoBiblioteca.Properties.Resources.utilizadores;
            this.pictureBox1.Location = new System.Drawing.Point(47, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestaoBiblioteca.Properties.Resources.catalogo;
            this.pictureBox2.Location = new System.Drawing.Point(298, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // BotaoUtilizadores
            // 
            this.BotaoUtilizadores.Location = new System.Drawing.Point(106, 351);
            this.BotaoUtilizadores.Name = "BotaoUtilizadores";
            this.BotaoUtilizadores.Size = new System.Drawing.Size(82, 23);
            this.BotaoUtilizadores.TabIndex = 4;
            this.BotaoUtilizadores.Text = "Utilizadores";
            this.BotaoUtilizadores.UseVisualStyleBackColor = true;
            // 
            // BotaoCatalogo
            // 
            this.BotaoCatalogo.Location = new System.Drawing.Point(361, 351);
            this.BotaoCatalogo.Name = "BotaoCatalogo";
            this.BotaoCatalogo.Size = new System.Drawing.Size(75, 23);
            this.BotaoCatalogo.TabIndex = 5;
            this.BotaoCatalogo.Text = "Catálogo";
            this.BotaoCatalogo.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "&Ficheiro";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDaAplicaçãoToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // acercaDaAplicaçãoToolStripMenuItem
            // 
            this.acercaDaAplicaçãoToolStripMenuItem.Name = "acercaDaAplicaçãoToolStripMenuItem";
            this.acercaDaAplicaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDaAplicaçãoToolStripMenuItem.Text = "Ac&erca da aplicação";
            this.acercaDaAplicaçãoToolStripMenuItem.Click += new System.EventHandler(this.acercaDaAplicaçãoToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 386);
            this.Controls.Add(this.BotaoCatalogo);
            this.Controls.Add(this.BotaoUtilizadores);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelSubtituloAplicacao);
            this.Controls.Add(this.LabelTituloAplicacao);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTituloAplicacao;
        private System.Windows.Forms.Label LabelSubtituloAplicacao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BotaoUtilizadores;
        private System.Windows.Forms.Button BotaoCatalogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDaAplicaçãoToolStripMenuItem;
    }
}

