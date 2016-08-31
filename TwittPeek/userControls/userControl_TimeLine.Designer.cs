namespace TwittPeek.userControls
{
    partial class userControl_TimeLine
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
            this.lblNumTwittsToGet = new System.Windows.Forms.Label();
            this.txtNumTwittsToGet = new System.Windows.Forms.TextBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.dataGridViewTimeLine = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimeLine)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumTwittsToGet
            // 
            this.lblNumTwittsToGet.AutoSize = true;
            this.lblNumTwittsToGet.Location = new System.Drawing.Point(161, 14);
            this.lblNumTwittsToGet.Name = "lblNumTwittsToGet";
            this.lblNumTwittsToGet.Size = new System.Drawing.Size(92, 13);
            this.lblNumTwittsToGet.TabIndex = 19;
            this.lblNumTwittsToGet.Text = "Nº of Twitts to get";
            // 
            // txtNumTwittsToGet
            // 
            this.txtNumTwittsToGet.Location = new System.Drawing.Point(179, 30);
            this.txtNumTwittsToGet.Name = "txtNumTwittsToGet";
            this.txtNumTwittsToGet.Size = new System.Drawing.Size(54, 20);
            this.txtNumTwittsToGet.TabIndex = 18;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(3, 3);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(152, 62);
            this.btnGetData.TabIndex = 16;
            this.btnGetData.Text = "GetData - TimeLine";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // dataGridViewTimeLine
            // 
            this.dataGridViewTimeLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTimeLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimeLine.Location = new System.Drawing.Point(3, 71);
            this.dataGridViewTimeLine.Name = "dataGridViewTimeLine";
            this.dataGridViewTimeLine.Size = new System.Drawing.Size(265, 271);
            this.dataGridViewTimeLine.TabIndex = 17;
            // 
            // userControl_TimeLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNumTwittsToGet);
            this.Controls.Add(this.txtNumTwittsToGet);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.dataGridViewTimeLine);
            this.Name = "userControl_TimeLine";
            this.Size = new System.Drawing.Size(271, 345);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimeLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumTwittsToGet;
        private System.Windows.Forms.TextBox txtNumTwittsToGet;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.DataGridView dataGridViewTimeLine;
    }
}
