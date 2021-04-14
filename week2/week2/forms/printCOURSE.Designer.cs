
namespace week2.forms
{
    partial class printCOURSE
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
            this.btnPrintC = new System.Windows.Forms.Button();
            this.dGVCourse = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.courseDropDown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrintC
            // 
            this.btnPrintC.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintC.ForeColor = System.Drawing.Color.White;
            this.btnPrintC.Location = new System.Drawing.Point(404, 532);
            this.btnPrintC.Name = "btnPrintC";
            this.btnPrintC.Size = new System.Drawing.Size(152, 56);
            this.btnPrintC.TabIndex = 0;
            this.btnPrintC.Text = "Save to Word";
            this.btnPrintC.UseVisualStyleBackColor = false;
            this.btnPrintC.Click += new System.EventHandler(this.btnPrintC_Click);
            // 
            // dGVCourse
            // 
            this.dGVCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCourse.Location = new System.Drawing.Point(19, 63);
            this.dGVCourse.Name = "dGVCourse";
            this.dGVCourse.RowHeadersWidth = 51;
            this.dGVCourse.RowTemplate.Height = 24;
            this.dGVCourse.Size = new System.Drawing.Size(918, 457);
            this.dGVCourse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Courses:";
            // 
            // courseDropDown
            // 
            this.courseDropDown.FormattingEnabled = true;
            this.courseDropDown.Location = new System.Drawing.Point(183, 25);
            this.courseDropDown.Name = "courseDropDown";
            this.courseDropDown.Size = new System.Drawing.Size(272, 24);
            this.courseDropDown.TabIndex = 3;
            this.courseDropDown.SelectedIndexChanged += new System.EventHandler(this.courseDropDown_SelectedIndexChanged);
            // 
            // printCOURSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(956, 600);
            this.Controls.Add(this.courseDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVCourse);
            this.Controls.Add(this.btnPrintC);
            this.Name = "printCOURSE";
            this.Text = "PRINT COURSE";
            this.Load += new System.EventHandler(this.printCOURSE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintC;
        private System.Windows.Forms.DataGridView dGVCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox courseDropDown;
    }
}