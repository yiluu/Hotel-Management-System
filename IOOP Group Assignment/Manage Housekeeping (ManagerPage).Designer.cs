namespace IOOP_Group_Assignment
{
    partial class ManageHousekeepingForm
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
            this.pnl_Manage_Housekeeping = new System.Windows.Forms.Panel();
            this.btn_Assign = new System.Windows.Forms.Button();
            this.lbl_Maintenance_Date = new System.Windows.Forms.Label();
            this.timebox_Maintenance_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Assign_Room = new System.Windows.Forms.Label();
            this.tmp_Arrow = new System.Windows.Forms.Label();
            this.lbl_Assign_Worker = new System.Windows.Forms.Label();
            this.datagrid_Schedule_Rooms = new System.Windows.Forms.DataGridView();
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
            this.roomsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.goodStayHotelDatabaseROOMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodStayHotelDatabaseROOMS = new IOOP_Group_Assignment.GoodStayHotelDatabaseROOMS();
            this.datagrid_Schedule_Housekeepers = new System.Windows.Forms.DataGridView();
            this.housekeeperIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housekeepersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodStayHotelDatabaseDataSetHOUSEKEEPERS = new IOOP_Group_Assignment.GoodStayHotelDatabaseDataSetHOUSEKEEPERS();
            this.housekeepersTableAdapter = new IOOP_Group_Assignment.GoodStayHotelDatabaseDataSetHOUSEKEEPERSTableAdapters.HousekeepersTableAdapter();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new IOOP_Group_Assignment.GoodStayHotelDatabaseROOMSTableAdapters.RoomsTableAdapter();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnl_Manage_Housekeeping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Schedule_Rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodStayHotelDatabaseROOMSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodStayHotelDatabaseROOMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Schedule_Housekeepers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housekeepersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodStayHotelDatabaseDataSetHOUSEKEEPERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Manage_Housekeeping
            // 
            this.pnl_Manage_Housekeeping.Controls.Add(this.btn_Assign);
            this.pnl_Manage_Housekeeping.Controls.Add(this.lbl_Maintenance_Date);
            this.pnl_Manage_Housekeeping.Controls.Add(this.timebox_Maintenance_Date);
            this.pnl_Manage_Housekeeping.Controls.Add(this.lbl_Assign_Room);
            this.pnl_Manage_Housekeeping.Controls.Add(this.tmp_Arrow);
            this.pnl_Manage_Housekeeping.Controls.Add(this.lbl_Assign_Worker);
            this.pnl_Manage_Housekeeping.Controls.Add(this.datagrid_Schedule_Rooms);
            this.pnl_Manage_Housekeeping.Controls.Add(this.datagrid_Schedule_Housekeepers);
            this.pnl_Manage_Housekeeping.Location = new System.Drawing.Point(12, 12);
            this.pnl_Manage_Housekeeping.Name = "pnl_Manage_Housekeeping";
            this.pnl_Manage_Housekeeping.Size = new System.Drawing.Size(615, 487);
            this.pnl_Manage_Housekeeping.TabIndex = 11;
            // 
            // btn_Assign
            // 
            this.btn_Assign.Location = new System.Drawing.Point(481, 443);
            this.btn_Assign.Name = "btn_Assign";
            this.btn_Assign.Size = new System.Drawing.Size(119, 29);
            this.btn_Assign.TabIndex = 7;
            this.btn_Assign.Text = "Assign";
            this.btn_Assign.UseVisualStyleBackColor = true;
            this.btn_Assign.Click += new System.EventHandler(this.btn_Assign_Click);
            // 
            // lbl_Maintenance_Date
            // 
            this.lbl_Maintenance_Date.AutoSize = true;
            this.lbl_Maintenance_Date.Location = new System.Drawing.Point(33, 251);
            this.lbl_Maintenance_Date.Name = "lbl_Maintenance_Date";
            this.lbl_Maintenance_Date.Size = new System.Drawing.Size(98, 13);
            this.lbl_Maintenance_Date.TabIndex = 6;
            this.lbl_Maintenance_Date.Text = "Maintenance Date:";
            // 
            // timebox_Maintenance_Date
            // 
            this.timebox_Maintenance_Date.Location = new System.Drawing.Point(149, 245);
            this.timebox_Maintenance_Date.Name = "timebox_Maintenance_Date";
            this.timebox_Maintenance_Date.Size = new System.Drawing.Size(200, 20);
            this.timebox_Maintenance_Date.TabIndex = 5;
            // 
            // lbl_Assign_Room
            // 
            this.lbl_Assign_Room.AutoSize = true;
            this.lbl_Assign_Room.Location = new System.Drawing.Point(359, 32);
            this.lbl_Assign_Room.Name = "lbl_Assign_Room";
            this.lbl_Assign_Room.Size = new System.Drawing.Size(54, 13);
            this.lbl_Assign_Room.TabIndex = 4;
            this.lbl_Assign_Room.Text = "To Room:";
            // 
            // tmp_Arrow
            // 
            this.tmp_Arrow.AutoSize = true;
            this.tmp_Arrow.Location = new System.Drawing.Point(291, 128);
            this.tmp_Arrow.Name = "tmp_Arrow";
            this.tmp_Arrow.Size = new System.Drawing.Size(22, 13);
            this.tmp_Arrow.TabIndex = 3;
            this.tmp_Arrow.Text = "--->";
            // 
            // lbl_Assign_Worker
            // 
            this.lbl_Assign_Worker.AutoSize = true;
            this.lbl_Assign_Worker.Location = new System.Drawing.Point(30, 32);
            this.lbl_Assign_Worker.Name = "lbl_Assign_Worker";
            this.lbl_Assign_Worker.Size = new System.Drawing.Size(79, 13);
            this.lbl_Assign_Worker.TabIndex = 2;
            this.lbl_Assign_Worker.Text = "Assign Worker:";
            // 
            // datagrid_Schedule_Rooms
            // 
            this.datagrid_Schedule_Rooms.AllowUserToAddRows = false;
            this.datagrid_Schedule_Rooms.AllowUserToDeleteRows = false;
            this.datagrid_Schedule_Rooms.AllowUserToResizeColumns = false;
            this.datagrid_Schedule_Rooms.AllowUserToResizeRows = false;
            this.datagrid_Schedule_Rooms.AutoGenerateColumns = false;
            this.datagrid_Schedule_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Schedule_Rooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.datagrid_Schedule_Rooms.DataSource = this.roomsBindingSource2;
            this.datagrid_Schedule_Rooms.Location = new System.Drawing.Point(362, 54);
            this.datagrid_Schedule_Rooms.MultiSelect = false;
            this.datagrid_Schedule_Rooms.Name = "datagrid_Schedule_Rooms";
            this.datagrid_Schedule_Rooms.ReadOnly = true;
            this.datagrid_Schedule_Rooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Schedule_Rooms.Size = new System.Drawing.Size(219, 151);
            this.datagrid_Schedule_Rooms.TabIndex = 1;
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
            // roomsBindingSource2
            // 
            this.roomsBindingSource2.DataMember = "Rooms";
            this.roomsBindingSource2.DataSource = this.goodStayHotelDatabaseROOMSBindingSource;
            // 
            // goodStayHotelDatabaseROOMSBindingSource
            // 
            this.goodStayHotelDatabaseROOMSBindingSource.DataSource = this.goodStayHotelDatabaseROOMS;
            this.goodStayHotelDatabaseROOMSBindingSource.Position = 0;
            // 
            // goodStayHotelDatabaseROOMS
            // 
            this.goodStayHotelDatabaseROOMS.DataSetName = "GoodStayHotelDatabaseROOMS";
            this.goodStayHotelDatabaseROOMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datagrid_Schedule_Housekeepers
            // 
            this.datagrid_Schedule_Housekeepers.AllowUserToAddRows = false;
            this.datagrid_Schedule_Housekeepers.AllowUserToDeleteRows = false;
            this.datagrid_Schedule_Housekeepers.AllowUserToResizeColumns = false;
            this.datagrid_Schedule_Housekeepers.AllowUserToResizeRows = false;
            this.datagrid_Schedule_Housekeepers.AutoGenerateColumns = false;
            this.datagrid_Schedule_Housekeepers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Schedule_Housekeepers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.housekeeperIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.datagrid_Schedule_Housekeepers.DataSource = this.housekeepersBindingSource;
            this.datagrid_Schedule_Housekeepers.Location = new System.Drawing.Point(30, 54);
            this.datagrid_Schedule_Housekeepers.MultiSelect = false;
            this.datagrid_Schedule_Housekeepers.Name = "datagrid_Schedule_Housekeepers";
            this.datagrid_Schedule_Housekeepers.ReadOnly = true;
            this.datagrid_Schedule_Housekeepers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Schedule_Housekeepers.Size = new System.Drawing.Size(219, 151);
            this.datagrid_Schedule_Housekeepers.TabIndex = 0;
            // 
            // housekeeperIDDataGridViewTextBoxColumn
            // 
            this.housekeeperIDDataGridViewTextBoxColumn.DataPropertyName = "HousekeeperID";
            this.housekeeperIDDataGridViewTextBoxColumn.HeaderText = "HousekeeperID";
            this.housekeeperIDDataGridViewTextBoxColumn.Name = "housekeeperIDDataGridViewTextBoxColumn";
            this.housekeeperIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // housekeepersBindingSource
            // 
            this.housekeepersBindingSource.DataMember = "Housekeepers";
            this.housekeepersBindingSource.DataSource = this.goodStayHotelDatabaseDataSetHOUSEKEEPERS;
            // 
            // goodStayHotelDatabaseDataSetHOUSEKEEPERS
            // 
            this.goodStayHotelDatabaseDataSetHOUSEKEEPERS.DataSetName = "GoodStayHotelDatabaseDataSetHOUSEKEEPERS";
            this.goodStayHotelDatabaseDataSetHOUSEKEEPERS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // housekeepersTableAdapter
            // 
            this.housekeepersTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // ManageHousekeepingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 509);
            this.Controls.Add(this.pnl_Manage_Housekeeping);
            this.Name = "ManageHousekeepingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Housekeeping";
            this.Load += new System.EventHandler(this.ManageHousekeepingForm_Load);
            this.pnl_Manage_Housekeeping.ResumeLayout(false);
            this.pnl_Manage_Housekeeping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Schedule_Rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodStayHotelDatabaseROOMSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodStayHotelDatabaseROOMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Schedule_Housekeepers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housekeepersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodStayHotelDatabaseDataSetHOUSEKEEPERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Manage_Housekeeping;
        private System.Windows.Forms.Button btn_Assign;
        private System.Windows.Forms.Label lbl_Maintenance_Date;
        private System.Windows.Forms.DateTimePicker timebox_Maintenance_Date;
        private System.Windows.Forms.Label lbl_Assign_Room;
        private System.Windows.Forms.Label tmp_Arrow;
        private System.Windows.Forms.Label lbl_Assign_Worker;
        private System.Windows.Forms.DataGridView datagrid_Schedule_Rooms;
        private System.Windows.Forms.DataGridView datagrid_Schedule_Housekeepers;
        private GoodStayHotelDatabaseDataSetHOUSEKEEPERS goodStayHotelDatabaseDataSetHOUSEKEEPERS;
        private System.Windows.Forms.BindingSource housekeepersBindingSource;
        private GoodStayHotelDatabaseDataSetHOUSEKEEPERSTableAdapters.HousekeepersTableAdapter housekeepersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn housekeeperIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private GoodStayHotelDatabaseROOMS goodStayHotelDatabaseROOMS;
        private System.Windows.Forms.BindingSource goodStayHotelDatabaseROOMSBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private GoodStayHotelDatabaseROOMSTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource2;
        private System.Windows.Forms.BindingSource roomsBindingSource1;
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
    }
}