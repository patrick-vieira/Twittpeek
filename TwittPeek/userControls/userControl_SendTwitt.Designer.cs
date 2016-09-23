namespace TwittPeek.userControls
{
    partial class userControl_SendTwitt
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTweetCounter = new System.Windows.Forms.Label();
            this.txtTweetBox = new System.Windows.Forms.TextBox();
            this.btnTweetPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(17, 259);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status info:";
            // 
            // lblTweetCounter
            // 
            this.lblTweetCounter.AutoSize = true;
            this.lblTweetCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTweetCounter.Location = new System.Drawing.Point(37, 190);
            this.lblTweetCounter.Name = "lblTweetCounter";
            this.lblTweetCounter.Size = new System.Drawing.Size(51, 25);
            this.lblTweetCounter.TabIndex = 6;
            this.lblTweetCounter.Text = "140";
            // 
            // txtTweetBox
            // 
            this.txtTweetBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTweetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTweetBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtTweetBox.Location = new System.Drawing.Point(21, 21);
            this.txtTweetBox.Multiline = true;
            this.txtTweetBox.Name = "txtTweetBox";
            this.txtTweetBox.Size = new System.Drawing.Size(241, 134);
            this.txtTweetBox.TabIndex = 5;
            this.txtTweetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTweetBox.TextChanged += new System.EventHandler(this.txtTweetBox_TextChanged);
            // 
            // btnTweetPost
            // 
            this.btnTweetPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTweetPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTweetPost.Location = new System.Drawing.Point(104, 180);
            this.btnTweetPost.Name = "btnTweetPost";
            this.btnTweetPost.Size = new System.Drawing.Size(158, 44);
            this.btnTweetPost.TabIndex = 4;
            this.btnTweetPost.Text = "Tweetar";
            this.btnTweetPost.UseVisualStyleBackColor = true;
            this.btnTweetPost.Click += new System.EventHandler(this.btnTweetPost_Click);
            // 
            // userControl_SendTwitt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTweetCounter);
            this.Controls.Add(this.txtTweetBox);
            this.Controls.Add(this.btnTweetPost);
            this.Name = "userControl_SendTwitt";
            this.Size = new System.Drawing.Size(287, 316);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTweetCounter;
        private System.Windows.Forms.TextBox txtTweetBox;
        private System.Windows.Forms.Button btnTweetPost;
    }
}
