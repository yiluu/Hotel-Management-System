namespace IOOP_Group_Assignment
{
    partial class HK_Supplies
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
            this.pnl_Supplies = new System.Windows.Forms.Panel();
            this.radio_Equipment = new System.Windows.Forms.RadioButton();
            this.radio_Cleaning = new System.Windows.Forms.RadioButton();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txtbox_SupplyCount = new System.Windows.Forms.TextBox();
            this.txtbox_SupplyName = new System.Windows.Forms.TextBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lbl_SupplyCount = new System.Windows.Forms.Label();
            this.lbl_SupplyType = new System.Windows.Forms.Label();
            this.lbl_SupplyName = new System.Windows.Forms.Label();
            this.data_Supplies = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SupplyChoose = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_Supplies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Supplies)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Supplies
            // 
            this.pnl_Supplies.Controls.Add(this.btn_Refresh);
            this.pnl_Supplies.Controls.Add(this.btn_SupplyChoose);
            this.pnl_Supplies.Controls.Add(this.radio_Equipment);
            this.pnl_Supplies.Controls.Add(this.radio_Cleaning);
            this.pnl_Supplies.Controls.Add(this.btn_Delete);
            this.pnl_Supplies.Controls.Add(this.txtbox_SupplyCount);
            this.pnl_Supplies.Controls.Add(this.txtbox_SupplyName);
            this.pnl_Supplies.Controls.Add(this.btn_Confirm);
            this.pnl_Supplies.Controls.Add(this.lbl_SupplyCount);
            this.pnl_Supplies.Controls.Add(this.lbl_SupplyType);
            this.pnl_Supplies.Controls.Add(this.lbl_SupplyName);
            this.pnl_Supplies.Location = new System.Drawing.Point(17, 219);
            this.pnl_Supplies.Name = "pnl_Supplies";
            this.pnl_Supplies.Size = new System.Drawing.Size(552, 230);
            this.pnl_Supplies.TabIndex = 15;
            // 
            // radio_Equipment
            // 
            this.radio_Equipment.AutoSize = true;
            this.radio_Equipment.Location = new System.Drawing.Point(131, 94);
            this.radio_Equipment.Name = "radio_Equipment";
            this.radio_Equipment.Size = new System.Drawing.Size(75, 17);
            this.radio_Equipment.TabIndex = 16;
            this.radio_Equipment.TabStop = true;
            this.radio_Equipment.Text = "Equipment";
            this.radio_Equipment.UseVisualStyleBackColor = true;
            this.radio_Equipment.CheckedChanged += new System.EventHandler(this.radio_Equipment_CheckedChanged);
            // 
            // radio_Cleaning
            // 
            this.radio_Cleaning.AutoSize = true;
            this.radio_Cleaning.Location = new System.Drawing.Point(16, 94);
            this.radio_Cleaning.Name = "radio_Cleaning";
            this.radio_Cleaning.Size = new System.Drawing.Size(109, 17);
            this.radio_Cleaning.TabIndex = 15;
            this.radio_Cleaning.TabStop = true;
            this.radio_Cleaning.Text = "Cleaning Supplies";
            this.radio_Cleaning.UseVisualStyleBackColor = true;
            this.radio_Cleaning.CheckedChanged += new System.EventHandler(this.radio_Cleaning_CheckedChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(16, 185);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(119, 29);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Delete Supply";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txtbox_SupplyCount
            // 
            this.txtbox_SupplyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_SupplyCount.Location = new System.Drawing.Point(16, 148);
            this.txtbox_SupplyCount.Name = "txtbox_SupplyCount";
            this.txtbox_SupplyCount.Size = new System.Drawing.Size(519, 26);
            this.txtbox_SupplyCount.TabIndex = 12;
            // 
            // txtbox_SupplyName
            // 
            this.txtbox_SupplyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_SupplyName.Location = new System.Drawing.Point(16, 34);
            this.txtbox_SupplyName.Name = "txtbox_SupplyName";
            this.txtbox_SupplyName.Size = new System.Drawing.Size(519, 26);
            this.txtbox_SupplyName.TabIndex = 10;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(416, 185);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(119, 29);
            this.btn_Confirm.TabIndex = 9;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // lbl_SupplyCount
            // 
            this.lbl_SupplyCount.AutoSize = true;
            this.lbl_SupplyCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SupplyCount.Location = new System.Drawing.Point(12, 126);
            this.lbl_SupplyCount.Name = "lbl_SupplyCount";
            this.lbl_SupplyCount.Size = new System.Drawing.Size(54, 19);
            this.lbl_SupplyCount.TabIndex = 2;
            this.lbl_SupplyCount.Text = "Count:";
            // 
            // lbl_SupplyType
            // 
            this.lbl_SupplyType.AutoSize = true;
            this.lbl_SupplyType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SupplyType.Location = new System.Drawing.Point(12, 65);
            this.lbl_SupplyType.Name = "lbl_SupplyType";
            this.lbl_SupplyType.Size = new System.Drawing.Size(46, 19);
            this.lbl_SupplyType.TabIndex = 1;
            this.lbl_SupplyType.Text = "Type:";
            // 
            // lbl_SupplyName
            // 
            this.lbl_SupplyName.AutoSize = true;
            this.lbl_SupplyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SupplyName.Location = new System.Drawing.Point(12, 12);
            this.lbl_SupplyName.Name = "lbl_SupplyName";
            this.lbl_SupplyName.Size = new System.Drawing.Size(186, 19);
            this.lbl_SupplyName.TabIndex = 0;
            this.lbl_SupplyName.Text = "Supply/Equipment Name:";
            // 
            // data_Supplies
            // 
            this.data_Supplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Supplies.Location = new System.Drawing.Point(17, 60);
            this.data_Supplies.MultiSelect = false;
            this.data_Supplies.Name = "data_Supplies";
            this.data_Supplies.ReadOnly = true;
            this.data_Supplies.RowHeadersWidth = 82;
            this.data_Supplies.Size = new System.Drawing.Size(552, 151);
            this.data_Supplies.TabIndex = 14;
            this.data_Supplies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Supplies_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Manage Supplies";
            // 
            // btn_SupplyChoose
            // 
            this.btn_SupplyChoose.Location = new System.Drawing.Point(416, 3);
            this.btn_SupplyChoose.Name = "btn_SupplyChoose";
            this.btn_SupplyChoose.Size = new System.Drawing.Size(119, 29);
            this.btn_SupplyChoose.TabIndex = 17;
            this.btn_SupplyChoose.Text = "Choose Supply";
            this.btn_SupplyChoose.UseVisualStyleBackColor = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(291, 3);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(119, 29);
            this.btn_Refresh.TabIndex = 18;
            this.btn_Refresh.Text = "Refresh Table";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // HK_Supplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_Supplies);
            this.Controls.Add(this.data_Supplies);
            this.MaximizeBox = false;
            this.Name = "HK_Supplies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplies";
            this.Load += new System.EventHandler(this.HK_Supplies_Load);
            this.pnl_Supplies.ResumeLayout(false);
            this.pnl_Supplies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Supplies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Supplies;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txtbox_SupplyCount;
        private System.Windows.Forms.TextBox txtbox_SupplyName;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label lbl_SupplyCount;
        private System.Windows.Forms.Label lbl_SupplyType;
        private System.Windows.Forms.Label lbl_SupplyName;
        private System.Windows.Forms.DataGridView data_Supplies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_Equipment;
        private System.Windows.Forms.RadioButton radio_Cleaning;
        private System.Windows.Forms.Button btn_SupplyChoose;
        private System.Windows.Forms.Button btn_Refresh;
    }
}