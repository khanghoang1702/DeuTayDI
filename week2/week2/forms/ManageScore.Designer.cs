
namespace week2.forms
{
    partial class ManageScore
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
            this.scoreDropDown = new System.Windows.Forms.ComboBox();
            this.scoreView = new System.Windows.Forms.DataGridView();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.textboxScoreDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.textBoxSId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.removeBTN = new System.Windows.Forms.Button();
            this.buttonAVG = new System.Windows.Forms.Button();
            this.showSTDBTN = new System.Windows.Forms.Button();
            this.buttonScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoreView)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreDropDown
            // 
            this.scoreDropDown.FormattingEnabled = true;
            this.scoreDropDown.Location = new System.Drawing.Point(131, 118);
            this.scoreDropDown.Name = "scoreDropDown";
            this.scoreDropDown.Size = new System.Drawing.Size(241, 24);
            this.scoreDropDown.TabIndex = 40;
            // 
            // scoreView
            // 
            this.scoreView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreView.Location = new System.Drawing.Point(564, 72);
            this.scoreView.Name = "scoreView";
            this.scoreView.RowHeadersWidth = 51;
            this.scoreView.RowTemplate.Height = 24;
            this.scoreView.Size = new System.Drawing.Size(629, 501);
            this.scoreView.TabIndex = 39;
            this.scoreView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scoreView_CellContentClick);
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCourseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseBtn.ForeColor = System.Drawing.Color.White;
            this.addCourseBtn.Location = new System.Drawing.Point(75, 428);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(138, 54);
            this.addCourseBtn.TabIndex = 38;
            this.addCourseBtn.Text = "ADD";
            this.addCourseBtn.UseVisualStyleBackColor = false;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
            // 
            // textboxScoreDesc
            // 
            this.textboxScoreDesc.Location = new System.Drawing.Point(131, 251);
            this.textboxScoreDesc.Multiline = true;
            this.textboxScoreDesc.Name = "textboxScoreDesc";
            this.textboxScoreDesc.Size = new System.Drawing.Size(331, 124);
            this.textboxScoreDesc.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Description:";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(131, 180);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(153, 22);
            this.textBoxScore.TabIndex = 35;
            // 
            // textBoxSId
            // 
            this.textBoxSId.Location = new System.Drawing.Point(131, 59);
            this.textBoxSId.Name = "textBoxSId";
            this.textBoxSId.Size = new System.Drawing.Size(102, 22);
            this.textBoxSId.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Course:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Student ID:";
            // 
            // removeBTN
            // 
            this.removeBTN.BackColor = System.Drawing.Color.OrangeRed;
            this.removeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBTN.ForeColor = System.Drawing.Color.White;
            this.removeBTN.Location = new System.Drawing.Point(282, 428);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(138, 54);
            this.removeBTN.TabIndex = 41;
            this.removeBTN.Text = "REMOVE";
            this.removeBTN.UseVisualStyleBackColor = false;
            this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
            // 
            // buttonAVG
            // 
            this.buttonAVG.BackColor = System.Drawing.Color.Olive;
            this.buttonAVG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAVG.ForeColor = System.Drawing.Color.White;
            this.buttonAVG.Location = new System.Drawing.Point(95, 498);
            this.buttonAVG.Name = "buttonAVG";
            this.buttonAVG.Size = new System.Drawing.Size(294, 54);
            this.buttonAVG.TabIndex = 42;
            this.buttonAVG.Text = "Avg Score by Course";
            this.buttonAVG.UseVisualStyleBackColor = false;
            this.buttonAVG.Click += new System.EventHandler(this.buttonAVG_Click);
            // 
            // showSTDBTN
            // 
            this.showSTDBTN.Location = new System.Drawing.Point(637, 23);
            this.showSTDBTN.Name = "showSTDBTN";
            this.showSTDBTN.Size = new System.Drawing.Size(143, 33);
            this.showSTDBTN.TabIndex = 43;
            this.showSTDBTN.Text = "Show Students";
            this.showSTDBTN.UseVisualStyleBackColor = true;
            this.showSTDBTN.Click += new System.EventHandler(this.showSTDBTN_Click);
            // 
            // buttonScore
            // 
            this.buttonScore.Location = new System.Drawing.Point(933, 23);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Size = new System.Drawing.Size(143, 33);
            this.buttonScore.TabIndex = 44;
            this.buttonScore.Text = "Show Score";
            this.buttonScore.UseVisualStyleBackColor = true;
            this.buttonScore.Click += new System.EventHandler(this.buttonScore_Click);
            // 
            // ManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1224, 600);
            this.Controls.Add(this.buttonScore);
            this.Controls.Add(this.showSTDBTN);
            this.Controls.Add(this.buttonAVG);
            this.Controls.Add(this.removeBTN);
            this.Controls.Add(this.scoreDropDown);
            this.Controls.Add(this.scoreView);
            this.Controls.Add(this.addCourseBtn);
            this.Controls.Add(this.textboxScoreDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textBoxSId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageScore";
            this.Text = "Manage Score";
            this.Load += new System.EventHandler(this.ManageScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox scoreDropDown;
        private System.Windows.Forms.DataGridView scoreView;
        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.TextBox textboxScoreDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.TextBox textBoxSId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeBTN;
        private System.Windows.Forms.Button buttonAVG;
        private System.Windows.Forms.Button showSTDBTN;
        private System.Windows.Forms.Button buttonScore;
    }
}