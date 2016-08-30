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
            this.btnTweetPost = new System.Windows.Forms.Button();
            this.txtTweetBox = new System.Windows.Forms.TextBox();
            this.lblTweetCounter = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnGetData = new System.Windows.Forms.Button();
            this.dataGridViewTimeLine = new System.Windows.Forms.DataGridView();
            this.txtNumTwittsToGet = new System.Windows.Forms.TextBox();
            this.lblNumTwittsToGet = new System.Windows.Forms.Label();
            this.dataGridViewFollowing = new System.Windows.Forms.DataGridView();
            this.btnTrigger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimeLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFollowing)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTweetPost
            // 
            this.btnTweetPost.Location = new System.Drawing.Point(168, 106);
            this.btnTweetPost.Name = "btnTweetPost";
            this.btnTweetPost.Size = new System.Drawing.Size(75, 23);
            this.btnTweetPost.TabIndex = 0;
            this.btnTweetPost.Text = "Tweetar";
            this.btnTweetPost.UseVisualStyleBackColor = true;
            this.btnTweetPost.Click += new System.EventHandler(this.btnTweetPost_Click);
            // 
            // txtTweetBox
            // 
            this.txtTweetBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtTweetBox.Location = new System.Drawing.Point(12, 12);
            this.txtTweetBox.Multiline = true;
            this.txtTweetBox.Name = "txtTweetBox";
            this.txtTweetBox.Size = new System.Drawing.Size(231, 88);
            this.txtTweetBox.TabIndex = 1;
            this.txtTweetBox.TextChanged += new System.EventHandler(this.txtTweetBox_TextChanged);
            // 
            // lblTweetCounter
            // 
            this.lblTweetCounter.AutoSize = true;
            this.lblTweetCounter.Location = new System.Drawing.Point(137, 116);
            this.lblTweetCounter.Name = "lblTweetCounter";
            this.lblTweetCounter.Size = new System.Drawing.Size(25, 13);
            this.lblTweetCounter.TabIndex = 2;
            this.lblTweetCounter.Text = "140";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 103);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status info:";
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(544, 101);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(152, 32);
            this.btnGetData.TabIndex = 4;
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
            this.dataGridViewTimeLine.Location = new System.Drawing.Point(325, 139);
            this.dataGridViewTimeLine.Name = "dataGridViewTimeLine";
            this.dataGridViewTimeLine.Size = new System.Drawing.Size(386, 346);
            this.dataGridViewTimeLine.TabIndex = 5;
            // 
            // txtNumTwittsToGet
            // 
            this.txtNumTwittsToGet.Location = new System.Drawing.Point(544, 80);
            this.txtNumTwittsToGet.Name = "txtNumTwittsToGet";
            this.txtNumTwittsToGet.Size = new System.Drawing.Size(54, 20);
            this.txtNumTwittsToGet.TabIndex = 6;
            // 
            // lblNumTwittsToGet
            // 
            this.lblNumTwittsToGet.AutoSize = true;
            this.lblNumTwittsToGet.Location = new System.Drawing.Point(604, 83);
            this.lblNumTwittsToGet.Name = "lblNumTwittsToGet";
            this.lblNumTwittsToGet.Size = new System.Drawing.Size(92, 13);
            this.lblNumTwittsToGet.TabIndex = 7;
            this.lblNumTwittsToGet.Text = "Nº of Twitts to get";
            // 
            // dataGridViewFollowing
            // 
            this.dataGridViewFollowing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFollowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFollowing.Location = new System.Drawing.Point(12, 201);
            this.dataGridViewFollowing.Name = "dataGridViewFollowing";
            this.dataGridViewFollowing.Size = new System.Drawing.Size(247, 284);
            this.dataGridViewFollowing.TabIndex = 8;
            // 
            // btnTrigger
            // 
            this.btnTrigger.Location = new System.Drawing.Point(395, 12);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(152, 32);
            this.btnTrigger.TabIndex = 9;
            this.btnTrigger.Text = "trigger de testes";
            this.btnTrigger.UseVisualStyleBackColor = true;
            this.btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
            // 
            // frmTweetPeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 497);
            this.Controls.Add(this.btnTrigger);
            this.Controls.Add(this.dataGridViewFollowing);
            this.Controls.Add(this.lblNumTwittsToGet);
            this.Controls.Add(this.txtNumTwittsToGet);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTweetCounter);
            this.Controls.Add(this.txtTweetBox);
            this.Controls.Add(this.btnTweetPost);
            this.Controls.Add(this.dataGridViewTimeLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTweetPeek";
            this.Text = "TweetPeek";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimeLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFollowing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTweetPost;
        private System.Windows.Forms.TextBox txtTweetBox;
        private System.Windows.Forms.Label lblTweetCounter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.DataGridView dataGridViewTimeLine;
        private System.Windows.Forms.TextBox txtNumTwittsToGet;
        private System.Windows.Forms.Label lblNumTwittsToGet;
        private System.Windows.Forms.DataGridView dataGridViewFollowing;
        private System.Windows.Forms.Button btnTrigger;
    }
}

