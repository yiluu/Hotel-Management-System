namespace IOOP_Group_Assignment
{
    partial class ManageRoomsForm
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
            this.pnl_Manage_Rooms = new System.Windows.Forms.Panel();
            this.txtbox_Amenities = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_Edit_Notes = new System.Windows.Forms.Label();
            this.txtbox_Notes = new System.Windows.Forms.TextBox();
            this.txtbox_Edit_Rate = new System.Windows.Forms.TextBox();
            this.txtbox_Edit_Floor = new System.Windows.Forms.TextBox();
            this.txtbox_Edit_Room_Number = new System.Windows.Forms.TextBox();
            this.timebox_Edit_Cleaned = new System.Windows.Forms.DateTimePicker();
            this.lbl_Edit_Cleaned = new System.Windows.Forms.Label();
            this.cmbbox_Edit_Condition = new System.Windows.Forms.ComboBox();
            this.lbl_Edit_Condition = new System.Windows.Forms.Label();
            this.cmbbox_Availability = new System.Windows.Forms.ComboBox();
            this.lbl_Edit_Amenities = new System.Windows.Forms.Label();
            this.txtbox_Edit_Amenities = new System.Windows.Forms.Label();
            this.lbl_Edit_Rate = new System.Windows.Forms.Label();
            this.lbl_Edit_Floor = new System.Windows.Forms.Label();
            this.lbl_Room_Number = new System.Windows.Forms.Label();
            this.btn_Confirm_Room = new System.Windows.Forms.Button();
            this.datagrid_Rooms = new System.Windows.Forms.DataGridView();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amenitiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratePerNightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCleanedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduledForCleanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodStayHotelDatabaseROOMS = new IOOP_Group_Assignment.GoodStayHotelDatabaseROOMS();
            this.roomsTableAdapter = new IOOP_Group_Assignment.GoodStayHotelDatabaseROOMSTableAdapters.RoomsTableAdapter();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_scheduled = new System.Windows.Forms.Label();
            this.cmbbx_Scheduled = new System.Windows.Forms.ComboBox();
            this.pnl_Manage_Rooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodStayHotelDatabaseROOMS)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Manage_Rooms
            // 
            this.pnl_Manage_Rooms.Controls.Add(this.cmbbx_Scheduled);
            this.pnl_Manage_Rooms.Controls.Add(this.lbl_scheduled);
            this.pnl_Manage_Rooms.Controls.Add(this.btn_Clear);
            this.pnl_Manage_Rooms.Controls.Add(this.txtbox_Amenities);
            this.pnl_Manage_Rooms.Controls.Add(this.btn_Delete);
            this.pnl_Manage_Rooms.Controls.Add(this.lbl_Edit_Notes);
            this.pnl_Manage_Rooms.Controls.Add(this.txtbox_Notes);
            this.pnl_Manage_Rooms.Controls.Add(this.txtbox_Edit_Rate);
            this.pnl_Manage_Rooms.Controls.Add(this.txtbox_Edit_Floor);
            this.pnl_Manage_Rooms.Controls.Add(this.txtbox_Edit_Room_Number);
            this.pnl_Manage_Rooms.Controls.Add(this.timebox_Edit_Cleaned);
            this.pnl_Manage_Rooms.Controls.Add(this.lbl_Edit_Cleaned);
            this.pnl_Manage_Rooms.Controls.Add(this.cmbbox_Edit_Condition);
            this.pnl_Manage_Rooms.Controls.Add(this.lbl_Edit_Condition);
            this.pnl_Manage_Rooms.Controls.Add(this.cmbbox_Availability);
            this.pnl_Manage_Rooms.Controls.Add(this.lbl_Edit_Amenities);
            this.pnl_Manage_Rooms.Controls.Add(this.txtbox_Edit_Amenities);
            this.pnl_Manage_Rooms.Controls.Add(this.lbl_Edit_Rate);
            this.pnl_Manage_Rooms.Controls.Add(this.lbl_Edit_Floor);
            this.pnl_Manage_Rooms.Controls.Add(this.lbl_Room_Number);
            this.pnl_Manage_Rooms.Controls.Add(this.btn_Confirm_Room);
            this.pnl_Manage_Rooms.Controls.Add(this.datagrid_Rooms);
            this.pnl_Manage_Rooms.Location = new System.Drawing.Point(12, 12);
            this.pnl_Manage_Rooms.Name = "pnl_Manage_Rooms";
            this.pnl_Manage_Rooms.Size = new System.Drawing.Size(615, 487);
            this.pnl_Manage_Rooms.TabIndex = 3;
            // 
            // txtbox_Amenities
            // 
            this.txtbox_Amenities.Location = new System.Drawing.Point(358, 156);
            this.txtbox_Amenities.Name = "txtbox_Amenities";
            this.txtbox_Amenities.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Amenities.TabIndex = 53;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(358, 369);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 52;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_Edit_Notes
            // 
            this.lbl_Edit_Notes.AutoSize = true;
            this.lbl_Edit_Notes.Location = new System.Drawing.Point(358, 233);
            this.lbl_Edit_Notes.Name = "lbl_Edit_Notes";
            this.lbl_Edit_Notes.Size = new System.Drawing.Size(103, 13);
            this.lbl_Edit_Notes.TabIndex = 51;
            this.lbl_Edit_Notes.Text = "Maintenance Notes:";
            // 
            // txtbox_Notes
            // 
            this.txtbox_Notes.Location = new System.Drawing.Point(349, 249);
            this.txtbox_Notes.Multiline = true;
            this.txtbox_Notes.Name = "txtbox_Notes";
            this.txtbox_Notes.Size = new System.Drawing.Size(121, 46);
            this.txtbox_Notes.TabIndex = 50;
            // 
            // txtbox_Edit_Rate
            // 
            this.txtbox_Edit_Rate.Location = new System.Drawing.Point(141, 279);
            this.txtbox_Edit_Rate.Name = "txtbox_Edit_Rate";
            this.txtbox_Edit_Rate.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Edit_Rate.TabIndex = 41;
            // 
            // txtbox_Edit_Floor
            // 
            this.txtbox_Edit_Floor.Location = new System.Drawing.Point(141, 235);
            this.txtbox_Edit_Floor.Name = "txtbox_Edit_Floor";
            this.txtbox_Edit_Floor.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Edit_Floor.TabIndex = 39;
            // 
            // txtbox_Edit_Room_Number
            // 
            this.txtbox_Edit_Room_Number.Location = new System.Drawing.Point(141, 198);
            this.txtbox_Edit_Room_Number.Name = "txtbox_Edit_Room_Number";
            this.txtbox_Edit_Room_Number.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Edit_Room_Number.TabIndex = 37;
            // 
            // timebox_Edit_Cleaned
            // 
            this.timebox_Edit_Cleaned.Location = new System.Drawing.Point(143, 356);
            this.timebox_Edit_Cleaned.Name = "timebox_Edit_Cleaned";
            this.timebox_Edit_Cleaned.Size = new System.Drawing.Size(184, 20);
            this.timebox_Edit_Cleaned.TabIndex = 49;
            // 
            // lbl_Edit_Cleaned
            // 
            this.lbl_Edit_Cleaned.AutoSize = true;
            this.lbl_Edit_Cleaned.Location = new System.Drawing.Point(62, 362);
            this.lbl_Edit_Cleaned.Name = "lbl_Edit_Cleaned";
            this.lbl_Edit_Cleaned.Size = new System.Drawing.Size(72, 13);
            this.lbl_Edit_Cleaned.TabIndex = 48;
            this.lbl_Edit_Cleaned.Text = "Last Cleaned:";
            // 
            // cmbbox_Edit_Condition
            // 
            this.cmbbox_Edit_Condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_Edit_Condition.FormattingEnabled = true;
            this.cmbbox_Edit_Condition.Items.AddRange(new object[] {
            "Prepared",
            "Dirty",
            "Clean"});
            this.cmbbox_Edit_Condition.Location = new System.Drawing.Point(141, 318);
            this.cmbbox_Edit_Condition.Name = "cmbbox_Edit_Condition";
            this.cmbbox_Edit_Condition.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_Edit_Condition.TabIndex = 47;
            // 
            // lbl_Edit_Condition
            // 
            this.lbl_Edit_Condition.AutoSize = true;
            this.lbl_Edit_Condition.Location = new System.Drawing.Point(62, 321);
            this.lbl_Edit_Condition.Name = "lbl_Edit_Condition";
            this.lbl_Edit_Condition.Size = new System.Drawing.Size(54, 13);
            this.lbl_Edit_Condition.TabIndex = 46;
            this.lbl_Edit_Condition.Text = "Condition:";
            // 
            // cmbbox_Availability
            // 
            this.cmbbox_Availability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_Availability.FormattingEnabled = true;
            this.cmbbox_Availability.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cmbbox_Availability.Location = new System.Drawing.Point(349, 200);
            this.cmbbox_Availability.Name = "cmbbox_Availability";
            this.cmbbox_Availability.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_Availability.TabIndex = 45;
            // 
            // lbl_Edit_Amenities
            // 
            this.lbl_Edit_Amenities.AutoSize = true;
            this.lbl_Edit_Amenities.Location = new System.Drawing.Point(291, 204);
            this.lbl_Edit_Amenities.Name = "lbl_Edit_Amenities";
            this.lbl_Edit_Amenities.Size = new System.Drawing.Size(59, 13);
            this.lbl_Edit_Amenities.TabIndex = 44;
            this.lbl_Edit_Amenities.Text = "Availability:";
            // 
            // txtbox_Edit_Amenities
            // 
            this.txtbox_Edit_Amenities.AutoSize = true;
            this.txtbox_Edit_Amenities.Location = new System.Drawing.Point(288, 159);
            this.txtbox_Edit_Amenities.Name = "txtbox_Edit_Amenities";
            this.txtbox_Edit_Amenities.Size = new System.Drawing.Size(55, 13);
            this.txtbox_Edit_Amenities.TabIndex = 42;
            this.txtbox_Edit_Amenities.Text = "Amenities:";
            // 
            // lbl_Edit_Rate
            // 
            this.lbl_Edit_Rate.AutoSize = true;
            this.lbl_Edit_Rate.Location = new System.Drawing.Point(62, 282);
            this.lbl_Edit_Rate.Name = "lbl_Edit_Rate";
            this.lbl_Edit_Rate.Size = new System.Drawing.Size(80, 13);
            this.lbl_Edit_Rate.TabIndex = 40;
            this.lbl_Edit_Rate.Text = "Rate per night: ";
            // 
            // lbl_Edit_Floor
            // 
            this.lbl_Edit_Floor.AutoSize = true;
            this.lbl_Edit_Floor.Location = new System.Drawing.Point(62, 238);
            this.lbl_Edit_Floor.Name = "lbl_Edit_Floor";
            this.lbl_Edit_Floor.Size = new System.Drawing.Size(33, 13);
            this.lbl_Edit_Floor.TabIndex = 38;
            this.lbl_Edit_Floor.Text = "Floor:";
            // 
            // lbl_Room_Number
            // 
            this.lbl_Room_Number.AutoSize = true;
            this.lbl_Room_Number.Location = new System.Drawing.Point(62, 201);
            this.lbl_Room_Number.Name = "lbl_Room_Number";
            this.lbl_Room_Number.Size = new System.Drawing.Size(78, 13);
            this.lbl_Room_Number.TabIndex = 36;
            this.lbl_Room_Number.Text = "Room Number:";
            // 
            // btn_Confirm_Room
            // 
            this.btn_Confirm_Room.Location = new System.Drawing.Point(445, 369);
            this.btn_Confirm_Room.Name = "btn_Confirm_Room";
            this.btn_Confirm_Room.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm_Room.TabIndex = 33;
            this.btn_Confirm_Room.Text = "Confirm";
            this.btn_Confirm_Room.UseVisualStyleBackColor = true;
            this.btn_Confirm_Room.Click += new System.EventHandler(this.btn_Edit_Room_Click);
            // 
            // datagrid_Rooms
            // 
            this.datagrid_Rooms.AllowUserToAddRows = false;
            this.datagrid_Rooms.AllowUserToDeleteRows = false;
            this.datagrid_Rooms.AutoGenerateColumns = false;
            this.datagrid_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Rooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.amenitiesDataGridViewTextBoxColumn,
            this.ratePerNightDataGridViewTextBoxColumn,
            this.availabilityDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.lastCleanedDateDataGridViewTextBoxColumn,
            this.maintenanceNotesDataGridViewTextBoxColumn,
            this.scheduledForCleanDataGridViewTextBoxColumn});
            this.datagrid_Rooms.DataSource = this.roomsBindingSource;
            this.datagrid_Rooms.Location = new System.Drawing.Point(65, 48);
            this.datagrid_Rooms.MultiSelect = false;
            this.datagrid_Rooms.Name = "datagrid_Rooms";
            this.datagrid_Rooms.ReadOnly = true;
            this.datagrid_Rooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Rooms.Size = new System.Drawing.Size(425, 86);
            this.datagrid_Rooms.TabIndex = 32;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "Floor";
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            this.floorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amenitiesDataGridViewTextBoxColumn
            // 
            this.amenitiesDataGridViewTextBoxColumn.DataPropertyName = "Amenities";
            this.amenitiesDataGridViewTextBoxColumn.HeaderText = "Amenities";
            this.amenitiesDataGridViewTextBoxColumn.Name = "amenitiesDataGridViewTextBoxColumn";
            this.amenitiesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratePerNightDataGridViewTextBoxColumn
            // 
            this.ratePerNightDataGridViewTextBoxColumn.DataPropertyName = "RatePerNight";
            this.ratePerNightDataGridViewTextBoxColumn.HeaderText = "RatePerNight";
            this.ratePerNightDataGridViewTextBoxColumn.Name = "ratePerNightDataGridViewTextBoxColumn";
            this.ratePerNightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availabilityDataGridViewTextBoxColumn
            // 
            this.availabilityDataGridViewTextBoxColumn.DataPropertyName = "Availability";
            this.availabilityDataGridViewTextBoxColumn.HeaderText = "Availability";
            this.availabilityDataGridViewTextBoxColumn.Name = "availabilityDataGridViewTextBoxColumn";
            this.availabilityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastCleanedDateDataGridViewTextBoxColumn
            // 
            this.lastCleanedDateDataGridViewTextBoxColumn.DataPropertyName = "LastCleanedDate";
            this.lastCleanedDateDataGridViewTextBoxColumn.HeaderText = "LastCleanedDate";
            this.lastCleanedDateDataGridViewTextBoxColumn.Name = "lastCleanedDateDataGridViewTextBoxColumn";
            this.lastCleanedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maintenanceNotesDataGridViewTextBoxColumn
            // 
            this.maintenanceNotesDataGridViewTextBoxColumn.DataPropertyName = "MaintenanceNotes";
            this.maintenanceNotesDataGridViewTextBoxColumn.HeaderText = "MaintenanceNotes";
            this.maintenanceNotesDataGridViewTextBoxColumn.Name = "maintenanceNotesDataGridViewTextBoxColumn";
            this.maintenanceNotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scheduledForCleanDataGridViewTextBoxColumn
            // 
            this.scheduledForCleanDataGridViewTextBoxColumn.DataPropertyName = "ScheduledForClean";
            this.scheduledForCleanDataGridViewTextBoxColumn.HeaderText = "ScheduledForClean";
            this.scheduledForCleanDataGridViewTextBoxColumn.Name = "scheduledForCleanDataGridViewTextBoxColumn";
            this.scheduledForCleanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.goodStayHotelDatabaseROOMS;
            // 
            // goodStayHotelDatabaseROOMS
            // 
            this.goodStayHotelDatabaseROOMS.DataSetName = "GoodStayHotelDatabaseROOMS";
            this.goodStayHotelDatabaseROOMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(65, 149);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 23);
            this.btn_Clear.TabIndex = 54;
            this.btn_Clear.Text = "Clear Selection";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_scheduled
            // 
            this.lbl_scheduled.AutoSize = true;
            this.lbl_scheduled.Location = new System.Drawing.Point(350, 305);
            this.lbl_scheduled.Name = "lbl_scheduled";
            this.lbl_scheduled.Size = new System.Drawing.Size(120, 13);
            this.lbl_scheduled.TabIndex = 55;
            this.lbl_scheduled.Text = "Scheduled for Cleaning:";
            // 
            // cmbbx_Scheduled
            // 
            this.cmbbx_Scheduled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_Scheduled.FormattingEnabled = true;
            this.cmbbx_Scheduled.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbbx_Scheduled.Location = new System.Drawing.Point(349, 321);
            this.cmbbx_Scheduled.Name = "cmbbx_Scheduled";
            this.cmbbx_Scheduled.Size = new System.Drawing.Size(121, 21);
            this.cmbbx_Scheduled.TabIndex = 56;
            // 
            // ManageRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 460);
            this.Controls.Add(this.pnl_Manage_Rooms);
            this.Name = "ManageRoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Rooms";
            this.Load += new System.EventHandler(this.ManageRoomsForm_Load);
            this.pnl_Manage_Rooms.ResumeLayout(false);
            this.pnl_Manage_Rooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodStayHotelDatabaseROOMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Manage_Rooms;
        private System.Windows.Forms.Label lbl_Edit_Notes;
        private System.Windows.Forms.TextBox txtbox_Notes;
        private System.Windows.Forms.TextBox txtbox_Edit_Rate;
        private System.Windows.Forms.TextBox txtbox_Edit_Floor;
        private System.Windows.Forms.TextBox txtbox_Edit_Room_Number;
        private System.Windows.Forms.DateTimePicker timebox_Edit_Cleaned;
        private System.Windows.Forms.Label lbl_Edit_Cleaned;
        private System.Windows.Forms.ComboBox cmbbox_Edit_Condition;
        private System.Windows.Forms.Label lbl_Edit_Condition;
        private System.Windows.Forms.ComboBox cmbbox_Availability;
        private System.Windows.Forms.Label lbl_Edit_Amenities;
        private System.Windows.Forms.Label txtbox_Edit_Amenities;
        private System.Windows.Forms.Label lbl_Edit_Rate;
        private System.Windows.Forms.Label lbl_Edit_Floor;
        private System.Windows.Forms.Label lbl_Room_Number;
        private System.Windows.Forms.Button btn_Confirm_Room;
        private System.Windows.Forms.DataGridView datagrid_Rooms;
        private System.Windows.Forms.Button btn_Delete;
        private GoodStayHotelDatabaseROOMS goodStayHotelDatabaseROOMS;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private GoodStayHotelDatabaseROOMSTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amenitiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratePerNightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCleanedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduledForCleanDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtbox_Amenities;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ComboBox cmbbx_Scheduled;
        private System.Windows.Forms.Label lbl_scheduled;
    }
}