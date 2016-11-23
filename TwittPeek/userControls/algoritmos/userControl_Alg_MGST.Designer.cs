namespace TwittPeek.userControls.algoritmos
{
    partial class userControl_Alg_MGST
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblArrayTeste = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblArrayTesteResultado = new System.Windows.Forms.Label();
            this.btnTeste = new System.Windows.Forms.Button();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.btnCarrega100 = new System.Windows.Forms.Button();
            this.btnCarrega1000 = new System.Windows.Forms.Button();
            this.btnCarrega10000 = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultTime = new System.Windows.Forms.Label();
            this.btnExecutar_RetweetCount = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResultTime_RetweetCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExecutar_FavoriteCount = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblResultTime_FavoriteCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnExecutar_Index = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblResultTime_Index = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merge Sort (MGST)";
            // 
            // lblArrayTeste
            // 
            this.lblArrayTeste.AutoSize = true;
            this.lblArrayTeste.Location = new System.Drawing.Point(114, 57);
            this.lblArrayTeste.Name = "lblArrayTeste";
            this.lblArrayTeste.Size = new System.Drawing.Size(67, 13);
            this.lblArrayTeste.TabIndex = 98;
            this.lblArrayTeste.Text = "8423901675";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Array de testes";
            // 
            // lblArrayTesteResultado
            // 
            this.lblArrayTesteResultado.AutoSize = true;
            this.lblArrayTesteResultado.Location = new System.Drawing.Point(114, 70);
            this.lblArrayTesteResultado.Name = "lblArrayTesteResultado";
            this.lblArrayTesteResultado.Size = new System.Drawing.Size(67, 13);
            this.lblArrayTesteResultado.TabIndex = 100;
            this.lblArrayTesteResultado.Text = "8423901675";
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(192, 57);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(51, 26);
            this.btnTeste.TabIndex = 101;
            this.btnTeste.Text = "TESTE";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Location = new System.Drawing.Point(3, 253);
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.Size = new System.Drawing.Size(599, 249);
            this.dataGridViewDados.TabIndex = 102;
            // 
            // btnCarrega100
            // 
            this.btnCarrega100.Location = new System.Drawing.Point(388, 57);
            this.btnCarrega100.Name = "btnCarrega100";
            this.btnCarrega100.Size = new System.Drawing.Size(50, 26);
            this.btnCarrega100.TabIndex = 103;
            this.btnCarrega100.Text = "100";
            this.btnCarrega100.UseVisualStyleBackColor = true;
            this.btnCarrega100.Click += new System.EventHandler(this.btnCarrega100_Click);
            // 
            // btnCarrega1000
            // 
            this.btnCarrega1000.Location = new System.Drawing.Point(444, 57);
            this.btnCarrega1000.Name = "btnCarrega1000";
            this.btnCarrega1000.Size = new System.Drawing.Size(50, 26);
            this.btnCarrega1000.TabIndex = 104;
            this.btnCarrega1000.Text = "1000";
            this.btnCarrega1000.UseVisualStyleBackColor = true;
            this.btnCarrega1000.Click += new System.EventHandler(this.btnCarrega1000_Click);
            // 
            // btnCarrega10000
            // 
            this.btnCarrega10000.Location = new System.Drawing.Point(500, 57);
            this.btnCarrega10000.Name = "btnCarrega10000";
            this.btnCarrega10000.Size = new System.Drawing.Size(50, 26);
            this.btnCarrega10000.TabIndex = 105;
            this.btnCarrega10000.Text = "10000";
            this.btnCarrega10000.UseVisualStyleBackColor = true;
            this.btnCarrega10000.Click += new System.EventHandler(this.btnCarrega10000_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(28, 170);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(73, 26);
            this.btnExecutar.TabIndex = 106;
            this.btnExecutar.Text = "EXECUTAR";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Tempo:";
            // 
            // lblResultTime
            // 
            this.lblResultTime.AutoSize = true;
            this.lblResultTime.Location = new System.Drawing.Point(63, 199);
            this.lblResultTime.Name = "lblResultTime";
            this.lblResultTime.Size = new System.Drawing.Size(38, 13);
            this.lblResultTime.TabIndex = 108;
            this.lblResultTime.Text = "999ms";
            // 
            // btnExecutar_RetweetCount
            // 
            this.btnExecutar_RetweetCount.Location = new System.Drawing.Point(265, 170);
            this.btnExecutar_RetweetCount.Name = "btnExecutar_RetweetCount";
            this.btnExecutar_RetweetCount.Size = new System.Drawing.Size(73, 26);
            this.btnExecutar_RetweetCount.TabIndex = 112;
            this.btnExecutar_RetweetCount.Text = "EXECUTAR";
            this.btnExecutar_RetweetCount.UseVisualStyleBackColor = true;
            this.btnExecutar_RetweetCount.Click += new System.EventHandler(this.btnExecutar_RetweetCount_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 113;
            this.label7.Text = "Tempo:";
            // 
            // lblResultTime_RetweetCount
            // 
            this.lblResultTime_RetweetCount.AutoSize = true;
            this.lblResultTime_RetweetCount.Location = new System.Drawing.Point(299, 199);
            this.lblResultTime_RetweetCount.Name = "lblResultTime_RetweetCount";
            this.lblResultTime_RetweetCount.Size = new System.Drawing.Size(38, 13);
            this.lblResultTime_RetweetCount.TabIndex = 114;
            this.lblResultTime_RetweetCount.Text = "999ms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 115;
            this.label8.Text = "TweetLength";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 117;
            this.label10.Text = "RetweetCount";
            // 
            // btnExecutar_FavoriteCount
            // 
            this.btnExecutar_FavoriteCount.Location = new System.Drawing.Point(344, 170);
            this.btnExecutar_FavoriteCount.Name = "btnExecutar_FavoriteCount";
            this.btnExecutar_FavoriteCount.Size = new System.Drawing.Size(73, 26);
            this.btnExecutar_FavoriteCount.TabIndex = 118;
            this.btnExecutar_FavoriteCount.Text = "EXECUTAR";
            this.btnExecutar_FavoriteCount.UseVisualStyleBackColor = true;
            this.btnExecutar_FavoriteCount.Click += new System.EventHandler(this.btnExecutar_FavoriteCount_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(341, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 119;
            this.label13.Text = "Tempo:";
            // 
            // lblResultTime_FavoriteCount
            // 
            this.lblResultTime_FavoriteCount.AutoSize = true;
            this.lblResultTime_FavoriteCount.Location = new System.Drawing.Point(379, 199);
            this.lblResultTime_FavoriteCount.Name = "lblResultTime_FavoriteCount";
            this.lblResultTime_FavoriteCount.Size = new System.Drawing.Size(38, 13);
            this.lblResultTime_FavoriteCount.TabIndex = 120;
            this.lblResultTime_FavoriteCount.Text = "999ms";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(344, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 121;
            this.label11.Text = "FavoriteCount";
            // 
            // btnExecutar_Index
            // 
            this.btnExecutar_Index.Location = new System.Drawing.Point(107, 170);
            this.btnExecutar_Index.Name = "btnExecutar_Index";
            this.btnExecutar_Index.Size = new System.Drawing.Size(73, 26);
            this.btnExecutar_Index.TabIndex = 122;
            this.btnExecutar_Index.Text = "EXECUTAR";
            this.btnExecutar_Index.UseVisualStyleBackColor = true;
            this.btnExecutar_Index.Click += new System.EventHandler(this.btnExecutar_Index_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(104, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 123;
            this.label12.Text = "Tempo:";
            // 
            // lblResultTime_Index
            // 
            this.lblResultTime_Index.AutoSize = true;
            this.lblResultTime_Index.Location = new System.Drawing.Point(142, 199);
            this.lblResultTime_Index.Name = "lblResultTime_Index";
            this.lblResultTime_Index.Size = new System.Drawing.Size(38, 13);
            this.lblResultTime_Index.TabIndex = 124;
            this.lblResultTime_Index.Text = "999ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 125;
            this.label2.Text = "Index";
            // 
            // userControl_Alg_MGST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultTime_Index);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnExecutar_Index);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblResultTime_FavoriteCount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnExecutar_FavoriteCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblResultTime_RetweetCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExecutar_RetweetCount);
            this.Controls.Add(this.lblResultTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.btnCarrega10000);
            this.Controls.Add(this.btnCarrega1000);
            this.Controls.Add(this.btnCarrega100);
            this.Controls.Add(this.dataGridViewDados);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.lblArrayTesteResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblArrayTeste);
            this.Controls.Add(this.label1);
            this.Name = "userControl_Alg_MGST";
            this.Size = new System.Drawing.Size(605, 505);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblArrayTeste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblArrayTesteResultado;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.DataGridView dataGridViewDados;
        private System.Windows.Forms.Button btnCarrega100;
        private System.Windows.Forms.Button btnCarrega1000;
        private System.Windows.Forms.Button btnCarrega10000;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultTime;
        private System.Windows.Forms.Button btnExecutar_RetweetCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResultTime_RetweetCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExecutar_FavoriteCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblResultTime_FavoriteCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExecutar_Index;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblResultTime_Index;
        private System.Windows.Forms.Label label2;
    }
}
