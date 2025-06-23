namespace IOOP_Group_Assignment
{
    partial class Rooms1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRoomCheck_in = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblThe_Price = new System.Windows.Forms.Label();
            this.lblRoom_Floor = new System.Windows.Forms.Label();
            this.lblRoom_Type = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBRoom_Floor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.btn_Checkin = new System.Windows.Forms.Button();
            this.CBRoom_Type = new System.Windows.Forms.ComboBox();
            this.tabPageSearchRoom = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageRoomCheck_in.SuspendLayout();
            this.tabPageSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Room Check in";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPageRoomCheck_in);
            this.tabControl1.Controls.Add(this.tabPageSearchRoom);
            this.tabControl1.Location = new System.Drawing.Point(28, 43);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(749, 393);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPageRoomCheck_in
            // 
            this.tabPageRoomCheck_in.Controls.Add(this.label9);
            this.tabPageRoomCheck_in.Controls.Add(this.lblDate);
            this.tabPageRoomCheck_in.Controls.Add(this.label7);
            this.tabPageRoomCheck_in.Controls.Add(this.lblThe_Price);
            this.tabPageRoomCheck_in.Controls.Add(this.lblRoom_Floor);
            this.tabPageRoomCheck_in.Controls.Add(this.lblRoom_Type);
            this.tabPageRoomCheck_in.Controls.Add(this.label6);
            this.tabPageRoomCheck_in.Controls.Add(this.label5);
            this.tabPageRoomCheck_in.Controls.Add(this.CBRoom_Floor);
            this.tabPageRoomCheck_in.Controls.Add(this.label4);
            this.tabPageRoomCheck_in.Controls.Add(this.label2);
            this.tabPageRoomCheck_in.Controls.Add(this.label3);
            this.tabPageRoomCheck_in.Controls.Add(this.monthCalendar2);
            this.tabPageRoomCheck_in.Controls.Add(this.btn_Checkin);
            this.tabPageRoomCheck_in.Controls.Add(this.CBRoom_Type);
            this.tabPageRoomCheck_in.Location = new System.Drawing.Point(4, 4);
            this.tabPageRoomCheck_in.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageRoomCheck_in.Name = "tabPageRoomCheck_in";
            this.tabPageRoomCheck_in.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageRoomCheck_in.Size = new System.Drawing.Size(741, 364);
            this.tabPageRoomCheck_in.TabIndex = 0;
            this.tabPageRoomCheck_in.Text = "Room Check in";
            this.tabPageRoomCheck_in.UseVisualStyleBackColor = true;
            this.tabPageRoomCheck_in.Click += new System.EventHandler(this.tabPageRoomCheck_in_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(161, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Room Floor";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(63, 192);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 16);
            this.lblDate.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Date";
            // 
            // lblThe_Price
            // 
            this.lblThe_Price.AutoSize = true;
            this.lblThe_Price.Location = new System.Drawing.Point(63, 148);
            this.lblThe_Price.Name = "lblThe_Price";
            this.lblThe_Price.Size = new System.Drawing.Size(0, 16);
            this.lblThe_Price.TabIndex = 16;
            // 
            // lblRoom_Floor
            // 
            this.lblRoom_Floor.AutoSize = true;
            this.lblRoom_Floor.Location = new System.Drawing.Point(63, 100);
            this.lblRoom_Floor.Name = "lblRoom_Floor";
            this.lblRoom_Floor.Size = new System.Drawing.Size(0, 16);
            this.lblRoom_Floor.TabIndex = 15;
            // 
            // lblRoom_Type
            // 
            this.lblRoom_Type.AutoSize = true;
            this.lblRoom_Type.Location = new System.Drawing.Point(63, 50);
            this.lblRoom_Type.Name = "lblRoom_Type";
            this.lblRoom_Type.Size = new System.Drawing.Size(0, 16);
            this.lblRoom_Type.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Price:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Floor:";
            // 
            // CBRoom_Floor
            // 
            this.CBRoom_Floor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBRoom_Floor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBRoom_Floor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRoom_Floor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBRoom_Floor.FormattingEnabled = true;
            this.CBRoom_Floor.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3"});
            this.CBRoom_Floor.Location = new System.Drawing.Point(165, 145);
            this.CBRoom_Floor.Margin = new System.Windows.Forms.Padding(4);
            this.CBRoom_Floor.Name = "CBRoom_Floor";
            this.CBRoom_Floor.Size = new System.Drawing.Size(160, 24);
            this.CBRoom_Floor.TabIndex = 11;
            this.CBRoom_Floor.SelectedIndexChanged += new System.EventHandler(this.CBRoom_Floor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Until:";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(420, 50);
            this.monthCalendar2.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 7;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // btn_Checkin
            // 
            this.btn_Checkin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Checkin.ForeColor = System.Drawing.Color.White;
            this.btn_Checkin.Location = new System.Drawing.Point(256, 302);
            this.btn_Checkin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Checkin.Name = "btn_Checkin";
            this.btn_Checkin.Size = new System.Drawing.Size(175, 57);
            this.btn_Checkin.TabIndex = 6;
            this.btn_Checkin.Text = "Check in";
            this.btn_Checkin.UseVisualStyleBackColor = false;
            this.btn_Checkin.Click += new System.EventHandler(this.btn_Checkin_Click);
            // 
            // CBRoom_Type
            // 
            this.CBRoom_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBRoom_Type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBRoom_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRoom_Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBRoom_Type.FormattingEnabled = true;
            this.CBRoom_Type.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite"});
            this.CBRoom_Type.Location = new System.Drawing.Point(165, 43);
            this.CBRoom_Type.Margin = new System.Windows.Forms.Padding(4);
            this.CBRoom_Type.Name = "CBRoom_Type";
            this.CBRoom_Type.Size = new System.Drawing.Size(160, 24);
            this.CBRoom_Type.TabIndex = 5;
            this.CBRoom_Type.SelectedIndexChanged += new System.EventHandler(this.CBRoom_Type_SelectedIndexChanged);
            // 
            // tabPageSearchRoom
            // 
            this.tabPageSearchRoom.Controls.Add(this.dataGridView1);
            this.tabPageSearchRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRoom.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSearchRoom.Name = "tabPageSearchRoom";
            this.tabPageSearchRoom.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSearchRoom.Size = new System.Drawing.Size(741, 364);
            this.tabPageSearchRoom.TabIndex = 1;
            this.tabPageSearchRoom.Text = "Details";
            this.tabPageSearchRoom.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(725, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Rooms1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Rooms1";
            this.Text = "Rooms1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageRoomCheck_in.ResumeLayout(false);
            this.tabPageRoomCheck_in.PerformLayout();
            this.tabPageSearchRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRoomCheck_in;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblThe_Price;
        private System.Windows.Forms.Label lblRoom_Floor;
        private System.Windows.Forms.Label lblRoom_Type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBRoom_Floor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button btn_Checkin;
        private System.Windows.Forms.ComboBox CBRoom_Type;
        private System.Windows.Forms.TabPage tabPageSearchRoom;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}