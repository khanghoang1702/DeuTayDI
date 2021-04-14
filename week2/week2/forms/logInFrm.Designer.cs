
namespace week2
{
    partial class logInFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logInFrm));
            this.logInBTN = new System.Windows.Forms.Button();
            this.accTXTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pwTXTBox = new System.Windows.Forms.TextBox();
            this.regisBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorInput = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInput)).BeginInit();
            this.SuspendLayout();
            // 
            // logInBTN
            // 
            this.logInBTN.BackColor = System.Drawing.Color.Black;
            this.logInBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBTN.ForeColor = System.Drawing.Color.White;
            this.logInBTN.Location = new System.Drawing.Point(453, 344);
            this.logInBTN.Name = "logInBTN";
            this.logInBTN.Size = new System.Drawing.Size(138, 64);
            this.logInBTN.TabIndex = 0;
            this.logInBTN.Text = "Log In";
            this.logInBTN.UseVisualStyleBackColor = false;
            this.logInBTN.Click += new System.EventHandler(this.logInBTN_Click);
            // 
            // accTXTBox
            // 
            this.accTXTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accTXTBox.Location = new System.Drawing.Point(241, 162);
            this.accTXTBox.Name = "accTXTBox";
            this.accTXTBox.Size = new System.Drawing.Size(360, 30);
            this.accTXTBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(103, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(103, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // pwTXTBox
            // 
            this.pwTXTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwTXTBox.Location = new System.Drawing.Point(241, 257);
            this.pwTXTBox.Name = "pwTXTBox";
            this.pwTXTBox.PasswordChar = '*';
            this.pwTXTBox.Size = new System.Drawing.Size(360, 30);
            this.pwTXTBox.TabIndex = 4;
            this.pwTXTBox.UseSystemPasswordChar = true;
            // 
            // regisBTN
            // 
            this.regisBTN.BackColor = System.Drawing.Color.Turquoise;
            this.regisBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regisBTN.ForeColor = System.Drawing.Color.White;
            this.regisBTN.Location = new System.Drawing.Point(284, 344);
            this.regisBTN.Name = "regisBTN";
            this.regisBTN.Size = new System.Drawing.Size(137, 63);
            this.regisBTN.TabIndex = 5;
            this.regisBTN.Text = "Register";
            this.regisBTN.UseVisualStyleBackColor = false;
            this.regisBTN.Click += new System.EventHandler(this.regisBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(179, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 118);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quản Lý Sinh Viên";
            // 
            // errorInput
            // 
            this.errorInput.BlinkRate = 0;
            this.errorInput.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorInput.ContainerControl = this;
            // 
            // logInFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(805, 464);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.regisBTN);
            this.Controls.Add(this.pwTXTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accTXTBox);
            this.Controls.Add(this.logInBTN);
            this.Name = "logInFrm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.logInFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logInBTN;
        private System.Windows.Forms.TextBox accTXTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pwTXTBox;
        private System.Windows.Forms.Button regisBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorInput;
    }
}