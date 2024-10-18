namespace Library_Management_System
{
    partial class UserControl1addnewmember
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label member_IdLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label nIC_NoLabel;
            System.Windows.Forms.Label contact_NumberLabel;
            System.Windows.Forms.Label genderLabel3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1addnewmember));
            this.database1DataSet = new Library_Management_System.salgadoDatabase1DataSet();
            this.addnewbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addnewbookTableAdapter = new Library_Management_System.salgadoDatabase1DataSetTableAdapters.addnewbookTableAdapter();
            this.tableAdapterManager = new Library_Management_System.salgadoDatabase1DataSetTableAdapters.TableAdapterManager();
            this.addnewmemberTableAdapter = new Library_Management_System.salgadoDatabase1DataSetTableAdapters.addnewmemberTableAdapter();
            this.addnewbookBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addnewbookBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.addnewmemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.salgadoDatabase1DataSet1 = new Library_Management_System.salgadoDatabase1DataSet1();
            this.addnewmemberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addnewmemberTableAdapter1 = new Library_Management_System.salgadoDatabase1DataSet1TableAdapters.addnewmemberTableAdapter();
            this.tableAdapterManager1 = new Library_Management_System.salgadoDatabase1DataSet1TableAdapters.TableAdapterManager();
            this.addnewmemberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_IdTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.nIC_NoTextBox = new System.Windows.Forms.TextBox();
            this.contact_NumberTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            member_IdLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            nIC_NoLabel = new System.Windows.Forms.Label();
            contact_NumberLabel = new System.Windows.Forms.Label();
            genderLabel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addnewbookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addnewbookBindingNavigator)).BeginInit();
            this.addnewbookBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addnewmemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salgadoDatabase1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addnewmemberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addnewmemberDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // member_IdLabel
            // 
            member_IdLabel.AutoSize = true;
            member_IdLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            member_IdLabel.Location = new System.Drawing.Point(33, 95);
            member_IdLabel.Name = "member_IdLabel";
            member_IdLabel.Size = new System.Drawing.Size(102, 25);
            member_IdLabel.TabIndex = 3;
            member_IdLabel.Text = "Member Id:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            first_NameLabel.Location = new System.Drawing.Point(32, 131);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(101, 25);
            first_NameLabel.TabIndex = 5;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            last_NameLabel.Location = new System.Drawing.Point(32, 167);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(99, 25);
            last_NameLabel.TabIndex = 7;
            last_NameLabel.Text = "Last Name:";
            // 
            // nIC_NoLabel
            // 
            nIC_NoLabel.AutoSize = true;
            nIC_NoLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIC_NoLabel.Location = new System.Drawing.Point(32, 203);
            nIC_NoLabel.Name = "nIC_NoLabel";
            nIC_NoLabel.Size = new System.Drawing.Size(69, 25);
            nIC_NoLabel.TabIndex = 9;
            nIC_NoLabel.Text = "NIC No:";
            // 
            // contact_NumberLabel
            // 
            contact_NumberLabel.AutoSize = true;
            contact_NumberLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contact_NumberLabel.Location = new System.Drawing.Point(32, 239);
            contact_NumberLabel.Name = "contact_NumberLabel";
            contact_NumberLabel.Size = new System.Drawing.Size(146, 25);
            contact_NumberLabel.TabIndex = 11;
            contact_NumberLabel.Text = "Contact Number:";
            // 
            // genderLabel3
            // 
            genderLabel3.AutoSize = true;
            genderLabel3.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel3.Location = new System.Drawing.Point(32, 278);
            genderLabel3.Name = "genderLabel3";
            genderLabel3.Size = new System.Drawing.Size(74, 25);
            genderLabel3.TabIndex = 19;
            genderLabel3.Text = "Gender:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1COMPLETE_PROJECTDataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addnewbookBindingSource
            // 
            this.addnewbookBindingSource.DataMember = "addnewbook";
            this.addnewbookBindingSource.DataSource = this.database1DataSet;
            // 
            // addnewbookTableAdapter
            // 
            this.addnewbookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addnewbookTableAdapter = this.addnewbookTableAdapter;
            this.tableAdapterManager.addnewmemberTableAdapter = this.addnewmemberTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.issuebooksTableAdapter = null;
            this.tableAdapterManager.returnbooksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library_Management_System.salgadoDatabase1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // addnewmemberTableAdapter
            // 
            this.addnewmemberTableAdapter.ClearBeforeFill = true;
            // 
            // addnewbookBindingNavigator
            // 
            this.addnewbookBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.addnewbookBindingNavigator.BindingSource = this.addnewbookBindingSource;
            this.addnewbookBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.addnewbookBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.addnewbookBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.addnewbookBindingNavigatorSaveItem});
            this.addnewbookBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.addnewbookBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.addnewbookBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.addnewbookBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.addnewbookBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.addnewbookBindingNavigator.Name = "addnewbookBindingNavigator";
            this.addnewbookBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.addnewbookBindingNavigator.Size = new System.Drawing.Size(1185, 25);
            this.addnewbookBindingNavigator.TabIndex = 0;
            this.addnewbookBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // addnewbookBindingNavigatorSaveItem
            // 
            this.addnewbookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addnewbookBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("addnewbookBindingNavigatorSaveItem.Image")));
            this.addnewbookBindingNavigatorSaveItem.Name = "addnewbookBindingNavigatorSaveItem";
            this.addnewbookBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.addnewbookBindingNavigatorSaveItem.Text = "Save Data";
            this.addnewbookBindingNavigatorSaveItem.Click += new System.EventHandler(this.addnewbookBindingNavigatorSaveItem_Click);
            // 
            // addnewmemberBindingSource
            // 
            this.addnewmemberBindingSource.DataMember = "addnewmember";
            this.addnewmemberBindingSource.DataSource = this.database1DataSet;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1082, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salgadoDatabase1DataSet1
            // 
            this.salgadoDatabase1DataSet1.DataSetName = "salgadoDatabase1DataSet1";
            this.salgadoDatabase1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addnewmemberBindingSource1
            // 
            this.addnewmemberBindingSource1.DataMember = "addnewmember";
            this.addnewmemberBindingSource1.DataSource = this.salgadoDatabase1DataSet1;
            // 
            // addnewmemberTableAdapter1
            // 
            this.addnewmemberTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.addnewbookTableAdapter = null;
            this.tableAdapterManager1.addnewmemberTableAdapter = this.addnewmemberTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.issuebooksTableAdapter = null;
            this.tableAdapterManager1.paymentssTableAdapter = null;
            this.tableAdapterManager1.paymentsTableAdapter = null;
            this.tableAdapterManager1.paymentTableAdapter = null;
            this.tableAdapterManager1.returnbooksTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Library_Management_System.salgadoDatabase1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // addnewmemberDataGridView
            // 
            this.addnewmemberDataGridView.AutoGenerateColumns = false;
            this.addnewmemberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addnewmemberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.addnewmemberDataGridView.DataSource = this.addnewmemberBindingSource1;
            this.addnewmemberDataGridView.Location = new System.Drawing.Point(435, 93);
            this.addnewmemberDataGridView.Name = "addnewmemberDataGridView";
            this.addnewmemberDataGridView.Size = new System.Drawing.Size(641, 649);
            this.addnewmemberDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Member Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Member Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NIC No";
            this.dataGridViewTextBoxColumn4.HeaderText = "NIC No";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Contact Number";
            this.dataGridViewTextBoxColumn5.HeaderText = "Contact Number";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn6.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // member_IdTextBox
            // 
            this.member_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addnewmemberBindingSource1, "Member Id", true));
            this.member_IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_IdTextBox.Location = new System.Drawing.Point(192, 93);
            this.member_IdTextBox.Name = "member_IdTextBox";
            this.member_IdTextBox.Size = new System.Drawing.Size(237, 30);
            this.member_IdTextBox.TabIndex = 4;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addnewmemberBindingSource1, "First Name", true));
            this.first_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_NameTextBox.Location = new System.Drawing.Point(192, 129);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(237, 30);
            this.first_NameTextBox.TabIndex = 6;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addnewmemberBindingSource1, "Last Name", true));
            this.last_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_NameTextBox.Location = new System.Drawing.Point(192, 165);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(237, 30);
            this.last_NameTextBox.TabIndex = 8;
            // 
            // nIC_NoTextBox
            // 
            this.nIC_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addnewmemberBindingSource1, "NIC No", true));
            this.nIC_NoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nIC_NoTextBox.Location = new System.Drawing.Point(192, 201);
            this.nIC_NoTextBox.Name = "nIC_NoTextBox";
            this.nIC_NoTextBox.Size = new System.Drawing.Size(237, 30);
            this.nIC_NoTextBox.TabIndex = 10;
            // 
            // contact_NumberTextBox
            // 
            this.contact_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addnewmemberBindingSource1, "Contact Number", true));
            this.contact_NumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_NumberTextBox.Location = new System.Drawing.Point(192, 237);
            this.contact_NumberTextBox.Name = "contact_NumberTextBox";
            this.contact_NumberTextBox.Size = new System.Drawing.Size(237, 30);
            this.contact_NumberTextBox.TabIndex = 12;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addnewmemberBindingSource1, "Gender", true));
            this.genderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTextBox.Location = new System.Drawing.Point(192, 273);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(237, 30);
            this.genderTextBox.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(133, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 47);
            this.button2.TabIndex = 20;
            this.button2.Text = "ADD NEW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserControl1addnewmember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.button2);
            this.Controls.Add(genderLabel3);
            this.Controls.Add(member_IdLabel);
            this.Controls.Add(this.member_IdTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(nIC_NoLabel);
            this.Controls.Add(this.nIC_NoTextBox);
            this.Controls.Add(contact_NumberLabel);
            this.Controls.Add(this.contact_NumberTextBox);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.addnewmemberDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addnewbookBindingNavigator);
            this.Name = "UserControl1addnewmember";
            this.Size = new System.Drawing.Size(1185, 745);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addnewbookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addnewbookBindingNavigator)).EndInit();
            this.addnewbookBindingNavigator.ResumeLayout(false);
            this.addnewbookBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addnewmemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salgadoDatabase1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addnewmemberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addnewmemberDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private salgadoDatabase1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource addnewbookBindingSource;
        private salgadoDatabase1DataSetTableAdapters.addnewbookTableAdapter addnewbookTableAdapter;
        private salgadoDatabase1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator addnewbookBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton addnewbookBindingNavigatorSaveItem;
        private salgadoDatabase1DataSetTableAdapters.addnewmemberTableAdapter addnewmemberTableAdapter;
        private System.Windows.Forms.BindingSource addnewmemberBindingSource;
        private System.Windows.Forms.Button button1;
        private salgadoDatabase1DataSet1 salgadoDatabase1DataSet1;
        private System.Windows.Forms.BindingSource addnewmemberBindingSource1;
        private salgadoDatabase1DataSet1TableAdapters.addnewmemberTableAdapter addnewmemberTableAdapter1;
        private salgadoDatabase1DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView addnewmemberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox member_IdTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox nIC_NoTextBox;
        private System.Windows.Forms.TextBox contact_NumberTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.Button button2;
    }
}
