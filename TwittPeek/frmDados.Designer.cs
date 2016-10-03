namespace TwittPeek
{
    partial class frmDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null; //Comentado pra não gerar warning

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            this.Hide();
            /*if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);*/
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDados));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatórioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.pnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carregarToolStripMenuItem,
            this.aleatorioToolStripMenuItem,
            this.crescenteToolStripMenuItem,
            this.decrescenteToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "100";
            // 
            // aleatorioToolStripMenuItem
            // 
            this.aleatorioToolStripMenuItem.Name = "aleatorioToolStripMenuItem";
            this.aleatorioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aleatorioToolStripMenuItem.Text = "Aleatório";
            // 
            // crescenteToolStripMenuItem
            // 
            this.crescenteToolStripMenuItem.Name = "crescenteToolStripMenuItem";
            this.crescenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.crescenteToolStripMenuItem.Text = "Crescente";
            // 
            // decrescenteToolStripMenuItem
            // 
            this.decrescenteToolStripMenuItem.Name = "decrescenteToolStripMenuItem";
            this.decrescenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decrescenteToolStripMenuItem.Text = "Decrescente";
            // 
            // carregarToolStripMenuItem
            // 
            this.carregarToolStripMenuItem.Name = "carregarToolStripMenuItem";
            this.carregarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.carregarToolStripMenuItem.Text = "Carregar";
            this.carregarToolStripMenuItem.Click += new System.EventHandler(this.carregarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aleatórioToolStripMenuItem,
            this.crescenteToolStripMenuItem1,
            this.decrescenteToolStripMenuItem1});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem2.Text = "1000";
            // 
            // aleatórioToolStripMenuItem
            // 
            this.aleatórioToolStripMenuItem.Name = "aleatórioToolStripMenuItem";
            this.aleatórioToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aleatórioToolStripMenuItem.Text = "Aleatório";
            // 
            // crescenteToolStripMenuItem1
            // 
            this.crescenteToolStripMenuItem1.Name = "crescenteToolStripMenuItem1";
            this.crescenteToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.crescenteToolStripMenuItem1.Text = "Crescente";
            // 
            // decrescenteToolStripMenuItem1
            // 
            this.decrescenteToolStripMenuItem1.Name = "decrescenteToolStripMenuItem1";
            this.decrescenteToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.decrescenteToolStripMenuItem1.Text = "Decrescente";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aleatórioToolStripMenuItem1,
            this.crescenteToolStripMenuItem2,
            this.decrescenteToolStripMenuItem2});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem3.Text = "10000";
            // 
            // aleatórioToolStripMenuItem1
            // 
            this.aleatórioToolStripMenuItem1.Name = "aleatórioToolStripMenuItem1";
            this.aleatórioToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.aleatórioToolStripMenuItem1.Text = "Aleatório";
            // 
            // crescenteToolStripMenuItem2
            // 
            this.crescenteToolStripMenuItem2.Name = "crescenteToolStripMenuItem2";
            this.crescenteToolStripMenuItem2.Size = new System.Drawing.Size(138, 22);
            this.crescenteToolStripMenuItem2.Text = "Crescente";
            // 
            // decrescenteToolStripMenuItem2
            // 
            this.decrescenteToolStripMenuItem2.Name = "decrescenteToolStripMenuItem2";
            this.decrescenteToolStripMenuItem2.Size = new System.Drawing.Size(138, 22);
            this.decrescenteToolStripMenuItem2.Text = "Decrescente";
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.dataGridViewDados);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDados.Location = new System.Drawing.Point(0, 24);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(742, 274);
            this.pnlDados.TabIndex = 1;
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDados.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.Size = new System.Drawing.Size(742, 274);
            this.dataGridViewDados.TabIndex = 0;
            // 
            // frmDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 298);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDados";
            this.Text = "frmDados";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.DataGridView dataGridViewDados;
        private System.Windows.Forms.ToolStripMenuItem aleatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aleatórioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem2;
    }
}