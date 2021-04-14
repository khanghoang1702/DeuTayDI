
namespace week2
{
    partial class Form1
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
            System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
            this.aDDNEWSTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDCOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITREMOVECOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGECOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stdList = new System.Windows.Forms.DataGridView();
            this.refreshBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTXT = new System.Windows.Forms.TextBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.aDDSCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEMOVESCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGESCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aVGSCOREBYCOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTRESULTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdList)).BeginInit();
            this.SuspendLayout();
            // 
            // sTUDENTToolStripMenuItem
            // 
            sTUDENTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWSTUDENTToolStripMenuItem,
            this.sTUDENTLISTToolStripMenuItem,
            this.staticsToolStripMenuItem,
            this.editRemoveToolStripMenuItem,
            this.manageStudentFormToolStripMenuItem,
            this.printToolStripMenuItem});
            sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            sTUDENTToolStripMenuItem.Text = "STUDENT";
            // 
            // aDDNEWSTUDENTToolStripMenuItem
            // 
            this.aDDNEWSTUDENTToolStripMenuItem.Name = "aDDNEWSTUDENTToolStripMenuItem";
            this.aDDNEWSTUDENTToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.aDDNEWSTUDENTToolStripMenuItem.Text = "Add New Student";
            this.aDDNEWSTUDENTToolStripMenuItem.Click += new System.EventHandler(this.aDDNEWSTUDENTToolStripMenuItem_Click);
            // 
            // sTUDENTLISTToolStripMenuItem
            // 
            this.sTUDENTLISTToolStripMenuItem.Name = "sTUDENTLISTToolStripMenuItem";
            this.sTUDENTLISTToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.sTUDENTLISTToolStripMenuItem.Text = "Student List";
            this.sTUDENTLISTToolStripMenuItem.Click += new System.EventHandler(this.sTUDENTLISTToolStripMenuItem_Click);
            // 
            // staticsToolStripMenuItem
            // 
            this.staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            this.staticsToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.staticsToolStripMenuItem.Text = "Statics";
            this.staticsToolStripMenuItem.Click += new System.EventHandler(this.staticsToolStripMenuItem_Click);
            // 
            // editRemoveToolStripMenuItem
            // 
            this.editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            this.editRemoveToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.editRemoveToolStripMenuItem.Text = "Edit/Remove";
            this.editRemoveToolStripMenuItem.Click += new System.EventHandler(this.editRemoveToolStripMenuItem_Click);
            // 
            // manageStudentFormToolStripMenuItem
            // 
            this.manageStudentFormToolStripMenuItem.Name = "manageStudentFormToolStripMenuItem";
            this.manageStudentFormToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.manageStudentFormToolStripMenuItem.Text = "Manage Student Form";
            this.manageStudentFormToolStripMenuItem.Click += new System.EventHandler(this.manageStudentFormToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            sTUDENTToolStripMenuItem,
            this.cOURSEToolStripMenuItem,
            this.sCOREToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cOURSEToolStripMenuItem
            // 
            this.cOURSEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDCOURSEToolStripMenuItem,
            this.eDITREMOVECOURSEToolStripMenuItem,
            this.mANAGECOURSEToolStripMenuItem,
            this.pRINTToolStripMenuItem1,
            this.pRINTToolStripMenuItem2});
            this.cOURSEToolStripMenuItem.Name = "cOURSEToolStripMenuItem";
            this.cOURSEToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.cOURSEToolStripMenuItem.Text = "COURSE";
            // 
            // aDDCOURSEToolStripMenuItem
            // 
            this.aDDCOURSEToolStripMenuItem.Name = "aDDCOURSEToolStripMenuItem";
            this.aDDCOURSEToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.aDDCOURSEToolStripMenuItem.Text = "ADD COURSE";
            this.aDDCOURSEToolStripMenuItem.Click += new System.EventHandler(this.aDDCOURSEToolStripMenuItem_Click);
            // 
            // eDITREMOVECOURSEToolStripMenuItem
            // 
            this.eDITREMOVECOURSEToolStripMenuItem.Name = "eDITREMOVECOURSEToolStripMenuItem";
            this.eDITREMOVECOURSEToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.eDITREMOVECOURSEToolStripMenuItem.Text = "REMOVE COURSE";
            this.eDITREMOVECOURSEToolStripMenuItem.Click += new System.EventHandler(this.eDITREMOVECOURSEToolStripMenuItem_Click);
            // 
            // mANAGECOURSEToolStripMenuItem
            // 
            this.mANAGECOURSEToolStripMenuItem.Name = "mANAGECOURSEToolStripMenuItem";
            this.mANAGECOURSEToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.mANAGECOURSEToolStripMenuItem.Text = "EDIT COURSE";
            this.mANAGECOURSEToolStripMenuItem.Click += new System.EventHandler(this.mANAGECOURSEToolStripMenuItem_Click);
            // 
            // pRINTToolStripMenuItem1
            // 
            this.pRINTToolStripMenuItem1.Name = "pRINTToolStripMenuItem1";
            this.pRINTToolStripMenuItem1.Size = new System.Drawing.Size(213, 26);
            this.pRINTToolStripMenuItem1.Text = "MANAGE COURSE";
            this.pRINTToolStripMenuItem1.Click += new System.EventHandler(this.pRINTToolStripMenuItem1_Click);
            // 
            // pRINTToolStripMenuItem2
            // 
            this.pRINTToolStripMenuItem2.Name = "pRINTToolStripMenuItem2";
            this.pRINTToolStripMenuItem2.Size = new System.Drawing.Size(213, 26);
            this.pRINTToolStripMenuItem2.Text = "PRINT";
            this.pRINTToolStripMenuItem2.Click += new System.EventHandler(this.pRINTToolStripMenuItem2_Click);
            // 
            // sCOREToolStripMenuItem
            // 
            this.sCOREToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDSCOREToolStripMenuItem,
            this.rEMOVESCOREToolStripMenuItem,
            this.mANAGESCOREToolStripMenuItem,
            this.aVGSCOREBYCOURSEToolStripMenuItem,
            this.pRINTRESULTToolStripMenuItem});
            this.sCOREToolStripMenuItem.Name = "sCOREToolStripMenuItem";
            this.sCOREToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.sCOREToolStripMenuItem.Text = "SCORE";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // stdList
            // 
            this.stdList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stdList.ColumnHeadersHeight = 29;
            this.stdList.Location = new System.Drawing.Point(17, 99);
            this.stdList.Name = "stdList";
            this.stdList.RowHeadersWidth = 51;
            this.stdList.RowTemplate.Height = 80;
            this.stdList.Size = new System.Drawing.Size(1077, 552);
            this.stdList.TabIndex = 1;
            this.stdList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stdList_CellContentClick);
            // 
            // refreshBTN
            // 
            this.refreshBTN.BackColor = System.Drawing.Color.LightGreen;
            this.refreshBTN.Location = new System.Drawing.Point(500, 668);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(159, 43);
            this.refreshBTN.TabIndex = 2;
            this.refreshBTN.Text = "Refresh";
            this.refreshBTN.UseVisualStyleBackColor = false;
            this.refreshBTN.Click += new System.EventHandler(this.refreshBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search student by ID:";
            // 
            // searchTXT
            // 
            this.searchTXT.Location = new System.Drawing.Point(779, 45);
            this.searchTXT.Name = "searchTXT";
            this.searchTXT.Size = new System.Drawing.Size(185, 22);
            this.searchTXT.TabIndex = 4;
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.Purple;
            this.searchBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBTN.ForeColor = System.Drawing.Color.White;
            this.searchBTN.Location = new System.Drawing.Point(993, 39);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(66, 34);
            this.searchBTN.TabIndex = 5;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // aDDSCOREToolStripMenuItem
            // 
            this.aDDSCOREToolStripMenuItem.Name = "aDDSCOREToolStripMenuItem";
            this.aDDSCOREToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.aDDSCOREToolStripMenuItem.Text = "ADD SCORE";
            this.aDDSCOREToolStripMenuItem.Click += new System.EventHandler(this.aDDSCOREToolStripMenuItem_Click);
            // 
            // rEMOVESCOREToolStripMenuItem
            // 
            this.rEMOVESCOREToolStripMenuItem.Name = "rEMOVESCOREToolStripMenuItem";
            this.rEMOVESCOREToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.rEMOVESCOREToolStripMenuItem.Text = "REMOVE SCORE";
            this.rEMOVESCOREToolStripMenuItem.Click += new System.EventHandler(this.rEMOVESCOREToolStripMenuItem_Click);
            // 
            // mANAGESCOREToolStripMenuItem
            // 
            this.mANAGESCOREToolStripMenuItem.Name = "mANAGESCOREToolStripMenuItem";
            this.mANAGESCOREToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.mANAGESCOREToolStripMenuItem.Text = "MANAGE SCORE";
            this.mANAGESCOREToolStripMenuItem.Click += new System.EventHandler(this.mANAGESCOREToolStripMenuItem_Click);
            // 
            // aVGSCOREBYCOURSEToolStripMenuItem
            // 
            this.aVGSCOREBYCOURSEToolStripMenuItem.Name = "aVGSCOREBYCOURSEToolStripMenuItem";
            this.aVGSCOREBYCOURSEToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.aVGSCOREBYCOURSEToolStripMenuItem.Text = "AVG SCORE BY COURSE";
            this.aVGSCOREBYCOURSEToolStripMenuItem.Click += new System.EventHandler(this.aVGSCOREBYCOURSEToolStripMenuItem_Click);
            // 
            // pRINTRESULTToolStripMenuItem
            // 
            this.pRINTRESULTToolStripMenuItem.Name = "pRINTRESULTToolStripMenuItem";
            this.pRINTRESULTToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.pRINTRESULTToolStripMenuItem.Text = "PRINT RESULT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1108, 733);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshBTN);
            this.Controls.Add(this.stdList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWSTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTLISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCOREToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView stdList;
        private System.Windows.Forms.Button refreshBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTXT;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.ToolStripMenuItem aDDCOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITREMOVECOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGECOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aDDSCOREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEMOVESCOREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGESCOREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aVGSCOREBYCOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRINTRESULTToolStripMenuItem;
    }
}

