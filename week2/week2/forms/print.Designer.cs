
namespace week2
{
    partial class print
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
            this.printView = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.allrb = new System.Windows.Forms.RadioButton();
            this.malerb = new System.Windows.Forms.RadioButton();
            this.fmalerb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.norb = new System.Windows.Forms.RadioButton();
            this.yesrb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.printView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // printView
            // 
            this.printView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.printView.Location = new System.Drawing.Point(1, 113);
            this.printView.Name = "printView";
            this.printView.RowHeadersWidth = 51;
            this.printView.RowTemplate.Height = 80;
            this.printView.Size = new System.Drawing.Size(1019, 351);
            this.printView.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(227, 498);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(199, 52);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save to text file";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.printBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(504, 498);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(172, 52);
            this.printBtn.TabIndex = 2;
            this.printBtn.Text = "To printer";
            this.printBtn.UseVisualStyleBackColor = false;
            // 
            // allrb
            // 
            this.allrb.AutoSize = true;
            this.allrb.Checked = true;
            this.allrb.Location = new System.Drawing.Point(18, 34);
            this.allrb.Name = "allrb";
            this.allrb.Size = new System.Drawing.Size(44, 21);
            this.allrb.TabIndex = 3;
            this.allrb.TabStop = true;
            this.allrb.Text = "All";
            this.allrb.UseVisualStyleBackColor = true;
            // 
            // malerb
            // 
            this.malerb.AutoSize = true;
            this.malerb.Location = new System.Drawing.Point(89, 34);
            this.malerb.Name = "malerb";
            this.malerb.Size = new System.Drawing.Size(59, 21);
            this.malerb.TabIndex = 4;
            this.malerb.Text = "Male";
            this.malerb.UseVisualStyleBackColor = true;
            // 
            // fmalerb
            // 
            this.fmalerb.AutoSize = true;
            this.fmalerb.Location = new System.Drawing.Point(179, 34);
            this.fmalerb.Name = "fmalerb";
            this.fmalerb.Size = new System.Drawing.Size(75, 21);
            this.fmalerb.TabIndex = 5;
            this.fmalerb.Text = "Female";
            this.fmalerb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.norb);
            this.groupBox1.Controls.Add(this.yesrb);
            this.groupBox1.Location = new System.Drawing.Point(313, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 89);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "and";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(376, 59);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(109, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "BirthDate between:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Use date range:";
            // 
            // norb
            // 
            this.norb.AutoSize = true;
            this.norb.Checked = true;
            this.norb.Location = new System.Drawing.Point(254, 23);
            this.norb.Name = "norb";
            this.norb.Size = new System.Drawing.Size(47, 21);
            this.norb.TabIndex = 1;
            this.norb.TabStop = true;
            this.norb.Text = "No";
            this.norb.UseVisualStyleBackColor = true;
            // 
            // yesrb
            // 
            this.yesrb.AutoSize = true;
            this.yesrb.Location = new System.Drawing.Point(161, 23);
            this.yesrb.Name = "yesrb";
            this.yesrb.Size = new System.Drawing.Size(53, 21);
            this.yesrb.TabIndex = 0;
            this.yesrb.Text = "Yes";
            this.yesrb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fmalerb);
            this.groupBox2.Controls.Add(this.malerb);
            this.groupBox2.Controls.Add(this.allrb);
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 88);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // checkBtn
            // 
            this.checkBtn.BackColor = System.Drawing.Color.Red;
            this.checkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtn.ForeColor = System.Drawing.Color.White;
            this.checkBtn.Location = new System.Drawing.Point(828, 25);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(117, 66);
            this.checkBtn.TabIndex = 8;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = false;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1021, 575);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.printView);
            this.Name = "print";
            this.Text = "Print";
            ((System.ComponentModel.ISupportInitialize)(this.printView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView printView;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.RadioButton allrb;
        private System.Windows.Forms.RadioButton malerb;
        private System.Windows.Forms.RadioButton fmalerb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton norb;
        private System.Windows.Forms.RadioButton yesrb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button checkBtn;
    }
}