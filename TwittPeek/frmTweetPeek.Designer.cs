namespace TwittPeek
{
    partial class frmTweetPeek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTweetPeek));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teste11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teste2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teste21ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.followingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twittsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parameterizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertionSortComBuscaLinearISBLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaLinearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaBináriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bubbleSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortRandomizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heapSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radixSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATORIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(641, 427);
            this.pnlMain.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.teste2ToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.algoritmosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teste11ToolStripMenuItem,
            this.directToolStripMenuItem,
            this.imagemToolStripMenuItem});
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.testeToolStripMenuItem.Text = "Send";
            // 
            // teste11ToolStripMenuItem
            // 
            this.teste11ToolStripMenuItem.Name = "teste11ToolStripMenuItem";
            this.teste11ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.teste11ToolStripMenuItem.Text = "Twett";
            this.teste11ToolStripMenuItem.Click += new System.EventHandler(this.teste11ToolStripMenuItem_Click);
            // 
            // directToolStripMenuItem
            // 
            this.directToolStripMenuItem.Name = "directToolStripMenuItem";
            this.directToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.directToolStripMenuItem.Text = "Direct";
            this.directToolStripMenuItem.Click += new System.EventHandler(this.directToolStripMenuItem_Click);
            // 
            // imagemToolStripMenuItem
            // 
            this.imagemToolStripMenuItem.Name = "imagemToolStripMenuItem";
            this.imagemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.imagemToolStripMenuItem.Text = "Imagem";
            this.imagemToolStripMenuItem.Click += new System.EventHandler(this.imagemToolStripMenuItem_Click);
            // 
            // teste2ToolStripMenuItem
            // 
            this.teste2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teste21ToolStripMenuItem,
            this.followingToolStripMenuItem});
            this.teste2ToolStripMenuItem.Name = "teste2ToolStripMenuItem";
            this.teste2ToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.teste2ToolStripMenuItem.Text = "Get";
            // 
            // teste21ToolStripMenuItem
            // 
            this.teste21ToolStripMenuItem.Name = "teste21ToolStripMenuItem";
            this.teste21ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.teste21ToolStripMenuItem.Text = "TimeLine";
            this.teste21ToolStripMenuItem.Click += new System.EventHandler(this.teste21ToolStripMenuItem_Click);
            // 
            // followingToolStripMenuItem
            // 
            this.followingToolStripMenuItem.Name = "followingToolStripMenuItem";
            this.followingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.followingToolStripMenuItem.Text = "Following";
            this.followingToolStripMenuItem.Click += new System.EventHandler(this.followingToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.twittsToolStripMenuItem,
            this.parameterizedToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // twittsToolStripMenuItem
            // 
            this.twittsToolStripMenuItem.Name = "twittsToolStripMenuItem";
            this.twittsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.twittsToolStripMenuItem.Text = "Twitts";
            this.twittsToolStripMenuItem.Click += new System.EventHandler(this.twittsToolStripMenuItem_Click);
            // 
            // parameterizedToolStripMenuItem
            // 
            this.parameterizedToolStripMenuItem.Name = "parameterizedToolStripMenuItem";
            this.parameterizedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.parameterizedToolStripMenuItem.Text = "Parameterized";
            this.parameterizedToolStripMenuItem.Click += new System.EventHandler(this.parameterizedToolStripMenuItem_Click);
            // 
            // algoritmosToolStripMenuItem
            // 
            this.algoritmosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertionSortComBuscaLinearISBLToolStripMenuItem,
            this.shellSortToolStripMenuItem,
            this.bubbleSortToolStripMenuItem,
            this.quickSortRandomizadoToolStripMenuItem,
            this.mergeSortToolStripMenuItem,
            this.heapSortToolStripMenuItem,
            this.radixSortToolStripMenuItem,
            this.rELATORIOToolStripMenuItem});
            this.algoritmosToolStripMenuItem.Name = "algoritmosToolStripMenuItem";
            this.algoritmosToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.algoritmosToolStripMenuItem.Text = "Algoritmos";
            // 
            // insertionSortComBuscaLinearISBLToolStripMenuItem
            // 
            this.insertionSortComBuscaLinearISBLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscaLinearToolStripMenuItem,
            this.buscaBináriaToolStripMenuItem});
            this.insertionSortComBuscaLinearISBLToolStripMenuItem.Name = "insertionSortComBuscaLinearISBLToolStripMenuItem";
            this.insertionSortComBuscaLinearISBLToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.insertionSortComBuscaLinearISBLToolStripMenuItem.Text = "Insertion Sort";
            // 
            // buscaLinearToolStripMenuItem
            // 
            this.buscaLinearToolStripMenuItem.Name = "buscaLinearToolStripMenuItem";
            this.buscaLinearToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.buscaLinearToolStripMenuItem.Text = "Busca Linear";
            this.buscaLinearToolStripMenuItem.Click += new System.EventHandler(this.buscaLinearToolStripMenuItem_Click);
            // 
            // buscaBináriaToolStripMenuItem
            // 
            this.buscaBináriaToolStripMenuItem.Name = "buscaBináriaToolStripMenuItem";
            this.buscaBináriaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.buscaBináriaToolStripMenuItem.Text = "Busca Binária";
            this.buscaBináriaToolStripMenuItem.Click += new System.EventHandler(this.buscaBináriaToolStripMenuItem_Click);
            // 
            // shellSortToolStripMenuItem
            // 
            this.shellSortToolStripMenuItem.Name = "shellSortToolStripMenuItem";
            this.shellSortToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.shellSortToolStripMenuItem.Text = "Shell Sort";
            this.shellSortToolStripMenuItem.Click += new System.EventHandler(this.shellSortToolStripMenuItem_Click);
            // 
            // bubbleSortToolStripMenuItem
            // 
            this.bubbleSortToolStripMenuItem.Name = "bubbleSortToolStripMenuItem";
            this.bubbleSortToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.bubbleSortToolStripMenuItem.Text = "Bubble Sort";
            this.bubbleSortToolStripMenuItem.Click += new System.EventHandler(this.bubbleSortToolStripMenuItem_Click);
            // 
            // quickSortRandomizadoToolStripMenuItem
            // 
            this.quickSortRandomizadoToolStripMenuItem.Name = "quickSortRandomizadoToolStripMenuItem";
            this.quickSortRandomizadoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.quickSortRandomizadoToolStripMenuItem.Text = "Quick Sort Randomizado";
            this.quickSortRandomizadoToolStripMenuItem.Click += new System.EventHandler(this.quickSortRandomizadoToolStripMenuItem_Click);
            // 
            // mergeSortToolStripMenuItem
            // 
            this.mergeSortToolStripMenuItem.Name = "mergeSortToolStripMenuItem";
            this.mergeSortToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.mergeSortToolStripMenuItem.Text = "Merge Sort";
            this.mergeSortToolStripMenuItem.Click += new System.EventHandler(this.mergeSortToolStripMenuItem_Click);
            // 
            // heapSortToolStripMenuItem
            // 
            this.heapSortToolStripMenuItem.Name = "heapSortToolStripMenuItem";
            this.heapSortToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.heapSortToolStripMenuItem.Text = "Heap Sort";
            this.heapSortToolStripMenuItem.Click += new System.EventHandler(this.heapSortToolStripMenuItem_Click);
            // 
            // radixSortToolStripMenuItem
            // 
            this.radixSortToolStripMenuItem.Name = "radixSortToolStripMenuItem";
            this.radixSortToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.radixSortToolStripMenuItem.Text = "Radix Sort";
            this.radixSortToolStripMenuItem.Click += new System.EventHandler(this.radixSortToolStripMenuItem_Click);
            // 
            // rELATORIOToolStripMenuItem
            // 
            this.rELATORIOToolStripMenuItem.Name = "rELATORIOToolStripMenuItem";
            this.rELATORIOToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.rELATORIOToolStripMenuItem.Text = "RELATORIO";
            this.rELATORIOToolStripMenuItem.Click += new System.EventHandler(this.rELATORIOToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialogImagem";
            // 
            // frmTweetPeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 451);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTweetPeek";
            this.Text = "TweetPeek";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teste11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teste2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teste21ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem followingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twittsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertionSortComBuscaLinearISBLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscaLinearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscaBináriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bubbleSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickSortRandomizadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heapSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radixSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem rELATORIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parameterizedToolStripMenuItem;
    }
}

