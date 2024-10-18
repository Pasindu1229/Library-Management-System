namespace Library_Management_System
{
    partial class returnbookUserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(returnbookUserControl1));
            System.Windows.Forms.Label book_IdLabel;
            System.Windows.Forms.Label author_s_NameLabel;
            System.Windows.Forms.Label borrower_s_NameLabel;
            System.Windows.Forms.Label data_ReturnLabel;
            this.salgadoDatabase1DataSet1 = new Library_Management_System.salgadoDatabase1DataSet1();
            this.returnbooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnbooksTableAdapter = new Library_Management_System.salgadoDatabase1DataSet1TableAdapters.returnbooksTableAdapter();
            this.tableAdapterManager = new Library_Management_System.salgadoDatabase1DataSet1TableAdapters.TableAdapterManager();
            this.returnbooksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.returnbooksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.returnbooksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_IdTextBox = new System.Windows.Forms.TextBox();
            this.author_s_NameTextBox = new System.Windows.Forms.TextBox();
            this.borrower_s_NameTextBox = new System.Windows.Forms.TextBox();
            this.data_ReturnTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            book_IdLabel = new System.Windows.Forms.Label();
            author_s_NameLabel = new System.Windows.Forms.Label();
            borrower_s_NameLabel = new System.Windows.Forms.Label();
            data_ReturnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salgadoDatabase1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnbooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnbooksBindingNavigator)).BeginInit();
            this.returnbooksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnbooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // salgadoDatabase1DataSet1
            // 
            this.salgadoDatabase1DataSet1.DataSetName = "salgadoDatabase1DataSet1";
            this.salgadoDatabase1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // returnbooksBindingSource
            // 
            this.returnbooksBindingSource.DataMember = "returnbooks";
            this.returnbooksBindingSource.DataSource = this.salgadoDatabase1DataSet1;
            // 
            // returnbooksTableAdapter
            // 
            this.returnbooksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addnewbookTableAdapter = null;
            this.tableAdapterManager.addnewmemberTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.issuebooksTableAdapter = null;
            this.tableAdapterManager.paymentssTableAdapter = null;
            this.tableAdapterManager.paymentsTableAdapter = null;
            this.tableAdapterManager.paymentTableAdapter = null;
            this.tableAdapterManager.returnbooksTableAdapter = this.returnbooksTableAdapter;
            this.tableAdapterManager.UpdateOrder = Library_Management_System.salgadoDatabase1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // returnbooksBindingNavigator
            // 
            this.returnbooksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.returnbooksBindingNavigator.BindingSource = this.returnbooksBindingSource;
            this.returnbooksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.returnbooksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.returnbooksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.returnbooksBindingNavigatorSaveItem});
            this.returnbooksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.returnbooksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.returnbooksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.returnbooksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.returnbooksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.returnbooksBindingNavigator.Name = "returnbooksBindingNavigator";
            this.returnbooksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.returnbooksBindingNavigator.Size = new System.Drawing.Size(1151, 25);
            this.returnbooksBindingNavigator.TabIndex = 0;
            this.returnbooksBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // returnbooksBindingNavigatorSaveItem
            // 
            this.returnbooksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.returnbooksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("returnbooksBindingNavigatorSaveItem.Image")));
            this.returnbooksBindingNavigatorSaveItem.Name = "returnbooksBindingNavigatorSaveItem";
            this.returnbooksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.returnbooksBindingNavigatorSaveItem.Text = "Save Data";
            this.returnbooksBindingNavigatorSaveItem.Click += new System.EventHandler(this.returnbooksBindingNavigatorSaveItem_Click);
            // 
            // returnbooksDataGridView
            // 
            this.returnbooksDataGridView.AutoGenerateColumns = false;
            this.returnbooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnbooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.returnbooksDataGridView.DataSource = this.returnbooksBindingSource;
            this.returnbooksDataGridView.Location = new System.Drawing.Point(435, 93);
            this.returnbooksDataGridView.Name = "returnbooksDataGridView";
            this.returnbooksDataGridView.Size = new System.Drawing.Size(565, 635);
            this.returnbooksDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Borrower\'s Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Borrower\'s Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data Return";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data Return";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // book_IdLabel
            // 
            book_IdLabel.AutoSize = true;
            book_IdLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            book_IdLabel.Location = new System.Drawing.Point(40, 93);
            book_IdLabel.Name = "book_IdLabel";
            book_IdLabel.Size = new System.Drawing.Size(77, 25);
            book_IdLabel.TabIndex = 2;
            book_IdLabel.Text = "Book Id:";
            // 
            // book_IdTextBox
            // 
            this.book_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returnbooksBindingSource, "Book Id", true));
            this.book_IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_IdTextBox.Location = new System.Drawing.Point(210, 91);
            this.book_IdTextBox.Name = "book_IdTextBox";
            this.book_IdTextBox.Size = new System.Drawing.Size(219, 30);
            this.book_IdTextBox.TabIndex = 3;
            // 
            // author_s_NameLabel
            // 
            author_s_NameLabel.AutoSize = true;
            author_s_NameLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            author_s_NameLabel.Location = new System.Drawing.Point(40, 129);
            author_s_NameLabel.Name = "author_s_NameLabel";
            author_s_NameLabel.Size = new System.Drawing.Size(132, 25);
            author_s_NameLabel.TabIndex = 4;
            author_s_NameLabel.Text = "Author\'s Name:";
            // 
            // author_s_NameTextBox
            // 
            this.author_s_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returnbooksBindingSource, "Author\'s Name", true));
            this.author_s_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_s_NameTextBox.Location = new System.Drawing.Point(210, 127);
            this.author_s_NameTextBox.Name = "author_s_NameTextBox";
            this.author_s_NameTextBox.Size = new System.Drawing.Size(219, 30);
            this.author_s_NameTextBox.TabIndex = 5;
            // 
            // borrower_s_NameLabel
            // 
            borrower_s_NameLabel.AutoSize = true;
            borrower_s_NameLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            borrower_s_NameLabel.Location = new System.Drawing.Point(40, 165);
            borrower_s_NameLabel.Name = "borrower_s_NameLabel";
            borrower_s_NameLabel.Size = new System.Drawing.Size(154, 25);
            borrower_s_NameLabel.TabIndex = 6;
            borrower_s_NameLabel.Text = "Borrower\'s Name:";
            // 
            // borrower_s_NameTextBox
            // 
            this.borrower_s_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returnbooksBindingSource, "Borrower\'s Name", true));
            this.borrower_s_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrower_s_NameTextBox.Location = new System.Drawing.Point(210, 163);
            this.borrower_s_NameTextBox.Name = "borrower_s_NameTextBox";
            this.borrower_s_NameTextBox.Size = new System.Drawing.Size(219, 30);
            this.borrower_s_NameTextBox.TabIndex = 7;
            // 
            // data_ReturnLabel
            // 
            data_ReturnLabel.AutoSize = true;
            data_ReturnLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_ReturnLabel.Location = new System.Drawing.Point(40, 201);
            data_ReturnLabel.Name = "data_ReturnLabel";
            data_ReturnLabel.Size = new System.Drawing.Size(111, 25);
            data_ReturnLabel.TabIndex = 8;
            data_ReturnLabel.Text = "Data Return:";
            // 
            // data_ReturnTextBox
            // 
            this.data_ReturnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returnbooksBindingSource, "Data Return", true));
            this.data_ReturnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_ReturnTextBox.Location = new System.Drawing.Point(210, 199);
            this.data_ReturnTextBox.Name = "data_ReturnTextBox";
            this.data_ReturnTextBox.Size = new System.Drawing.Size(219, 30);
            this.data_ReturnTextBox.TabIndex = 9;
            this.data_ReturnTextBox.TextChanged += new System.EventHandler(this.data_ReturnTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1014, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // returnbookUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.button1);
            this.Controls.Add(book_IdLabel);
            this.Controls.Add(this.book_IdTextBox);
            this.Controls.Add(author_s_NameLabel);
            this.Controls.Add(this.author_s_NameTextBox);
            this.Controls.Add(borrower_s_NameLabel);
            this.Controls.Add(this.borrower_s_NameTextBox);
            this.Controls.Add(data_ReturnLabel);
            this.Controls.Add(this.data_ReturnTextBox);
            this.Controls.Add(this.returnbooksDataGridView);
            this.Controls.Add(this.returnbooksBindingNavigator);
            this.Name = "returnbookUserControl1";
            this.Size = new System.Drawing.Size(1151, 728);
            ((System.ComponentModel.ISupportInitialize)(this.salgadoDatabase1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnbooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnbooksBindingNavigator)).EndInit();
            this.returnbooksBindingNavigator.ResumeLayout(false);
            this.returnbooksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnbooksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private salgadoDatabase1DataSet1 salgadoDatabase1DataSet1;
        private System.Windows.Forms.BindingSource returnbooksBindingSource;
        private salgadoDatabase1DataSet1TableAdapters.returnbooksTableAdapter returnbooksTableAdapter;
        private salgadoDatabase1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator returnbooksBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton returnbooksBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView returnbooksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox book_IdTextBox;
        private System.Windows.Forms.TextBox author_s_NameTextBox;
        private System.Windows.Forms.TextBox borrower_s_NameTextBox;
        private System.Windows.Forms.TextBox data_ReturnTextBox;
        private System.Windows.Forms.Button button1;
    }
}
