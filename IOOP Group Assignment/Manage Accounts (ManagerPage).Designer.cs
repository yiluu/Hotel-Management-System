namespace IOOP_Group_Assignment
{
    partial class ManageAccountsForm
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
            this.tabcntrl_Manage_Accounts = new System.Windows.Forms.TabControl();
            this.Add = new System.Windows.Forms.TabPage();
            this.btn_Add_Clear = new System.Windows.Forms.Button();
            this.lbl_Housekeepers = new System.Windows.Forms.Label();
            this.lbl_Receptionists = new System.Windows.Forms.Label();
            this.datagrid_Add_Housekeepers = new System.Windows.Forms.DataGridView();
            this.housekeeperIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housekeepersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodStayHotelDatabaseDataSet1 = new IOOP_Group_Assignment.GoodStayHotelDatabaseDataSet1();
            this.txtbox_Add_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txtbox_Add_Password = new System.Windows.Forms.TextBox();
            this.txtbox_Add_Username = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_User_Type = new System.Windows.Forms.Label();
            this.datagrid_Add_Receptionists = new System.Windows.Forms.DataGridView();
            this.receptionistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodStayHotelDatabaseDataSet = new IOOP_Group_Assignment.GoodStayHotelDatabaseDataSet();
            this.cmbbx_User_Type = new System.Windows.Forms.ComboBox();
            this.btn_Add_User = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.TabPage();
            this.btn_Edit_Clear = new System.Windows.Forms.Button();
            this.txtbox_Edit_Name = new System.Windows.Forms.TextBox();
            this.lbl_Edit_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datagrid_Edit_Housekeepers = new System.Windows.Forms.DataGridView();
            this.housekeeperIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbox_Edit_Password = new System.Windows.Forms.TextBox();
            this.txtbox_Edit_Username = new System.Windows.Forms.TextBox();
            this.lbl_Edit_Password = new System.Windows.Forms.Label();
            this.lbl_Edit_Username = new System.Windows.Forms.Label();
            this.btn_Edit_User = new System.Windows.Forms.Button();
            this.datagrid_Edit_Receptionists = new System.Windows.Forms.DataGridView();
            this.receptionistIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistsTableAdapter = new IOOP_Group_Assignment.GoodStayHotelDatabaseDataSetTableAdapters.ReceptionistsTableAdapter();
            this.housekeepersTableAdapter = new IOOP_Group_Assignment.GoodStayHotelDatabaseDataSet1TableAdapters.HousekeepersTableAdapter();
            this.tabcntrl_Manage_Accounts.SuspendLayout();
            this.Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Add_Housekeepers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housekeepersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodStayHotelDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Add_Receptionists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodStayHotelDatabaseDataSet)).BeginInit();
            this.Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Edit_Housekeepers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Edit_Receptionists)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcntrl_Manage_Accounts
            // 
            this.tabcntrl_Manage_Accounts.Controls.Add(this.Add);
            this.tabcntrl_Manage_Accounts.Controls.Add(this.Edit);
            this.tabcntrl_Manage_Accounts.Location = new System.Drawing.Point(12, 12);
            this.tabcntrl_Manage_Accounts.Name = "tabcntrl_Manage_Accounts";
            this.tabcntrl_Manage_Accounts.SelectedIndex = 0;
            this.tabcntrl_Manage_Accounts.Size = new System.Drawing.Size(1124, 441);
            this.tabcntrl_Manage_Accounts.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Controls.Add(this.btn_Add_Clear);
            this.Add.Controls.Add(this.lbl_Housekeepers);
            this.Add.Controls.Add(this.lbl_Receptionists);
            this.Add.Controls.Add(this.datagrid_Add_Housekeepers);
            this.Add.Controls.Add(this.txtbox_Add_Name);
            this.Add.Controls.Add(this.lbl_Name);
            this.Add.Controls.Add(this.txtbox_Add_Password);
            this.Add.Controls.Add(this.txtbox_Add_Username);
            this.Add.Controls.Add(this.lbl_Password);
            this.Add.Controls.Add(this.lbl_Username);
            this.Add.Controls.Add(this.lbl_User_Type);
            this.Add.Controls.Add(this.datagrid_Add_Receptionists);
            this.Add.Controls.Add(this.cmbbx_User_Type);
            this.Add.Controls.Add(this.btn_Add_User);
            this.Add.Location = new System.Drawing.Point(4, 22);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(3);
            this.Add.Size = new System.Drawing.Size(1116, 415);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add User";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Clear
            // 
            this.btn_Add_Clear.Location = new System.Drawing.Point(979, 191);
            this.btn_Add_Clear.Name = "btn_Add_Clear";
            this.btn_Add_Clear.Size = new System.Drawing.Size(92, 23);
            this.btn_Add_Clear.TabIndex = 16;
            this.btn_Add_Clear.Text = "Clear Selection";
            this.btn_Add_Clear.UseVisualStyleBackColor = true;
            this.btn_Add_Clear.Click += new System.EventHandler(this.btn_Add_Clear_Click);
            // 
            // lbl_Housekeepers
            // 
            this.lbl_Housekeepers.AutoSize = true;
            this.lbl_Housekeepers.Location = new System.Drawing.Point(799, 20);
            this.lbl_Housekeepers.Name = "lbl_Housekeepers";
            this.lbl_Housekeepers.Size = new System.Drawing.Size(76, 13);
            this.lbl_Housekeepers.TabIndex = 15;
            this.lbl_Housekeepers.Text = "Housekeepers";
            this.lbl_Housekeepers.Click += new System.EventHandler(this.lbl_Housekeepers_Click);
            // 
            // lbl_Receptionists
            // 
            this.lbl_Receptionists.AutoSize = true;
            this.lbl_Receptionists.Location = new System.Drawing.Point(257, 20);
            this.lbl_Receptionists.Name = "lbl_Receptionists";
            this.lbl_Receptionists.Size = new System.Drawing.Size(71, 13);
            this.lbl_Receptionists.TabIndex = 14;
            this.lbl_Receptionists.Text = "Receptionists";
            // 
            // datagrid_Add_Housekeepers
            // 
            this.datagrid_Add_Housekeepers.AllowUserToAddRows = false;
            this.datagrid_Add_Housekeepers.AllowUserToDeleteRows = false;
            this.datagrid_Add_Housekeepers.AllowUserToResizeColumns = false;
            this.datagrid_Add_Housekeepers.AllowUserToResizeRows = false;
            this.datagrid_Add_Housekeepers.AutoGenerateColumns = false;
            this.datagrid_Add_Housekeepers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Add_Housekeepers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.housekeeperIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.usernameDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn1});
            this.datagrid_Add_Housekeepers.DataSource = this.housekeepersBindingSource;
            this.datagrid_Add_Housekeepers.Location = new System.Drawing.Point(588, 36);
            this.datagrid_Add_Housekeepers.MultiSelect = false;
            this.datagrid_Add_Housekeepers.Name = "datagrid_Add_Housekeepers";
            this.datagrid_Add_Housekeepers.ReadOnly = true;
            this.datagrid_Add_Housekeepers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Add_Housekeepers.Size = new System.Drawing.Size(483, 149);
            this.datagrid_Add_Housekeepers.TabIndex = 13;
            // 
            // housekeeperIDDataGridViewTextBoxColumn
            // 
            this.housekeeperIDDataGridViewTextBoxColumn.DataPropertyName = "HousekeeperID";
            this.housekeeperIDDataGridViewTextBoxColumn.HeaderText = "HousekeeperID";
            this.housekeeperIDDataGridViewTextBoxColumn.Name = "housekeeperIDDataGridViewTextBoxColumn";
            this.housekeeperIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn1
            // 
            this.usernameDataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn1.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn1.Name = "usernameDataGridViewTextBoxColumn1";
            this.usernameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn1
            // 
            this.passwordDataGridViewTextBoxColumn1.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn1.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn1.Name = "passwordDataGridViewTextBoxColumn1";
            this.passwordDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // housekeepersBindingSource
            // 
            this.housekeepersBindingSource.DataMember = "Housekeepers";
            this.housekeepersBindingSource.DataSource = this.goodStayHotelDatabaseDataSet1;
            // 
            // goodStayHotelDatabaseDataSet1
            // 
            this.goodStayHotelDatabaseDataSet1.DataSetName = "GoodStayHotelDatabaseDataSet1";
            this.goodStayHotelDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbox_Add_Name
            // 
            this.txtbox_Add_Name.Location = new System.Drawing.Point(143, 260);
            this.txtbox_Add_Name.Name = "txtbox_Add_Name";
            this.txtbox_Add_Name.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Add_Name.TabIndex = 12;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(64, 263);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(38, 13);
            this.lbl_Name.TabIndex = 11;
            this.lbl_Name.Text = "Name:";
            // 
            // txtbox_Add_Password
            // 
            this.txtbox_Add_Password.Location = new System.Drawing.Point(142, 348);
            this.txtbox_Add_Password.Name = "txtbox_Add_Password";
            this.txtbox_Add_Password.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Add_Password.TabIndex = 10;
            this.txtbox_Add_Password.UseSystemPasswordChar = true;
            // 
            // txtbox_Add_Username
            // 
            this.txtbox_Add_Username.Location = new System.Drawing.Point(142, 304);
            this.txtbox_Add_Username.Name = "txtbox_Add_Username";
            this.txtbox_Add_Username.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Add_Username.TabIndex = 9;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(63, 351);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(63, 307);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(58, 13);
            this.lbl_Username.TabIndex = 7;
            this.lbl_Username.Text = "Username:";
            // 
            // lbl_User_Type
            // 
            this.lbl_User_Type.AutoSize = true;
            this.lbl_User_Type.Location = new System.Drawing.Point(63, 212);
            this.lbl_User_Type.Name = "lbl_User_Type";
            this.lbl_User_Type.Size = new System.Drawing.Size(59, 13);
            this.lbl_User_Type.TabIndex = 6;
            this.lbl_User_Type.Text = "User Type:";
            // 
            // datagrid_Add_Receptionists
            // 
            this.datagrid_Add_Receptionists.AllowUserToAddRows = false;
            this.datagrid_Add_Receptionists.AllowUserToDeleteRows = false;
            this.datagrid_Add_Receptionists.AllowUserToResizeColumns = false;
            this.datagrid_Add_Receptionists.AllowUserToResizeRows = false;
            this.datagrid_Add_Receptionists.AutoGenerateColumns = false;
            this.datagrid_Add_Receptionists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Add_Receptionists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receptionistIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.datagrid_Add_Receptionists.DataSource = this.receptionistsBindingSource;
            this.datagrid_Add_Receptionists.Location = new System.Drawing.Point(67, 36);
            this.datagrid_Add_Receptionists.MultiSelect = false;
            this.datagrid_Add_Receptionists.Name = "datagrid_Add_Receptionists";
            this.datagrid_Add_Receptionists.ReadOnly = true;
            this.datagrid_Add_Receptionists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Add_Receptionists.Size = new System.Drawing.Size(475, 149);
            this.datagrid_Add_Receptionists.TabIndex = 5;
            // 
            // receptionistIDDataGridViewTextBoxColumn
            // 
            this.receptionistIDDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistID";
            this.receptionistIDDataGridViewTextBoxColumn.HeaderText = "ReceptionistID";
            this.receptionistIDDataGridViewTextBoxColumn.Name = "receptionistIDDataGridViewTextBoxColumn";
            this.receptionistIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receptionistsBindingSource
            // 
            this.receptionistsBindingSource.DataMember = "Receptionists";
            this.receptionistsBindingSource.DataSource = this.goodStayHotelDatabaseDataSet;
            // 
            // goodStayHotelDatabaseDataSet
            // 
            this.goodStayHotelDatabaseDataSet.DataSetName = "GoodStayHotelDatabaseDataSet";
            this.goodStayHotelDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbbx_User_Type
            // 
            this.cmbbx_User_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_User_Type.FormattingEnabled = true;
            this.cmbbx_User_Type.Items.AddRange(new object[] {
            "Receptionists",
            "Housekeepers"});
            this.cmbbx_User_Type.Location = new System.Drawing.Point(142, 209);
            this.cmbbx_User_Type.Name = "cmbbx_User_Type";
            this.cmbbx_User_Type.Size = new System.Drawing.Size(121, 21);
            this.cmbbx_User_Type.TabIndex = 1;
            // 
            // btn_Add_User
            // 
            this.btn_Add_User.Location = new System.Drawing.Point(979, 369);
            this.btn_Add_User.Name = "btn_Add_User";
            this.btn_Add_User.Size = new System.Drawing.Size(119, 29);
            this.btn_Add_User.TabIndex = 0;
            this.btn_Add_User.Text = "Confirm";
            this.btn_Add_User.UseVisualStyleBackColor = true;
            this.btn_Add_User.Click += new System.EventHandler(this.btn_Add_User_Click);
            // 
            // Edit
            // 
            this.Edit.Controls.Add(this.btn_Edit_Clear);
            this.Edit.Controls.Add(this.txtbox_Edit_Name);
            this.Edit.Controls.Add(this.lbl_Edit_Name);
            this.Edit.Controls.Add(this.label1);
            this.Edit.Controls.Add(this.label2);
            this.Edit.Controls.Add(this.datagrid_Edit_Housekeepers);
            this.Edit.Controls.Add(this.txtbox_Edit_Password);
            this.Edit.Controls.Add(this.txtbox_Edit_Username);
            this.Edit.Controls.Add(this.lbl_Edit_Password);
            this.Edit.Controls.Add(this.lbl_Edit_Username);
            this.Edit.Controls.Add(this.btn_Edit_User);
            this.Edit.Controls.Add(this.datagrid_Edit_Receptionists);
            this.Edit.Location = new System.Drawing.Point(4, 22);
            this.Edit.Name = "Edit";
            this.Edit.Padding = new System.Windows.Forms.Padding(3);
            this.Edit.Size = new System.Drawing.Size(1116, 415);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Edit User";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Edit_Clear
            // 
            this.btn_Edit_Clear.Location = new System.Drawing.Point(967, 194);
            this.btn_Edit_Clear.Name = "btn_Edit_Clear";
            this.btn_Edit_Clear.Size = new System.Drawing.Size(104, 23);
            this.btn_Edit_Clear.TabIndex = 22;
            this.btn_Edit_Clear.Text = "Clear Selection";
            this.btn_Edit_Clear.UseVisualStyleBackColor = true;
            this.btn_Edit_Clear.Click += new System.EventHandler(this.btn_Edit_Clear_Click);
            // 
            // txtbox_Edit_Name
            // 
            this.txtbox_Edit_Name.Location = new System.Drawing.Point(151, 217);
            this.txtbox_Edit_Name.Name = "txtbox_Edit_Name";
            this.txtbox_Edit_Name.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Edit_Name.TabIndex = 21;
            // 
            // lbl_Edit_Name
            // 
            this.lbl_Edit_Name.AutoSize = true;
            this.lbl_Edit_Name.Location = new System.Drawing.Point(72, 220);
            this.lbl_Edit_Name.Name = "lbl_Edit_Name";
            this.lbl_Edit_Name.Size = new System.Drawing.Size(38, 13);
            this.lbl_Edit_Name.TabIndex = 20;
            this.lbl_Edit_Name.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(789, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Housekeepers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Receptionists";
            // 
            // datagrid_Edit_Housekeepers
            // 
            this.datagrid_Edit_Housekeepers.AllowUserToAddRows = false;
            this.datagrid_Edit_Housekeepers.AllowUserToDeleteRows = false;
            this.datagrid_Edit_Housekeepers.AllowUserToResizeColumns = false;
            this.datagrid_Edit_Housekeepers.AllowUserToResizeRows = false;
            this.datagrid_Edit_Housekeepers.AutoGenerateColumns = false;
            this.datagrid_Edit_Housekeepers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Edit_Housekeepers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.housekeeperIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn3,
            this.usernameDataGridViewTextBoxColumn3,
            this.passwordDataGridViewTextBoxColumn3});
            this.datagrid_Edit_Housekeepers.DataSource = this.housekeepersBindingSource;
            this.datagrid_Edit_Housekeepers.Location = new System.Drawing.Point(580, 39);
            this.datagrid_Edit_Housekeepers.MultiSelect = false;
            this.datagrid_Edit_Housekeepers.Name = "datagrid_Edit_Housekeepers";
            this.datagrid_Edit_Housekeepers.ReadOnly = true;
            this.datagrid_Edit_Housekeepers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Edit_Housekeepers.Size = new System.Drawing.Size(491, 149);
            this.datagrid_Edit_Housekeepers.TabIndex = 17;
            // 
            // housekeeperIDDataGridViewTextBoxColumn1
            // 
            this.housekeeperIDDataGridViewTextBoxColumn1.DataPropertyName = "HousekeeperID";
            this.housekeeperIDDataGridViewTextBoxColumn1.HeaderText = "HousekeeperID";
            this.housekeeperIDDataGridViewTextBoxColumn1.Name = "housekeeperIDDataGridViewTextBoxColumn1";
            this.housekeeperIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            this.nameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn3
            // 
            this.usernameDataGridViewTextBoxColumn3.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn3.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn3.Name = "usernameDataGridViewTextBoxColumn3";
            this.usernameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn3
            // 
            this.passwordDataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn3.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn3.Name = "passwordDataGridViewTextBoxColumn3";
            this.passwordDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // txtbox_Edit_Password
            // 
            this.txtbox_Edit_Password.Location = new System.Drawing.Point(151, 303);
            this.txtbox_Edit_Password.Name = "txtbox_Edit_Password";
            this.txtbox_Edit_Password.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Edit_Password.TabIndex = 16;
            // 
            // txtbox_Edit_Username
            // 
            this.txtbox_Edit_Username.Location = new System.Drawing.Point(151, 259);
            this.txtbox_Edit_Username.Name = "txtbox_Edit_Username";
            this.txtbox_Edit_Username.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Edit_Username.TabIndex = 15;
            // 
            // lbl_Edit_Password
            // 
            this.lbl_Edit_Password.AutoSize = true;
            this.lbl_Edit_Password.Location = new System.Drawing.Point(72, 306);
            this.lbl_Edit_Password.Name = "lbl_Edit_Password";
            this.lbl_Edit_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_Edit_Password.TabIndex = 14;
            this.lbl_Edit_Password.Text = "Password:";
            // 
            // lbl_Edit_Username
            // 
            this.lbl_Edit_Username.AutoSize = true;
            this.lbl_Edit_Username.Location = new System.Drawing.Point(72, 262);
            this.lbl_Edit_Username.Name = "lbl_Edit_Username";
            this.lbl_Edit_Username.Size = new System.Drawing.Size(58, 13);
            this.lbl_Edit_Username.TabIndex = 13;
            this.lbl_Edit_Username.Text = "Username:";
            // 
            // btn_Edit_User
            // 
            this.btn_Edit_User.Location = new System.Drawing.Point(977, 380);
            this.btn_Edit_User.Name = "btn_Edit_User";
            this.btn_Edit_User.Size = new System.Drawing.Size(119, 29);
            this.btn_Edit_User.TabIndex = 7;
            this.btn_Edit_User.Text = "Confirm";
            this.btn_Edit_User.UseVisualStyleBackColor = true;
            this.btn_Edit_User.Click += new System.EventHandler(this.btn_Edit_User_Click);
            // 
            // datagrid_Edit_Receptionists
            // 
            this.datagrid_Edit_Receptionists.AllowUserToAddRows = false;
            this.datagrid_Edit_Receptionists.AllowUserToDeleteRows = false;
            this.datagrid_Edit_Receptionists.AllowUserToResizeColumns = false;
            this.datagrid_Edit_Receptionists.AllowUserToResizeRows = false;
            this.datagrid_Edit_Receptionists.AutoGenerateColumns = false;
            this.datagrid_Edit_Receptionists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Edit_Receptionists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receptionistIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn2,
            this.usernameDataGridViewTextBoxColumn2,
            this.passwordDataGridViewTextBoxColumn2});
            this.datagrid_Edit_Receptionists.DataSource = this.receptionistsBindingSource;
            this.datagrid_Edit_Receptionists.Location = new System.Drawing.Point(52, 39);
            this.datagrid_Edit_Receptionists.MultiSelect = false;
            this.datagrid_Edit_Receptionists.Name = "datagrid_Edit_Receptionists";
            this.datagrid_Edit_Receptionists.ReadOnly = true;
            this.datagrid_Edit_Receptionists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Edit_Receptionists.Size = new System.Drawing.Size(491, 149);
            this.datagrid_Edit_Receptionists.TabIndex = 6;
            // 
            // receptionistIDDataGridViewTextBoxColumn1
            // 
            this.receptionistIDDataGridViewTextBoxColumn1.DataPropertyName = "ReceptionistID";
            this.receptionistIDDataGridViewTextBoxColumn1.HeaderText = "ReceptionistID";
            this.receptionistIDDataGridViewTextBoxColumn1.Name = "receptionistIDDataGridViewTextBoxColumn1";
            this.receptionistIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn2
            // 
            this.usernameDataGridViewTextBoxColumn2.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn2.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn2.Name = "usernameDataGridViewTextBoxColumn2";
            this.usernameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn2
            // 
            this.passwordDataGridViewTextBoxColumn2.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn2.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn2.Name = "passwordDataGridViewTextBoxColumn2";
            this.passwordDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // receptionistsTableAdapter
            // 
            this.receptionistsTableAdapter.ClearBeforeFill = true;
            // 
            // housekeepersTableAdapter
            // 
            this.housekeepersTableAdapter.ClearBeforeFill = true;
            // 
            // ManageAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 460);
            this.Controls.Add(this.tabcntrl_Manage_Accounts);
            this.Name = "ManageAccountsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Accounts";
            this.Load += new System.EventHandler(this.ManageAccountsForm_Load);
            this.tabcntrl_Manage_Accounts.ResumeLayout(false);
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Add_Housekeepers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housekeepersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodStayHotelDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Add_Receptionists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodStayHotelDatabaseDataSet)).EndInit();
            this.Edit.ResumeLayout(false);
            this.Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Edit_Housekeepers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Edit_Receptionists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcntrl_Manage_Accounts;
        private System.Windows.Forms.TabPage Add;
        private System.Windows.Forms.TextBox txtbox_Add_Password;
        private System.Windows.Forms.TextBox txtbox_Add_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_User_Type;
        private System.Windows.Forms.DataGridView datagrid_Add_Receptionists;
        private System.Windows.Forms.ComboBox cmbbx_User_Type;
        private System.Windows.Forms.Button btn_Add_User;
        private System.Windows.Forms.TabPage Edit;
        private System.Windows.Forms.TextBox txtbox_Edit_Password;
        private System.Windows.Forms.TextBox txtbox_Edit_Username;
        private System.Windows.Forms.Label lbl_Edit_Password;
        private System.Windows.Forms.Label lbl_Edit_Username;
        private System.Windows.Forms.Button btn_Edit_User;
        private System.Windows.Forms.DataGridView datagrid_Edit_Receptionists;
        private System.Windows.Forms.TextBox txtbox_Add_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Housekeepers;
        private System.Windows.Forms.Label lbl_Receptionists;
        private System.Windows.Forms.DataGridView datagrid_Add_Housekeepers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagrid_Edit_Housekeepers;
        private System.Windows.Forms.TextBox txtbox_Edit_Name;
        private System.Windows.Forms.Label lbl_Edit_Name;
        private GoodStayHotelDatabaseDataSet goodStayHotelDatabaseDataSet;
        private System.Windows.Forms.BindingSource receptionistsBindingSource;
        private GoodStayHotelDatabaseDataSetTableAdapters.ReceptionistsTableAdapter receptionistsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private GoodStayHotelDatabaseDataSet1 goodStayHotelDatabaseDataSet1;
        private System.Windows.Forms.BindingSource housekeepersBindingSource;
        private GoodStayHotelDatabaseDataSet1TableAdapters.HousekeepersTableAdapter housekeepersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn housekeeperIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn housekeeperIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btn_Add_Clear;
        private System.Windows.Forms.Button btn_Edit_Clear;
    }
}