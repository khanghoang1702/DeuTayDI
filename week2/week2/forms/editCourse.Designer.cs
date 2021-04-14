
namespace week2.forms
{
    partial class editCourse
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
            this.editCourseBtn = new System.Windows.Forms.Button();
            this.textboxCDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.numericUpDownPeriod = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // editCourseBtn
            // 
            this.editCourseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editCourseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCourseBtn.ForeColor = System.Drawing.Color.White;
            this.editCourseBtn.Location = new System.Drawing.Point(242, 373);
            this.editCourseBtn.Name = "editCourseBtn";
            this.editCourseBtn.Size = new System.Drawing.Size(319, 54);
            this.editCourseBtn.TabIndex = 28;
            this.editCourseBtn.Text = "UPDATE";
            this.editCourseBtn.UseVisualStyleBackColor = false;
            this.editCourseBtn.Click += new System.EventHandler(this.editCourseBtn_Click);
            // 
            // textboxCDesc
            // 
            this.textboxCDesc.Location = new System.Drawing.Point(290, 225);
            this.textboxCDesc.Multiline = true;
            this.textboxCDesc.Name = "textboxCDesc";
            this.textboxCDesc.Size = new System.Drawing.Size(331, 124);
            this.textboxCDesc.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(132, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Description:";
            // 
            // textBoxCName
            // 
            this.textBoxCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCName.Location = new System.Drawing.Point(290, 92);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.Size = new System.Drawing.Size(248, 28);
            this.textBoxCName.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(171, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Period:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(180, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Label:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select course:";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(290, 31);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(192, 30);
            this.comboBoxCourse.TabIndex = 29;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // numericUpDownPeriod
            // 
            this.numericUpDownPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPeriod.Location = new System.Drawing.Point(290, 157);
            this.numericUpDownPeriod.Name = "numericUpDownPeriod";
            this.numericUpDownPeriod.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownPeriod.TabIndex = 30;
            // 
            // editCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.numericUpDownPeriod);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.editCourseBtn);
            this.Controls.Add(this.textboxCDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editCourse";
            this.Text = "EDIT COURSE";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editCourseBtn;
        private System.Windows.Forms.TextBox textboxCDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.NumericUpDown numericUpDownPeriod;
    }
}