
namespace week2.forms
{
    partial class avgScore
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
            this.avgView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.avgView)).BeginInit();
            this.SuspendLayout();
            // 
            // avgView
            // 
            this.avgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avgView.Location = new System.Drawing.Point(24, 27);
            this.avgView.Name = "avgView";
            this.avgView.RowHeadersWidth = 51;
            this.avgView.RowTemplate.Height = 24;
            this.avgView.Size = new System.Drawing.Size(462, 391);
            this.avgView.TabIndex = 0;
            // 
            // avgScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.avgView);
            this.Name = "avgScore";
            this.Text = "Avg Score";
            this.Load += new System.EventHandler(this.avgScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView avgView;
    }
}