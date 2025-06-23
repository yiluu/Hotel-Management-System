namespace IOOP_Group_Assignment
{
    partial class HK_IssueReport
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
            this.txtbox_Notes = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_RoomNum = new System.Windows.Forms.Label();
            this.btn_Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_Notes
            // 
            this.txtbox_Notes.Location = new System.Drawing.Point(24, 60);
            this.txtbox_Notes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtbox_Notes.Multiline = true;
            this.txtbox_Notes.Name = "txtbox_Notes";
            this.txtbox_Notes.Size = new System.Drawing.Size(1116, 558);
            this.txtbox_Notes.TabIndex = 0;
            this.txtbox_Notes.TextChanged += new System.EventHandler(this.txtbox_Notes_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_RoomNum
            // 
            this.lbl_RoomNum.AutoSize = true;
            this.lbl_RoomNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoomNum.Location = new System.Drawing.Point(22, 13);
            this.lbl_RoomNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_RoomNum.Name = "lbl_RoomNum";
            this.lbl_RoomNum.Size = new System.Drawing.Size(225, 39);
            this.lbl_RoomNum.TabIndex = 2;
            this.lbl_RoomNum.Text = "Room Number: ";
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(906, 633);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(238, 56);
            this.btn_Report.TabIndex = 9;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // HK_IssueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 694);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.lbl_RoomNum);
            this.Controls.Add(this.txtbox_Notes);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "HK_IssueReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Report";
            this.Load += new System.EventHandler(this.HK_IssueReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_Notes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_RoomNum;
        private System.Windows.Forms.Button btn_Report;
    }
}