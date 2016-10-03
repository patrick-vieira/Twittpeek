namespace TwittPeek.userControls.algoritmos
{
    partial class userControl_Alg_ISBL
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultTime = new System.Windows.Forms.Label();
            this.lblResultTime_ID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExecutar_ID = new System.Windows.Forms.Button();
            this.lblResultTime_RetweetCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExecutar_RetweetCount = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblResultTime_FavoriteCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnExecutar_FavoriteCount = new System.Windows.Forms.Button();
            this.btnCarrega100 = new System.Windows.Forms.Button();
            this.btnCarrega1000 = new System.Windows.Forms.Button();
            this.btnCarrega10000 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insertion Sort com Busca Linear (ISBL)";
            // 
            // lblArrayTeste
            // 
            this.lblArrayTeste.AutoSize = true;
            this.lblArrayTeste.Location = new System.Drawing.Point(86, 23);
            this.lblArrayTeste.Name = "lblArrayTeste";
            this.lblArrayTeste.Size = new System.Drawing.Size(67, 13);
            this.lblArrayTeste.TabIndex = 1;
            this.lblArrayTeste.Text = "8423901675";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Array de testes";
            // 
            // lblArrayTesteResultado
            // 
            this.lblArrayTesteResultado.AutoSize = true;
            this.lblArrayTesteResultado.Location = new System.Drawing.Point(86, 36);
            this.lblArrayTesteResultado.Name = "lblArrayTesteResultado";
            this.lblArrayTesteResultado.Size = new System.Drawing.Size(67, 13);
            this.lblArrayTesteResultado.TabIndex = 3;
            this.lblArrayTesteResultado.Text = "8423901675";
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(164, 23);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(51, 26);
            this.btnTeste.TabIndex = 4;
            this.btnTeste.Text = "TESTE";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(21, 124);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(73, 26);
            this.btnExecutar.TabIndex = 5;
            this.btnExecutar.Text = "EXECUTAR";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Location = new System.Drawing.Point(0, 219);
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.Size = new System.Drawing.Size(613, 253);
            this.dataGridViewDados.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tempo:";
            // 
            // lblResultTime
            // 
            this.lblResultTime.AutoSize = true;
            this.lblResultTime.Location = new System.Drawing.Point(67, 165);
            this.lblResultTime.Name = "lblResultTime";
            this.lblResultTime.Size = new System.Drawing.Size(38, 13);
            this.lblResultTime.TabIndex = 12;
            this.lblResultTime.Text = "999ms";
            // 
            // lblResultTime_ID
            // 
            this.lblResultTime_ID.AutoSize = true;
            this.lblResultTime_ID.Location = new System.Drawing.Point(210, 165);
            this.lblResultTime_ID.Name = "lblResultTime_ID";
            this.lblResultTime_ID.Size = new System.Drawing.Size(38, 13);
            this.lblResultTime_ID.TabIndex = 15;
            this.lblResultTime_ID.Text = "999ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tempo:";
            // 
            // btnExecutar_ID
            // 
            this.btnExecutar_ID.Location = new System.Drawing.Point(164, 124);
            this.btnExecutar_ID.Name = "btnExecutar_ID";
            this.btnExecutar_ID.Size = new System.Drawing.Size(73, 26);
            this.btnExecutar_ID.TabIndex = 13;
            this.btnExecutar_ID.Text = "EXECUTAR";
            this.btnExecutar_ID.UseVisualStyleBackColor = true;
            this.btnExecutar_ID.Click += new System.EventHandler(this.btnExecutar_ID_Click);
            // 
            // lblResultTime_RetweetCount
            // 
            this.lblResultTime_RetweetCount.AutoSize = true;
            this.lblResultTime_RetweetCount.Location = new System.Drawing.Point(350, 165);
            this.lblResultTime_RetweetCount.Name = "lblResultTime_RetweetCount";
            this.lblResultTime_RetweetCount.Size = new System.Drawing.Size(38, 13);
            this.lblResultTime_RetweetCount.TabIndex = 18;
            this.lblResultTime_RetweetCount.Text = "999ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tempo:";
            // 
            // btnExecutar_RetweetCount
            // 
            this.btnExecutar_RetweetCount.Location = new System.Drawing.Point(304, 124);
            this.btnExecutar_RetweetCount.Name = "btnExecutar_RetweetCount";
            this.btnExecutar_RetweetCount.Size = new System.Drawing.Size(73, 26);
            this.btnExecutar_RetweetCount.TabIndex = 16;
            this.btnExecutar_RetweetCount.Text = "EXECUTAR";
            this.btnExecutar_RetweetCount.UseVisualStyleBackColor = true;
            this.btnExecutar_RetweetCount.Click += new System.EventHandler(this.btnExecutar_RetweetCount_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "PublishedTweetLength";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "RetweetCount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(429, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "FavoriteCount";
            // 
            // lblResultTime_FavoriteCount
            // 
            this.lblResultTime_FavoriteCount.AutoSize = true;
            this.lblResultTime_FavoriteCount.Location = new System.Drawing.Point(478, 165);
            this.lblResultTime_FavoriteCount.Name = "lblResultTime_FavoriteCount";
            this.lblResultTime_FavoriteCount.Size = new System.Drawing.Size(38, 13);
            this.lblResultTime_FavoriteCount.TabIndex = 24;
            this.lblResultTime_FavoriteCount.Text = "999ms";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(429, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Tempo:";
            // 
            // btnExecutar_FavoriteCount
            // 
            this.btnExecutar_FavoriteCount.Location = new System.Drawing.Point(432, 124);
            this.btnExecutar_FavoriteCount.Name = "btnExecutar_FavoriteCount";
            this.btnExecutar_FavoriteCount.Size = new System.Drawing.Size(73, 26);
            this.btnExecutar_FavoriteCount.TabIndex = 22;
            this.btnExecutar_FavoriteCount.Text = "EXECUTAR";
            this.btnExecutar_FavoriteCount.UseVisualStyleBackColor = true;
            this.btnExecutar_FavoriteCount.Click += new System.EventHandler(this.btnExecutar_FavoriteCount_Click);
            // 
            // btnCarrega100
            // 
            this.btnCarrega100.Location = new System.Drawing.Point(432, 3);
            this.btnCarrega100.Name = "btnCarrega100";
            this.btnCarrega100.Size = new System.Drawing.Size(50, 26);
            this.btnCarrega100.TabIndex = 26;
            this.btnCarrega100.Text = "100";
            this.btnCarrega100.UseVisualStyleBackColor = true;
            this.btnCarrega100.Click += new System.EventHandler(this.btnCarrega100_Click);
            // 
            // btnCarrega1000
            // 
            this.btnCarrega1000.Location = new System.Drawing.Point(488, 3);
            this.btnCarrega1000.Name = "btnCarrega1000";
            this.btnCarrega1000.Size = new System.Drawing.Size(50, 26);
            this.btnCarrega1000.TabIndex = 27;
            this.btnCarrega1000.Text = "1000";
            this.btnCarrega1000.UseVisualStyleBackColor = true;
            this.btnCarrega1000.Click += new System.EventHandler(this.btnCarrega1000_Click);
            // 
            // btnCarrega10000
            // 
            this.btnCarrega10000.Location = new System.Drawing.Point(544, 3);
            this.btnCarrega10000.Name = "btnCarrega10000";
            this.btnCarrega10000.Size = new System.Drawing.Size(50, 26);
            this.btnCarrega10000.TabIndex = 28;
            this.btnCarrega10000.Text = "10000";
            this.btnCarrega10000.UseVisualStyleBackColor = true;
            this.btnCarrega10000.Click += new System.EventHandler(this.btnCarrega10000_Click);
            // 
            // userControl_Alg_ISBL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCarrega10000);
            this.Controls.Add(this.btnCarrega1000);
            this.Controls.Add(this.btnCarrega100);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblResultTime_FavoriteCount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnExecutar_FavoriteCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblResultTime_RetweetCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExecutar_RetweetCount);
            this.Controls.Add(this.lblResultTime_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExecutar_ID);
            this.Controls.Add(this.lblResultTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewDados);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.lblArrayTesteResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblArrayTeste);
            this.Controls.Add(this.label1);
            this.Name = "userControl_Alg_ISBL";
            this.Size = new System.Drawing.Size(616, 472);
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
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.DataGridView dataGridViewDados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultTime;
        private System.Windows.Forms.Label lblResultTime_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExecutar_ID;
        private System.Windows.Forms.Label lblResultTime_RetweetCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExecutar_RetweetCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblResultTime_FavoriteCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnExecutar_FavoriteCount;
        private System.Windows.Forms.Button btnCarrega100;
        private System.Windows.Forms.Button btnCarrega1000;
        private System.Windows.Forms.Button btnCarrega10000;
    }
}
