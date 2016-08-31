namespace TwittPeek.userControls
{
    partial class userControl_GetFollowing
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
            this.dataGridViewFollowing = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFollowing)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFollowing
            // 
            this.dataGridViewFollowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFollowing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFollowing.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFollowing.Name = "dataGridViewFollowing";
            this.dataGridViewFollowing.Size = new System.Drawing.Size(234, 305);
            this.dataGridViewFollowing.TabIndex = 9;
            // 
            // userControl_GetFollowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFollowing);
            this.Name = "userControl_GetFollowing";
            this.Size = new System.Drawing.Size(234, 305);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFollowing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFollowing;
    }
}
