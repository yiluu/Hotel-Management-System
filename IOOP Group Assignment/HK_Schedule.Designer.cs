namespace IOOP_Group_Assignment
{
    partial class HK_Schedule
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
            this.tab_Schedule = new System.Windows.Forms.TabControl();
            this.tabClnSchdl = new System.Windows.Forms.TabPage();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.data_RoomCleaning = new System.Windows.Forms.DataGridView();
            this.pnl_RoomDetailView = new System.Windows.Forms.Panel();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_MarkDirty = new System.Windows.Forms.Button();
            this.btn_MarkClean = new System.Windows.Forms.Button();
            this.lbl_Condition = new System.Windows.Forms.Label();
            this.lbl_Availability = new System.Windows.Forms.Label();
            this.lbl_RoomNum = new System.Windows.Forms.Label();
            this.btn_RoomChoose = new System.Windows.Forms.Button();
            this.cal_Cleaning = new System.Windows.Forms.MonthCalendar();
            this.tabReservations = new System.Windows.Forms.TabPage();
            this.btn_Refresh2 = new System.Windows.Forms.Button();
            this.data_Reservations = new System.Windows.Forms.DataGridView();
            this.pnl_RoomDetailView2 = new System.Windows.Forms.Panel();
            this.lbl_Warning = new System.Windows.Forms.Label();
            this.btn_Report2 = new System.Windows.Forms.Button();
            this.btn_MarkPrepared = new System.Windows.Forms.Button();
            this.lbl_Condition2 = new System.Windows.Forms.Label();
            this.lbl_Checkin = new System.Windows.Forms.Label();
            this.lbl_RoomNum2 = new System.Windows.Forms.Label();
            this.btn_RoomChoose2 = new System.Windows.Forms.Button();
            this.cal_Reservations = new System.Windows.Forms.MonthCalendar();
            this.tab_Schedule.SuspendLayout();
            this.tabClnSchdl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_RoomCleaning)).BeginInit();
            this.pnl_RoomDetailView.SuspendLayout();
            this.tabReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Reservations)).BeginInit();
            this.pnl_RoomDetailView2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Schedule
            // 
            this.tab_Schedule.Controls.Add(this.tabClnSchdl);
            this.tab_Schedule.Controls.Add(this.tabReservations);
            this.tab_Schedule.Location = new System.Drawing.Point(5, 9);
            this.tab_Schedule.Name = "tab_Schedule";
            this.tab_Schedule.SelectedIndex = 0;
            this.tab_Schedule.Size = new System.Drawing.Size(573, 448);
            this.tab_Schedule.TabIndex = 0;
            // 
            // tabClnSchdl
            // 
            this.tabClnSchdl.BackColor = System.Drawing.Color.White;
            this.tabClnSchdl.Controls.Add(this.btn_Refresh);
            this.tabClnSchdl.Controls.Add(this.data_RoomCleaning);
            this.tabClnSchdl.Controls.Add(this.pnl_RoomDetailView);
            this.tabClnSchdl.Controls.Add(this.btn_RoomChoose);
            this.tabClnSchdl.Controls.Add(this.cal_Cleaning);
            this.tabClnSchdl.Location = new System.Drawing.Point(4, 22);
            this.tabClnSchdl.Name = "tabClnSchdl";
            this.tabClnSchdl.Padding = new System.Windows.Forms.Padding(3);
            this.tabClnSchdl.Size = new System.Drawing.Size(565, 422);
            this.tabClnSchdl.TabIndex = 0;
            this.tabClnSchdl.Text = "Cleaning Schedule";
            this.tabClnSchdl.Click += new System.EventHandler(this.tabClnSchdl_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Refresh.Location = new System.Drawing.Point(315, 202);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(119, 29);
            this.btn_Refresh.TabIndex = 17;
            this.btn_Refresh.Text = "Refresh Table";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // data_RoomCleaning
            // 
            this.data_RoomCleaning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_RoomCleaning.Location = new System.Drawing.Point(6, 6);
            this.data_RoomCleaning.MultiSelect = false;
            this.data_RoomCleaning.Name = "data_RoomCleaning";
            this.data_RoomCleaning.ReadOnly = true;
            this.data_RoomCleaning.RowHeadersWidth = 82;
            this.data_RoomCleaning.Size = new System.Drawing.Size(553, 191);
            this.data_RoomCleaning.TabIndex = 11;
            // 
            // pnl_RoomDetailView
            // 
            this.pnl_RoomDetailView.Controls.Add(this.btn_Report);
            this.pnl_RoomDetailView.Controls.Add(this.btn_MarkDirty);
            this.pnl_RoomDetailView.Controls.Add(this.btn_MarkClean);
            this.pnl_RoomDetailView.Controls.Add(this.lbl_Condition);
            this.pnl_RoomDetailView.Controls.Add(this.lbl_Availability);
            this.pnl_RoomDetailView.Controls.Add(this.lbl_RoomNum);
            this.pnl_RoomDetailView.Location = new System.Drawing.Point(6, 203);
            this.pnl_RoomDetailView.Name = "pnl_RoomDetailView";
            this.pnl_RoomDetailView.Size = new System.Drawing.Size(292, 213);
            this.pnl_RoomDetailView.TabIndex = 10;
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(3, 181);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(119, 29);
            this.btn_Report.TabIndex = 10;
            this.btn_Report.Text = "Report Issue";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_MarkDirty
            // 
            this.btn_MarkDirty.Location = new System.Drawing.Point(169, 181);
            this.btn_MarkDirty.Name = "btn_MarkDirty";
            this.btn_MarkDirty.Size = new System.Drawing.Size(119, 29);
            this.btn_MarkDirty.TabIndex = 9;
            this.btn_MarkDirty.Text = "Mark Dirty";
            this.btn_MarkDirty.UseVisualStyleBackColor = true;
            this.btn_MarkDirty.Click += new System.EventHandler(this.btn_MarkDirty_Click);
            // 
            // btn_MarkClean
            // 
            this.btn_MarkClean.Location = new System.Drawing.Point(169, 146);
            this.btn_MarkClean.Name = "btn_MarkClean";
            this.btn_MarkClean.Size = new System.Drawing.Size(119, 29);
            this.btn_MarkClean.TabIndex = 8;
            this.btn_MarkClean.Text = "Mark Cleaned";
            this.btn_MarkClean.UseVisualStyleBackColor = true;
            this.btn_MarkClean.Click += new System.EventHandler(this.btn_MarkClean_Click);
            // 
            // lbl_Condition
            // 
            this.lbl_Condition.AutoSize = true;
            this.lbl_Condition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Condition.Location = new System.Drawing.Point(12, 65);
            this.lbl_Condition.Name = "lbl_Condition";
            this.lbl_Condition.Size = new System.Drawing.Size(79, 19);
            this.lbl_Condition.TabIndex = 2;
            this.lbl_Condition.Text = "Condition:";
            // 
            // lbl_Availability
            // 
            this.lbl_Availability.AutoSize = true;
            this.lbl_Availability.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Availability.Location = new System.Drawing.Point(12, 37);
            this.lbl_Availability.Name = "lbl_Availability";
            this.lbl_Availability.Size = new System.Drawing.Size(90, 19);
            this.lbl_Availability.TabIndex = 1;
            this.lbl_Availability.Text = "Availability:";
            // 
            // lbl_RoomNum
            // 
            this.lbl_RoomNum.AutoSize = true;
            this.lbl_RoomNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoomNum.Location = new System.Drawing.Point(12, 9);
            this.lbl_RoomNum.Name = "lbl_RoomNum";
            this.lbl_RoomNum.Size = new System.Drawing.Size(117, 19);
            this.lbl_RoomNum.TabIndex = 0;
            this.lbl_RoomNum.Text = "Room Number: ";
            // 
            // btn_RoomChoose
            // 
            this.btn_RoomChoose.BackColor = System.Drawing.SystemColors.Window;
            this.btn_RoomChoose.Location = new System.Drawing.Point(440, 202);
            this.btn_RoomChoose.Name = "btn_RoomChoose";
            this.btn_RoomChoose.Size = new System.Drawing.Size(119, 29);
            this.btn_RoomChoose.TabIndex = 9;
            this.btn_RoomChoose.Text = "Choose Room";
            this.btn_RoomChoose.UseVisualStyleBackColor = false;
            this.btn_RoomChoose.Click += new System.EventHandler(this.btn_RoomChoose_Click);
            // 
            // cal_Cleaning
            // 
            this.cal_Cleaning.Location = new System.Drawing.Point(332, 254);
            this.cal_Cleaning.MaxSelectionCount = 1;
            this.cal_Cleaning.Name = "cal_Cleaning";
            this.cal_Cleaning.TabIndex = 8;
            this.cal_Cleaning.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cal_Cleaning_DateChanged);
            // 
            // tabReservations
            // 
            this.tabReservations.BackColor = System.Drawing.Color.White;
            this.tabReservations.Controls.Add(this.btn_Refresh2);
            this.tabReservations.Controls.Add(this.data_Reservations);
            this.tabReservations.Controls.Add(this.pnl_RoomDetailView2);
            this.tabReservations.Controls.Add(this.btn_RoomChoose2);
            this.tabReservations.Controls.Add(this.cal_Reservations);
            this.tabReservations.Location = new System.Drawing.Point(4, 22);
            this.tabReservations.Name = "tabReservations";
            this.tabReservations.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservations.Size = new System.Drawing.Size(565, 422);
            this.tabReservations.TabIndex = 1;
            this.tabReservations.Text = "Upcoming Reservations";
            this.tabReservations.Click += new System.EventHandler(this.tabReservations_Click);
            // 
            // btn_Refresh2
            // 
            this.btn_Refresh2.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Refresh2.Location = new System.Drawing.Point(315, 202);
            this.btn_Refresh2.Name = "btn_Refresh2";
            this.btn_Refresh2.Size = new System.Drawing.Size(119, 29);
            this.btn_Refresh2.TabIndex = 16;
            this.btn_Refresh2.Text = "Refresh Table";
            this.btn_Refresh2.UseVisualStyleBackColor = false;
            this.btn_Refresh2.Click += new System.EventHandler(this.btn_Refresh2_Click);
            // 
            // data_Reservations
            // 
            this.data_Reservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Reservations.Location = new System.Drawing.Point(6, 6);
            this.data_Reservations.MultiSelect = false;
            this.data_Reservations.Name = "data_Reservations";
            this.data_Reservations.ReadOnly = true;
            this.data_Reservations.RowHeadersWidth = 82;
            this.data_Reservations.Size = new System.Drawing.Size(553, 191);
            this.data_Reservations.TabIndex = 15;
            // 
            // pnl_RoomDetailView2
            // 
            this.pnl_RoomDetailView2.Controls.Add(this.lbl_Warning);
            this.pnl_RoomDetailView2.Controls.Add(this.btn_Report2);
            this.pnl_RoomDetailView2.Controls.Add(this.btn_MarkPrepared);
            this.pnl_RoomDetailView2.Controls.Add(this.lbl_Condition2);
            this.pnl_RoomDetailView2.Controls.Add(this.lbl_Checkin);
            this.pnl_RoomDetailView2.Controls.Add(this.lbl_RoomNum2);
            this.pnl_RoomDetailView2.Location = new System.Drawing.Point(6, 203);
            this.pnl_RoomDetailView2.Name = "pnl_RoomDetailView2";
            this.pnl_RoomDetailView2.Size = new System.Drawing.Size(292, 213);
            this.pnl_RoomDetailView2.TabIndex = 14;
            // 
            // lbl_Warning
            // 
            this.lbl_Warning.AutoSize = true;
            this.lbl_Warning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Warning.Location = new System.Drawing.Point(13, 94);
            this.lbl_Warning.Name = "lbl_Warning";
            this.lbl_Warning.Size = new System.Drawing.Size(0, 13);
            this.lbl_Warning.TabIndex = 13;
            // 
            // btn_Report2
            // 
            this.btn_Report2.Location = new System.Drawing.Point(3, 181);
            this.btn_Report2.Name = "btn_Report2";
            this.btn_Report2.Size = new System.Drawing.Size(119, 29);
            this.btn_Report2.TabIndex = 10;
            this.btn_Report2.Text = "Report Issue";
            this.btn_Report2.UseVisualStyleBackColor = true;
            // 
            // btn_MarkPrepared
            // 
            this.btn_MarkPrepared.Location = new System.Drawing.Point(169, 181);
            this.btn_MarkPrepared.Name = "btn_MarkPrepared";
            this.btn_MarkPrepared.Size = new System.Drawing.Size(119, 29);
            this.btn_MarkPrepared.TabIndex = 8;
            this.btn_MarkPrepared.Text = "Mark Prepared";
            this.btn_MarkPrepared.UseVisualStyleBackColor = true;
            this.btn_MarkPrepared.Click += new System.EventHandler(this.btn_MarkPrepared_Click);
            // 
            // lbl_Condition2
            // 
            this.lbl_Condition2.AutoSize = true;
            this.lbl_Condition2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Condition2.Location = new System.Drawing.Point(12, 65);
            this.lbl_Condition2.Name = "lbl_Condition2";
            this.lbl_Condition2.Size = new System.Drawing.Size(79, 19);
            this.lbl_Condition2.TabIndex = 2;
            this.lbl_Condition2.Text = "Condition:";
            // 
            // lbl_Checkin
            // 
            this.lbl_Checkin.AutoSize = true;
            this.lbl_Checkin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Checkin.Location = new System.Drawing.Point(12, 37);
            this.lbl_Checkin.Name = "lbl_Checkin";
            this.lbl_Checkin.Size = new System.Drawing.Size(107, 19);
            this.lbl_Checkin.TabIndex = 1;
            this.lbl_Checkin.Text = "Check-in Time:";
            // 
            // lbl_RoomNum2
            // 
            this.lbl_RoomNum2.AutoSize = true;
            this.lbl_RoomNum2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoomNum2.Location = new System.Drawing.Point(12, 9);
            this.lbl_RoomNum2.Name = "lbl_RoomNum2";
            this.lbl_RoomNum2.Size = new System.Drawing.Size(117, 19);
            this.lbl_RoomNum2.TabIndex = 0;
            this.lbl_RoomNum2.Text = "Room Number: ";
            // 
            // btn_RoomChoose2
            // 
            this.btn_RoomChoose2.BackColor = System.Drawing.SystemColors.Window;
            this.btn_RoomChoose2.Location = new System.Drawing.Point(440, 202);
            this.btn_RoomChoose2.Name = "btn_RoomChoose2";
            this.btn_RoomChoose2.Size = new System.Drawing.Size(119, 29);
            this.btn_RoomChoose2.TabIndex = 13;
            this.btn_RoomChoose2.Text = "Choose Room";
            this.btn_RoomChoose2.UseVisualStyleBackColor = false;
            this.btn_RoomChoose2.Click += new System.EventHandler(this.btn_RoomChoose2_Click);
            // 
            // cal_Reservations
            // 
            this.cal_Reservations.Location = new System.Drawing.Point(332, 254);
            this.cal_Reservations.MaxSelectionCount = 1;
            this.cal_Reservations.Name = "cal_Reservations";
            this.cal_Reservations.TabIndex = 12;
            this.cal_Reservations.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cal_Reservations_DateChanged);
            // 
            // HK_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.tab_Schedule);
            this.MaximizeBox = false;
            this.Name = "HK_Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.tab_Schedule.ResumeLayout(false);
            this.tabClnSchdl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_RoomCleaning)).EndInit();
            this.pnl_RoomDetailView.ResumeLayout(false);
            this.pnl_RoomDetailView.PerformLayout();
            this.tabReservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_Reservations)).EndInit();
            this.pnl_RoomDetailView2.ResumeLayout(false);
            this.pnl_RoomDetailView2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Schedule;
        private System.Windows.Forms.TabPage tabClnSchdl;
        private System.Windows.Forms.DataGridView data_RoomCleaning;
        private System.Windows.Forms.Panel pnl_RoomDetailView;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_MarkDirty;
        private System.Windows.Forms.Button btn_MarkClean;
        private System.Windows.Forms.Label lbl_Condition;
        private System.Windows.Forms.Label lbl_Availability;
        private System.Windows.Forms.Label lbl_RoomNum;
        private System.Windows.Forms.Button btn_RoomChoose;
        private System.Windows.Forms.MonthCalendar cal_Cleaning;
        private System.Windows.Forms.TabPage tabReservations;
        private System.Windows.Forms.DataGridView data_Reservations;
        private System.Windows.Forms.Panel pnl_RoomDetailView2;
        private System.Windows.Forms.Button btn_Report2;
        private System.Windows.Forms.Button btn_MarkPrepared;
        private System.Windows.Forms.Label lbl_Condition2;
        private System.Windows.Forms.Label lbl_Checkin;
        private System.Windows.Forms.Label lbl_RoomNum2;
        private System.Windows.Forms.Button btn_RoomChoose2;
        private System.Windows.Forms.MonthCalendar cal_Reservations;
        private System.Windows.Forms.Button btn_Refresh2;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_Warning;
    }
}