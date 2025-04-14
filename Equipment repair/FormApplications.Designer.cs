namespace Equipment_repair
{
    partial class FormApplications
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
            System.Windows.Forms.Label iD_TypeLabel;
            System.Windows.Forms.Label serialNumberLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label iD_UserLabel;
            System.Windows.Forms.Label iD_FailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApplications));
            this.databaseDataSet = new Equipment_repair.DatabaseDataSet();
            this.applicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationsTableAdapter = new Equipment_repair.DatabaseDataSetTableAdapters.ApplicationsTableAdapter();
            this.tableAdapterManager = new Equipment_repair.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.typesTableAdapter = new Equipment_repair.DatabaseDataSetTableAdapters.TypesTableAdapter();
            this.applicationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.applicationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.serialNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxType = new System.Windows.Forms.ComboBox();
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.boxUser = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Equipment_repair.DatabaseDataSetTableAdapters.UsersTableAdapter();
            this.butFirst = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.butNext = new System.Windows.Forms.Button();
            this.butLast = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.boxFail = new System.Windows.Forms.ComboBox();
            this.failsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.failsTableAdapter = new Equipment_repair.DatabaseDataSetTableAdapters.FailsTableAdapter();
            iD_TypeLabel = new System.Windows.Forms.Label();
            serialNumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            iD_UserLabel = new System.Windows.Forms.Label();
            iD_FailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingNavigator)).BeginInit();
            this.applicationsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.failsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_TypeLabel
            // 
            iD_TypeLabel.AutoSize = true;
            iD_TypeLabel.Location = new System.Drawing.Point(43, 108);
            iD_TypeLabel.Name = "iD_TypeLabel";
            iD_TypeLabel.Size = new System.Drawing.Size(103, 13);
            iD_TypeLabel.TabIndex = 1;
            iD_TypeLabel.Text = "Тип оборудования:";
            // 
            // serialNumberLabel
            // 
            serialNumberLabel.AutoSize = true;
            serialNumberLabel.Location = new System.Drawing.Point(50, 134);
            serialNumberLabel.Name = "serialNumberLabel";
            serialNumberLabel.Size = new System.Drawing.Size(96, 13);
            serialNumberLabel.TabIndex = 3;
            serialNumberLabel.Text = "Серийный номер:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(83, 186);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(60, 13);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Описание:";
            // 
            // iD_UserLabel
            // 
            iD_UserLabel.AutoSize = true;
            iD_UserLabel.Location = new System.Drawing.Point(97, 319);
            iD_UserLabel.Name = "iD_UserLabel";
            iD_UserLabel.Size = new System.Drawing.Size(46, 13);
            iD_UserLabel.TabIndex = 7;
            iD_UserLabel.Text = "Клиент:";
            // 
            // iD_FailLabel
            // 
            iD_FailLabel.AutoSize = true;
            iD_FailLabel.Location = new System.Drawing.Point(37, 160);
            iD_FailLabel.Name = "iD_FailLabel";
            iD_FailLabel.Size = new System.Drawing.Size(109, 13);
            iD_FailLabel.TabIndex = 19;
            iD_FailLabel.Text = "Тип неисправности:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicationsBindingSource
            // 
            this.applicationsBindingSource.DataMember = "Applications";
            this.applicationsBindingSource.DataSource = this.databaseDataSet;
            // 
            // applicationsTableAdapter
            // 
            this.applicationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApplicationsTableAdapter = this.applicationsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FailsTableAdapter = null;
            this.tableAdapterManager.PostsTableAdapter = null;
            this.tableAdapterManager.PrioritiesTableAdapter = null;
            this.tableAdapterManager.RegistrationsTableAdapter = null;
            this.tableAdapterManager.ReportsTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.TypesTableAdapter = this.typesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Equipment_repair.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // applicationsBindingNavigator
            // 
            this.applicationsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.applicationsBindingNavigator.BindingSource = this.applicationsBindingSource;
            this.applicationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.applicationsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.applicationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.applicationsBindingNavigatorSaveItem});
            this.applicationsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.applicationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.applicationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.applicationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.applicationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.applicationsBindingNavigator.Name = "applicationsBindingNavigator";
            this.applicationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.applicationsBindingNavigator.Size = new System.Drawing.Size(521, 25);
            this.applicationsBindingNavigator.TabIndex = 0;
            this.applicationsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // applicationsBindingNavigatorSaveItem
            // 
            this.applicationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.applicationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("applicationsBindingNavigatorSaveItem.Image")));
            this.applicationsBindingNavigatorSaveItem.Name = "applicationsBindingNavigatorSaveItem";
            this.applicationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.applicationsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.applicationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.applicationsBindingNavigatorSaveItem_Click);
            // 
            // serialNumberTextBox
            // 
            this.serialNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serialNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicationsBindingSource, "SerialNumber", true));
            this.serialNumberTextBox.Location = new System.Drawing.Point(152, 134);
            this.serialNumberTextBox.Name = "serialNumberTextBox";
            this.serialNumberTextBox.Size = new System.Drawing.Size(121, 13);
            this.serialNumberTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(227, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Заявки";
            // 
            // boxType
            // 
            this.boxType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicationsBindingSource, "ID_Type", true));
            this.boxType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.applicationsBindingSource, "ID_Type", true));
            this.boxType.DataSource = this.typesBindingSource;
            this.boxType.DisplayMember = "NameType";
            this.boxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxType.Location = new System.Drawing.Point(152, 105);
            this.boxType.Name = "boxType";
            this.boxType.Size = new System.Drawing.Size(121, 21);
            this.boxType.TabIndex = 10;
            this.boxType.ValueMember = "ID_TYPE";
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataMember = "Types";
            this.typesBindingSource.DataSource = this.databaseDataSet;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicationsBindingSource, "Description", true));
            this.richTextBox1.Location = new System.Drawing.Point(152, 183);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(264, 127);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // boxUser
            // 
            this.boxUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicationsBindingSource, "ID_User", true));
            this.boxUser.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.applicationsBindingSource, "ID_User", true));
            this.boxUser.DataSource = this.usersBindingSource;
            this.boxUser.DisplayMember = "Firstname";
            this.boxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxUser.Location = new System.Drawing.Point(152, 316);
            this.boxUser.Name = "boxUser";
            this.boxUser.Size = new System.Drawing.Size(264, 21);
            this.boxUser.TabIndex = 12;
            this.boxUser.ValueMember = "ID_USER";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.databaseDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // butFirst
            // 
            this.butFirst.Location = new System.Drawing.Point(46, 370);
            this.butFirst.Name = "butFirst";
            this.butFirst.Size = new System.Drawing.Size(97, 23);
            this.butFirst.TabIndex = 13;
            this.butFirst.Text = "Первая";
            this.butFirst.UseVisualStyleBackColor = true;
            this.butFirst.Click += new System.EventHandler(this.butFirst_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(149, 370);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(97, 23);
            this.butBack.TabIndex = 14;
            this.butBack.Text = "Предыдущая";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butNext
            // 
            this.butNext.Location = new System.Drawing.Point(252, 370);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(97, 23);
            this.butNext.TabIndex = 15;
            this.butNext.Text = "Следующая";
            this.butNext.UseVisualStyleBackColor = true;
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // butLast
            // 
            this.butLast.Location = new System.Drawing.Point(355, 370);
            this.butLast.Name = "butLast";
            this.butLast.Size = new System.Drawing.Size(97, 23);
            this.butLast.TabIndex = 16;
            this.butLast.Text = "Последняя";
            this.butLast.UseVisualStyleBackColor = true;
            this.butLast.Click += new System.EventHandler(this.butLast_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(149, 398);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(97, 23);
            this.butAdd.TabIndex = 17;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(252, 398);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(97, 23);
            this.butDelete.TabIndex = 18;
            this.butDelete.Text = "Удалить";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(149, 427);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(200, 34);
            this.butSave.TabIndex = 19;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // boxFail
            // 
            this.boxFail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicationsBindingSource, "ID_Fail", true));
            this.boxFail.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.applicationsBindingSource, "ID_Fail", true));
            this.boxFail.DataSource = this.failsBindingSource;
            this.boxFail.DisplayMember = "FailName";
            this.boxFail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxFail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxFail.Location = new System.Drawing.Point(152, 157);
            this.boxFail.Name = "boxFail";
            this.boxFail.Size = new System.Drawing.Size(264, 21);
            this.boxFail.TabIndex = 20;
            this.boxFail.ValueMember = "ID_FAIL";
            // 
            // failsBindingSource
            // 
            this.failsBindingSource.DataMember = "Fails";
            this.failsBindingSource.DataSource = this.databaseDataSet;
            // 
            // failsTableAdapter
            // 
            this.failsTableAdapter.ClearBeforeFill = true;
            // 
            // FormApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(521, 500);
            this.Controls.Add(this.boxFail);
            this.Controls.Add(iD_FailLabel);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butLast);
            this.Controls.Add(this.butNext);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butFirst);
            this.Controls.Add(this.boxUser);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.boxType);
            this.Controls.Add(this.label1);
            this.Controls.Add(iD_UserLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(serialNumberLabel);
            this.Controls.Add(this.serialNumberTextBox);
            this.Controls.Add(iD_TypeLabel);
            this.Controls.Add(this.applicationsBindingNavigator);
            this.Name = "FormApplications";
            this.Text = "FormApplications";
            this.Load += new System.EventHandler(this.FormApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingNavigator)).EndInit();
            this.applicationsBindingNavigator.ResumeLayout(false);
            this.applicationsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.failsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource applicationsBindingSource;
        private DatabaseDataSetTableAdapters.ApplicationsTableAdapter applicationsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator applicationsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton applicationsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox serialNumberTextBox;
        private System.Windows.Forms.Label label1;
        private DatabaseDataSetTableAdapters.TypesTableAdapter typesTableAdapter;
        private System.Windows.Forms.ComboBox boxType;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox boxUser;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button butFirst;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.Button butLast;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.ComboBox boxFail;
        private System.Windows.Forms.BindingSource failsBindingSource;
        private DatabaseDataSetTableAdapters.FailsTableAdapter failsTableAdapter;
    }
}