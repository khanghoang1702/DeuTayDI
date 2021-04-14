
namespace week2.forms
{
    partial class addScore
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
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.textboxScoreDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.textBoxSId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreView = new System.Windows.Forms.DataGridView();
            this.scoreDropDown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.scoreView)).BeginInit();
            this.SuspendLayout();
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.BackColor = System.Drawing.Color.Tan;
            this.addCourseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseBtn.ForeColor = System.Drawing.Color.White;
            this.addCourseBtn.Location = new System.Drawing.Point(120, 413);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(319, 54);
            this.addCourseBtn.TabIndex = 28;
            this.addCourseBtn.Text = "ADD";
            this.addCourseBtn.UseVisualStyleBackColor = false;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
            // 
            // textboxScoreDesc
            // 
            this.textboxScoreDesc.Location = new System.Drawing.Point(152, 257);
            this.textboxScoreDesc.Multiline = true;
            this.textboxScoreDesc.Name = "textboxScoreDesc";
            this.textboxScoreDesc.Size = new System.Drawing.Size(331, 124);
            this.textboxScoreDesc.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Description:";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(152, 186);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(153, 22);
            this.textBoxScore.TabIndex = 25;
            // 
            // textBoxSId
            // 
            this.textBoxSId.Location = new System.Drawing.Point(152, 65);
            this.textBoxSId.Name = "textBoxSId";
            this.textBoxSId.Size = new System.Drawing.Size(102, 22);
            this.textBoxSId.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Course:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Student ID:";
            // 
            // scoreView
            // 
            this.scoreView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreView.Location = new System.Drawing.Point(582, 43);
            this.scoreView.Name = "scoreView";
            this.scoreView.RowHeadersWidth = 51;
            this.scoreView.RowTemplate.Height = 24;
            this.scoreView.Size = new System.Drawing.Size(714, 456);
            this.scoreView.TabIndex = 29;
            // 
            // scoreDropDown
            // 
            this.scoreDropDown.FormattingEnabled = true;
            this.scoreDropDown.Location = new System.Drawing.Point(152, 124);
            this.scoreDropDown.Name = "scoreDropDown";
            this.scoreDropDown.Size = new System.Drawing.Size(241, 24);
            this.scoreDropDown.TabIndex = 30;
            
            // 
            // addScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1313, 523);
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
            this.Name = "addScore";
            this.Text = "Add Score";
            this.Load += new System.EventHandler(this.addScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.TextBox textboxScoreDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.TextBox textBoxSId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView scoreView;
        private System.Windows.Forms.ComboBox scoreDropDown;
    }
}