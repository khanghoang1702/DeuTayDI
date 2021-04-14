
namespace week2.forms
{
    partial class remove
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCId = new System.Windows.Forms.TextBox();
            this.removeBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Course ID:";
            // 
            // textBoxCId
            // 
            this.textBoxCId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCId.Location = new System.Drawing.Point(285, 42);
            this.textBoxCId.Name = "textBoxCId";
            this.textBoxCId.Size = new System.Drawing.Size(218, 27);
            this.textBoxCId.TabIndex = 1;
            // 
            // removeBTN
            // 
            this.removeBTN.BackColor = System.Drawing.Color.Red;
            this.removeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBTN.ForeColor = System.Drawing.Color.White;
            this.removeBTN.Location = new System.Drawing.Point(557, 33);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(148, 52);
            this.removeBTN.TabIndex = 2;
            this.removeBTN.Text = "Remove";
            this.removeBTN.UseVisualStyleBackColor = false;
            this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
            // 
            // remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 126);
            this.Controls.Add(this.removeBTN);
            this.Controls.Add(this.textBoxCId);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "remove";
            this.Text = "Remove Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCId;
        private System.Windows.Forms.Button removeBTN;
    }
}