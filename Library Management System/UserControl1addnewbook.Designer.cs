namespace Library_Management_System
{
    partial class UserControl1addnewbook
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
            System.Windows.Forms.Label book_IdLabel;
            System.Windows.Forms.Label author_s_NameLabel;
            System.Windows.Forms.Label iSBN_NumberLabel;
            System.Windows.Forms.Label data_AddLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1addnewbook));
            this.database1COMPLETE_PROJECTDataSet = new Library_Management_System.salgadoDatabase1DataSet();
            this.addnewbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addnewbookTableAdapter = new Library_Management_System.salgadoDatabase1DataSetTableAdapters.addnewbookTableAdapter();
            this.tableAdapterManager = new Library_Management_System.salgadoDatabase1DataSetTableAdapters.TableAdapterManager();
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
            this.button1 = new System.Windows.Forms.Button();
            this.salgadoDatabase1DataSet1 = new Library_Management_System.salgadoDatabase1DataSet1();
            this.addnewbookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addnewbookTableAdapter1 = new Library_Management_System.salgadoDatabase1DataSet1TableAdapters.addnewbookTableAdapter();
            this.tableAdapterManager1 = new Library_Management_System.salgadoDatabase1DataSet1TableAdapters.TableAdapterManager();
            this.addnewbookDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_IdTextBox = new System.Windows.Forms.TextBox();
            this.author_s_NameTextBox = new System.Windows.Forms.TextBox();
            this.iSBN_NumberTextBox = new System.Windows.Forms.TextBox();
            this.data_AddTextBox = new System.Windows.Forms.TextBox();
            book_IdLabel = new System.Windows.Forms.Label();
            author_s_NameLabel = new System.Windows.Forms.Label();
            iSBN_NumberLabel = new System.Windows.Forms.Label();
            data_AddLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1COMPLETE_PROJECTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addnewbookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addnewbookBindingNavigator)).BeginInit();
            this.addnewbookBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salgadoDatabase1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addnewbookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addnewbookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // book_IdLabel
            // 
            book_IdLabel.AutoSize = true;
            book_IdLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            book_IdLabel.Location = new System.Drawing.Point(33, 95);
            book_IdLabel.Name = "book_IdLabel";
            book_IdLabel.Size = new System.Drawing.Size(77, 25);
            book_IdLabel.TabIndex = 3;
            book_IdLabel.Text = "Book Id:";
            // 
            // author_s_NameLabel
            // 
            author_s_NameLabel.AutoSize = true;
            author_s_NameLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            author_s_NameLabel.Location = new System.Drawing.Point(33, 131);
            author_s_NameLabel.Name = "author_s_NameLabel";
            author_s_NameLabel.Size = new System.Drawing.Size(132, 25);
            author_s_NameLabel.TabIndex = 5;
            author_s_NameLabel.Text = "Author\'s Name:";
            author_s_NameLabel.Click += new System.EventHandler(this.author_s_NameLabel_Click);
            // 
            // iSBN_NumberLabel
            // 
            iSBN_NumberLabel.AutoSize = true;
            iSBN_NumberLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iSBN_NumberLabel.Location = new System.Drawing.Point(33, 170);
            iSBN_NumberLabel.Name = "iSBN_NumberLabel";
            iSBN_NumberLabel.Size = new System.Drawing.Size(121, 25);
            iSBN_NumberLabel.TabIndex = 7;
            iSBN_NumberLabel.Text = "ISBN Number:";
            // 
            // data_AddLabel
            // 
            data_AddLabel.AutoSize = true;
            data_AddLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_AddLabel.Location = new System.Drawing.Point(33, 207);
            data_AddLabel.Name = "data_AddLabel";
            data_AddLabel.Size = new System.Drawing.Size(87, 25);
            data_AddLabel.TabIndex = 9;
            data_AddLabel.Text = "Data Add:";
            // 
            // database1COMPLETE_PROJECTDataSet
            // 
            this.database1COMPLETE_PROJECTDataSet.DataSetName = "Database1COMPLETE_PROJECTDataSet";
            this.database1COMPLETE_PROJECTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addnewbookBindingSource
            // 
            this.addnewbookBindingSource.DataMember = "addnewbook";
            this.addnewbookBindingSource.DataSource = this.database1COMPLETE_PROJECTDataSet;
            // 
            // addnewbookTableAdapter
            // 
            this.addnewbookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addnewbookTableAdapter = this.addnewbookTableAdapter;
            this.tableAdapterManager.addnewmemberTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.issuebooksTableAdapter = null;
            this.tableAdapterManager.returnbooksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library_Management_System.salgadoDatabase1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.addnewbookBindingNavigator.Size = new System.Drawing.Size(1151, 25);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1014, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
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
            // addnewbookBindingSource1
            // 
            this.addnewbookBindingSource1.DataMember = "addnewbook";
            this.addnewbookBindingSource1.DataSource = this.salgadoDatabase1DataSet1;
            // 
            // addnewbookTableAdapter1
            // 
            this.addnewbookTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.addnewbookTableAdapter = this.addnewbookTableAdapter1;
            this.tableAdapterManager1.addnewmemberTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.issuebooksTableAdapter = null;
            this.tableAdapterManager1.paymentssTableAdapter = null;
            this.tableAdapterManager1.paymentsTableAdapter = null;
            this.tableAdapterManager1.paymentTableAdapter = null;
            this.tableAdapterManager1.returnbooksTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Library_Management_System.salgadoDatabase1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // addnewbookDataGridView
            // 
            this.addnewbookDataGridView.AutoGenerateColumns = false;
            this.addnewbookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addnewbookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.addnewbookDataGridView.DataSource = this.addnewbookBindingSource1;
            this.addnewbookDataGridView.Location = new System.Drawing.Point(435, 93);
            this.addnewbookDataGridView.Name = "addnewbookDataGridView";
            this.addnewbookDataGridView.Size = new System.Drawing.Size(573, 635);
            this.addnewbookDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Book Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Book Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Author\'s Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Author\'s Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ISBN Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "ISBN Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data Add";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data Add";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // book_IdTextBox
            // 
            this.book_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addnewbookBindingSource1, "Book Id", true));
            this.book_IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_IdTextBox.Location = new System.Drawing.Point(192, 93);
            this.book_IdTextBox.Name = "book_IdTextBox";
            this.book_IdTextBox.Size = new System.Drawing.Size(237, 30);
            this.book_IdTextBox.TabIndex = 4;
            // 
            // author_s_NameTextBox
            // 
            this.author_s_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addnewbookBindingSource1, "Author\'s Name", true));
            this.author_s_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_s_NameTextBox.Location = new System.Drawing.Point(192, 129);
            this.author_s_NameTextBox.Name = "author_s_NameTextBox";
            this.author_s_NameTextBox.Size = new System.Drawing.Size(237, 30);
            this.author_s_NameTextBox.TabIndex = 6;
            // 
            // iSBN_NumberTextBox
            // 
            this.iSBN_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addnewbookBindingSource1, "ISBN Number", true));
            this.iSBN_NumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iSBN_NumberTextBox.Location = new System.Drawing.Point(192, 168);
            this.iSBN_NumberTextBox.Name = "iSBN_NumberTextBox";
            this.iSBN_NumberTextBox.Size = new System.Drawing.Size(237, 30);
            this.iSBN_NumberTextBox.TabIndex = 8;
            // 
            // data_AddTextBox
            // 
            this.data_AddTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addnewbookBindingSource1, "Data Add", true));
            this.data_AddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_AddTextBox.Location = new System.Drawing.Point(192, 205);
            this.data_AddTextBox.Name = "data_AddTextBox";
            this.data_AddTextBox.Size = new System.Drawing.Size(237, 30);
            this.data_AddTextBox.TabIndex = 10;
            // 
            // UserControl1addnewbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(book_IdLabel);
            this.Controls.Add(this.book_IdTextBox);
            this.Controls.Add(author_s_NameLabel);
            this.Controls.Add(this.author_s_NameTextBox);
            this.Controls.Add(iSBN_NumberLabel);
            this.Controls.Add(this.iSBN_NumberTextBox);
            this.Controls.Add(data_AddLabel);
            this.Controls.Add(this.data_AddTextBox);
            this.Controls.Add(this.addnewbookDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addnewbookBindingNavigator);
            this.Name = "UserControl1addnewbook";
            this.Size = new System.Drawing.Size(1151, 728);
            ((System.ComponentModel.ISupportInitialize)(this.database1COMPLETE_PROJECTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addnewbookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addnewbookBindingNavigator)).EndInit();
            this.addnewbookBindingNavigator.ResumeLayout(false);
            this.addnewbookBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salgadoDatabase1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addnewbookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addnewbookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private salgadoDatabase1DataSet database1COMPLETE_PROJECTDataSet;
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
        private System.Windows.Forms.Button button1;
        private salgadoDatabase1DataSet1 salgadoDatabase1DataSet1;
        private System.Windows.Forms.BindingSource addnewbookBindingSource1;
        private salgadoDatabase1DataSet1TableAdapters.addnewbookTableAdapter addnewbookTableAdapter1;
        private salgadoDatabase1DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView addnewbookDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox book_IdTextBox;
        private System.Windows.Forms.TextBox author_s_NameTextBox;
        private System.Windows.Forms.TextBox iSBN_NumberTextBox;
        private System.Windows.Forms.TextBox data_AddTextBox;
    }
}
