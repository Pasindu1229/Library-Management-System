namespace Library_Management_System
{
    partial class issuebookUserControl1
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
            System.Windows.Forms.Label borrower_s_NameLabel;
            System.Windows.Forms.Label data_IssuedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issuebookUserControl1));
            this.salgadoDatabase1DataSet1 = new Library_Management_System.salgadoDatabase1DataSet1();
            this.issuebooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issuebooksTableAdapter = new Library_Management_System.salgadoDatabase1DataSet1TableAdapters.issuebooksTableAdapter();
            this.tableAdapterManager = new Library_Management_System.salgadoDatabase1DataSet1TableAdapters.TableAdapterManager();
            this.issuebooksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.issuebooksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.issuebooksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_IdTextBox = new System.Windows.Forms.TextBox();
            this.author_s_NameTextBox = new System.Windows.Forms.TextBox();
            this.borrower_s_NameTextBox = new System.Windows.Forms.TextBox();
            this.data_IssuedTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            book_IdLabel = new System.Windows.Forms.Label();
            author_s_NameLabel = new System.Windows.Forms.Label();
            borrower_s_NameLabel = new System.Windows.Forms.Label();
            data_IssuedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salgadoDatabase1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuebooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuebooksBindingNavigator)).BeginInit();
            this.issuebooksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuebooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // book_IdLabel
            // 
            book_IdLabel.AutoSize = true;
            book_IdLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            book_IdLabel.Location = new System.Drawing.Point(42, 95);
            book_IdLabel.Name = "book_IdLabel";
            book_IdLabel.Size = new System.Drawing.Size(77, 25);
            book_IdLabel.TabIndex = 2;
            book_IdLabel.Text = "Book Id:";
            // 
            // author_s_NameLabel
            // 
            author_s_NameLabel.AutoSize = true;
            author_s_NameLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            author_s_NameLabel.Location = new System.Drawing.Point(42, 130);
            author_s_NameLabel.Name = "author_s_NameLabel";
            author_s_NameLabel.Size = new System.Drawing.Size(132, 25);
            author_s_NameLabel.TabIndex = 4;
            author_s_NameLabel.Text = "Author\'s Name:";
            // 
            // borrower_s_NameLabel
            // 
            borrower_s_NameLabel.AutoSize = true;
            borrower_s_NameLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            borrower_s_NameLabel.Location = new System.Drawing.Point(42, 166);
            borrower_s_NameLabel.Name = "borrower_s_NameLabel";
            borrower_s_NameLabel.Size = new System.Drawing.Size(154, 25);
            borrower_s_NameLabel.TabIndex = 6;
            borrower_s_NameLabel.Text = "Borrower\'s Name:";
            // 
            // data_IssuedLabel
            // 
            data_IssuedLabel.AutoSize = true;
            data_IssuedLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_IssuedLabel.Location = new System.Drawing.Point(42, 202);
            data_IssuedLabel.Name = "data_IssuedLabel";
            data_IssuedLabel.Size = new System.Drawing.Size(111, 25);
            data_IssuedLabel.TabIndex = 8;
            data_IssuedLabel.Text = "Data Issued:";
            // 
            // salgadoDatabase1DataSet1
            // 
            this.salgadoDatabase1DataSet1.DataSetName = "salgadoDatabase1DataSet1";
            this.salgadoDatabase1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issuebooksBindingSource
            // 
            this.issuebooksBindingSource.DataMember = "issuebooks";
            this.issuebooksBindingSource.DataSource = this.salgadoDatabase1DataSet1;
            // 
            // issuebooksTableAdapter
            // 
            this.issuebooksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addnewbookTableAdapter = null;
            this.tableAdapterManager.addnewmemberTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.issuebooksTableAdapter = this.issuebooksTableAdapter;
            this.tableAdapterManager.paymentssTableAdapter = null;
            this.tableAdapterManager.paymentsTableAdapter = null;
            this.tableAdapterManager.paymentTableAdapter = null;
            this.tableAdapterManager.returnbooksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library_Management_System.salgadoDatabase1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // issuebooksBindingNavigator
            // 
            this.issuebooksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.issuebooksBindingNavigator.BindingSource = this.issuebooksBindingSource;
            this.issuebooksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.issuebooksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.issuebooksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.issuebooksBindingNavigatorSaveItem});
            this.issuebooksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.issuebooksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.issuebooksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.issuebooksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.issuebooksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.issuebooksBindingNavigator.Name = "issuebooksBindingNavigator";
            this.issuebooksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.issuebooksBindingNavigator.Size = new System.Drawing.Size(1151, 25);
            this.issuebooksBindingNavigator.TabIndex = 0;
            this.issuebooksBindingNavigator.Text = "bindingNavigator1";
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
            // issuebooksBindingNavigatorSaveItem
            // 
            this.issuebooksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.issuebooksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("issuebooksBindingNavigatorSaveItem.Image")));
            this.issuebooksBindingNavigatorSaveItem.Name = "issuebooksBindingNavigatorSaveItem";
            this.issuebooksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.issuebooksBindingNavigatorSaveItem.Text = "Save Data";
            this.issuebooksBindingNavigatorSaveItem.Click += new System.EventHandler(this.issuebooksBindingNavigatorSaveItem_Click);
            // 
            // issuebooksDataGridView
            // 
            this.issuebooksDataGridView.AutoGenerateColumns = false;
            this.issuebooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuebooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.issuebooksDataGridView.DataSource = this.issuebooksBindingSource;
            this.issuebooksDataGridView.Location = new System.Drawing.Point(435, 93);
            this.issuebooksDataGridView.Name = "issuebooksDataGridView";
            this.issuebooksDataGridView.Size = new System.Drawing.Size(573, 635);
            this.issuebooksDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data Issued";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data Issued";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // book_IdTextBox
            // 
            this.book_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issuebooksBindingSource, "Book Id", true));
            this.book_IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_IdTextBox.Location = new System.Drawing.Point(230, 93);
            this.book_IdTextBox.Name = "book_IdTextBox";
            this.book_IdTextBox.Size = new System.Drawing.Size(199, 30);
            this.book_IdTextBox.TabIndex = 3;
            // 
            // author_s_NameTextBox
            // 
            this.author_s_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issuebooksBindingSource, "Author\'s Name", true));
            this.author_s_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_s_NameTextBox.Location = new System.Drawing.Point(230, 128);
            this.author_s_NameTextBox.Name = "author_s_NameTextBox";
            this.author_s_NameTextBox.Size = new System.Drawing.Size(199, 30);
            this.author_s_NameTextBox.TabIndex = 5;
            this.author_s_NameTextBox.TextChanged += new System.EventHandler(this.author_s_NameTextBox_TextChanged);
            // 
            // borrower_s_NameTextBox
            // 
            this.borrower_s_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issuebooksBindingSource, "Borrower\'s Name", true));
            this.borrower_s_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrower_s_NameTextBox.Location = new System.Drawing.Point(230, 164);
            this.borrower_s_NameTextBox.Name = "borrower_s_NameTextBox";
            this.borrower_s_NameTextBox.Size = new System.Drawing.Size(199, 30);
            this.borrower_s_NameTextBox.TabIndex = 7;
            // 
            // data_IssuedTextBox
            // 
            this.data_IssuedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issuebooksBindingSource, "Data Issued", true));
            this.data_IssuedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_IssuedTextBox.Location = new System.Drawing.Point(230, 200);
            this.data_IssuedTextBox.Name = "data_IssuedTextBox";
            this.data_IssuedTextBox.Size = new System.Drawing.Size(199, 30);
            this.data_IssuedTextBox.TabIndex = 9;
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
            // issuebookUserControl1
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
            this.Controls.Add(data_IssuedLabel);
            this.Controls.Add(this.data_IssuedTextBox);
            this.Controls.Add(this.issuebooksDataGridView);
            this.Controls.Add(this.issuebooksBindingNavigator);
            this.Name = "issuebookUserControl1";
            this.Size = new System.Drawing.Size(1151, 728);
            ((System.ComponentModel.ISupportInitialize)(this.salgadoDatabase1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuebooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuebooksBindingNavigator)).EndInit();
            this.issuebooksBindingNavigator.ResumeLayout(false);
            this.issuebooksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuebooksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private salgadoDatabase1DataSet1 salgadoDatabase1DataSet1;
        private System.Windows.Forms.BindingSource issuebooksBindingSource;
        private salgadoDatabase1DataSet1TableAdapters.issuebooksTableAdapter issuebooksTableAdapter;
        private salgadoDatabase1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator issuebooksBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton issuebooksBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView issuebooksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox book_IdTextBox;
        private System.Windows.Forms.TextBox author_s_NameTextBox;
        private System.Windows.Forms.TextBox borrower_s_NameTextBox;
        private System.Windows.Forms.TextBox data_IssuedTextBox;
        private System.Windows.Forms.Button button1;
    }
}
