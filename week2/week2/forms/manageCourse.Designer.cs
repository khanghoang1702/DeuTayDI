
namespace week2.forms
{
    partial class manageCourse
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
            this.searchBTN = new System.Windows.Forms.Button();
            this.courseList = new System.Windows.Forms.DataGridView();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.textBoxCId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.searchTXT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseList)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.Purple;
            this.searchBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBTN.ForeColor = System.Drawing.Color.White;
            this.searchBTN.Location = new System.Drawing.Point(1160, 35);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(95, 34);
            this.searchBTN.TabIndex = 58;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // courseList
            // 
            this.courseList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseList.ColumnHeadersHeight = 29;
            this.courseList.Location = new System.Drawing.Point(438, 91);
            this.courseList.Name = "courseList";
            this.courseList.RowHeadersWidth = 51;
            this.courseList.RowTemplate.Height = 80;
            this.courseList.Size = new System.Drawing.Size(853, 596);
            this.courseList.TabIndex = 57;
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Location = new System.Drawing.Point(125, 146);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(173, 22);
            this.textBoxPeriod.TabIndex = 55;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(126, 104);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(172, 22);
            this.textBoxLabel.TabIndex = 54;
            // 
            // textBoxCId
            // 
            this.textBoxCId.Location = new System.Drawing.Point(125, 58);
            this.textBoxCId.Name = "textBoxCId";
            this.textBoxCId.Size = new System.Drawing.Size(94, 22);
            this.textBoxCId.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 52;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Period:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "Label:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Course ID:";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(126, 204);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(276, 153);
            this.textBoxDesc.TabIndex = 59;
            // 
            // searchTXT
            // 
            this.searchTXT.Location = new System.Drawing.Point(950, 43);
            this.searchTXT.Name = "searchTXT";
            this.searchTXT.Size = new System.Drawing.Size(185, 22);
            this.searchTXT.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(638, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 20);
            this.label9.TabIndex = 60;
            this.label9.Text = "Search by Course ID, Label, Period:";
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Red;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(326, 447);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(92, 42);
            this.removeBtn.TabIndex = 64;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(187, 447);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(92, 42);
            this.editBtn.TabIndex = 63;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(43, 447);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 42);
            this.buttonAdd.TabIndex = 62;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // findBtn
            // 
            this.findBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.findBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.ForeColor = System.Drawing.Color.White;
            this.findBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.findBtn.Location = new System.Drawing.Point(248, 49);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 40);
            this.findBtn.TabIndex = 65;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = false;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(1077, 690);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(158, 29);
            this.labelTotal.TabIndex = 66;
            this.labelTotal.Text = "Total Course:";
            // 
            // manageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1328, 757);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.searchTXT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.courseList);
            this.Controls.Add(this.textBoxPeriod);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.textBoxCId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "manageCourse";
            this.Text = "Manage Course";
            ((System.ComponentModel.ISupportInitialize)(this.courseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.DataGridView courseList;
        private System.Windows.Forms.TextBox textBoxPeriod;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.TextBox textBoxCId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox searchTXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Label labelTotal;
    }
}