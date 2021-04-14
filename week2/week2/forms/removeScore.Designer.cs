
namespace week2.forms
{
    partial class removeScore
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
            this.scoreView = new System.Windows.Forms.DataGridView();
            this.rmBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoreView)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreView
            // 
            this.scoreView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreView.Location = new System.Drawing.Point(12, 22);
            this.scoreView.Name = "scoreView";
            this.scoreView.RowHeadersWidth = 51;
            this.scoreView.RowTemplate.Height = 24;
            this.scoreView.Size = new System.Drawing.Size(602, 352);
            this.scoreView.TabIndex = 0;
            this.scoreView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scoreView_CellClick);
            // 
            // rmBTN
            // 
            this.rmBTN.BackColor = System.Drawing.Color.Red;
            this.rmBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmBTN.ForeColor = System.Drawing.Color.White;
            this.rmBTN.Location = new System.Drawing.Point(61, 398);
            this.rmBTN.Name = "rmBTN";
            this.rmBTN.Size = new System.Drawing.Size(217, 51);
            this.rmBTN.TabIndex = 1;
            this.rmBTN.Text = "REMOVE";
            this.rmBTN.UseVisualStyleBackColor = false;
            this.rmBTN.Click += new System.EventHandler(this.rmBTN_Click);
            // 
            // removeScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 466);
            this.Controls.Add(this.rmBTN);
            this.Controls.Add(this.scoreView);
            this.Name = "removeScore";
            this.Text = "Remove Score";
            this.Load += new System.EventHandler(this.removeScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView scoreView;
        private System.Windows.Forms.Button rmBTN;
    }
}