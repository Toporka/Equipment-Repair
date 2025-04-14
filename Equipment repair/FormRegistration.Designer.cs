namespace Equipment_repair
{
    partial class FormRegistration
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
            System.Windows.Forms.Label iD_ApplicationLabel;
            System.Windows.Forms.Label iD_PriorityLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label uniqueNumberLabel;
            System.Windows.Forms.Label iD_WorkerLabel;
            System.Windows.Forms.Label dateStartLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.label1 = new System.Windows.Forms.Label();
            this.databaseDataSet = new Equipment_repair.DatabaseDataSet();
            this.registrationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationsTableAdapter = new Equipment_repair.DatabaseDataSetTableAdapters.RegistrationsTableAdapter();
            this.tableAdapterManager = new Equipment_repair.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.registrationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.textUniqueNumber = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.DateTimePicker();
            this.boxNumber = new System.Windows.Forms.ComboBox();
            this.applicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boxPriority = new System.Windows.Forms.ComboBox();
            this.prioritiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationsTableAdapter = new Equipment_repair.DatabaseDataSetTableAdapters.ApplicationsTableAdapter();
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesTableAdapter = new Equipment_repair.DatabaseDataSetTableAdapters.TypesTableAdapter();
            this.prioritiesTableAdapter = new Equipment_repair.DatabaseDataSetTableAdapters.PrioritiesTableAdapter();
            this.boxDescription = new System.Windows.Forms.RichTextBox();
            this.boxWorker = new System.Windows.Forms.ComboBox();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new Equipment_repair.DatabaseDataSetTableAdapters.WorkersTableAdapter();
            this.butSave = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butLast = new System.Windows.Forms.Button();
            this.butNext = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.butFirst = new System.Windows.Forms.Button();
            iD_ApplicationLabel = new System.Windows.Forms.Label();
            iD_PriorityLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            uniqueNumberLabel = new System.Windows.Forms.Label();
            iD_WorkerLabel = new System.Windows.Forms.Label();
            dateStartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingNavigator)).BeginInit();
            this.registrationsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioritiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ApplicationLabel
            // 
            iD_ApplicationLabel.AutoSize = true;
            iD_ApplicationLabel.Location = new System.Drawing.Point(49, 101);
            iD_ApplicationLabel.Name = "iD_ApplicationLabel";
            iD_ApplicationLabel.Size = new System.Drawing.Size(141, 13);
            iD_ApplicationLabel.TabIndex = 2;
            iD_ApplicationLabel.Text = "Заявка (серийный номер):";
            // 
            // iD_PriorityLabel
            // 
            iD_PriorityLabel.AutoSize = true;
            iD_PriorityLabel.Location = new System.Drawing.Point(126, 127);
            iD_PriorityLabel.Name = "iD_PriorityLabel";
            iD_PriorityLabel.Size = new System.Drawing.Size(64, 13);
            iD_PriorityLabel.TabIndex = 4;
            iD_PriorityLabel.Text = "Приоритет:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(130, 153);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(60, 13);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Описание:";
            // 
            // uniqueNumberLabel
            // 
            uniqueNumberLabel.AutoSize = true;
            uniqueNumberLabel.Location = new System.Drawing.Point(81, 268);
            uniqueNumberLabel.Name = "uniqueNumberLabel";
            uniqueNumberLabel.Size = new System.Drawing.Size(109, 13);
            uniqueNumberLabel.TabIndex = 8;
            uniqueNumberLabel.Text = "Уникальный номер:";
            // 
            // iD_WorkerLabel
            // 
            iD_WorkerLabel.AutoSize = true;
            iD_WorkerLabel.Location = new System.Drawing.Point(50, 294);
            iD_WorkerLabel.Name = "iD_WorkerLabel";
            iD_WorkerLabel.Size = new System.Drawing.Size(140, 13);
            iD_WorkerLabel.TabIndex = 10;
            iD_WorkerLabel.Text = "Привлечённый сотрудник:";
            // 
            // dateStartLabel
            // 
            dateStartLabel.AutoSize = true;
            dateStartLabel.Location = new System.Drawing.Point(87, 323);
            dateStartLabel.Name = "dateStartLabel";
            dateStartLabel.Size = new System.Drawing.Size(103, 13);
            dateStartLabel.TabIndex = 12;
            dateStartLabel.Text = "Дата регистрации:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(118, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация заявки";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationsBindingSource
            // 
            this.registrationsBindingSource.DataMember = "Registrations";
            this.registrationsBindingSource.DataSource = this.databaseDataSet;
            // 
            // registrationsTableAdapter
            // 
            this.registrationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApplicationsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FailsTableAdapter = null;
            this.tableAdapterManager.PostsTableAdapter = null;
            this.tableAdapterManager.PrioritiesTableAdapter = null;
            this.tableAdapterManager.RegistrationsTableAdapter = this.registrationsTableAdapter;
            this.tableAdapterManager.ReportsTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.TypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Equipment_repair.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // registrationsBindingNavigator
            // 
            this.registrationsBindingNavigator.AddNewItem = null;
            this.registrationsBindingNavigator.BindingSource = this.registrationsBindingSource;
            this.registrationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.registrationsBindingNavigator.DeleteItem = null;
            this.registrationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.registrationsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.registrationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.registrationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.registrationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.registrationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.registrationsBindingNavigator.Name = "registrationsBindingNavigator";
            this.registrationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.registrationsBindingNavigator.Size = new System.Drawing.Size(470, 25);
            this.registrationsBindingNavigator.TabIndex = 1;
            this.registrationsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // textUniqueNumber
            // 
            this.textUniqueNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUniqueNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationsBindingSource, "UniqueNumber", true));
            this.textUniqueNumber.Location = new System.Drawing.Point(196, 268);
            this.textUniqueNumber.Name = "textUniqueNumber";
            this.textUniqueNumber.Size = new System.Drawing.Size(100, 13);
            this.textUniqueNumber.TabIndex = 9;
            // 
            // textDate
            // 
            this.textDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registrationsBindingSource, "DateStart", true));
            this.textDate.Location = new System.Drawing.Point(196, 317);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(200, 20);
            this.textDate.TabIndex = 13;
            // 
            // boxNumber
            // 
            this.boxNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationsBindingSource, "ID_Application", true));
            this.boxNumber.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.registrationsBindingSource, "ID_Application", true));
            this.boxNumber.DataSource = this.applicationsBindingSource;
            this.boxNumber.DisplayMember = "SerialNumber";
            this.boxNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxNumber.FormattingEnabled = true;
            this.boxNumber.Location = new System.Drawing.Point(196, 98);
            this.boxNumber.Name = "boxNumber";
            this.boxNumber.Size = new System.Drawing.Size(121, 21);
            this.boxNumber.TabIndex = 14;
            this.boxNumber.ValueMember = "ID_APPLICATION";
            // 
            // applicationsBindingSource
            // 
            this.applicationsBindingSource.DataMember = "Applications";
            this.applicationsBindingSource.DataSource = this.databaseDataSet;
            // 
            // boxPriority
            // 
            this.boxPriority.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationsBindingSource, "ID_Priority", true));
            this.boxPriority.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.registrationsBindingSource, "ID_Priority", true));
            this.boxPriority.DataSource = this.prioritiesBindingSource;
            this.boxPriority.DisplayMember = "PriorityName";
            this.boxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxPriority.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxPriority.FormattingEnabled = true;
            this.boxPriority.Location = new System.Drawing.Point(196, 124);
            this.boxPriority.Name = "boxPriority";
            this.boxPriority.Size = new System.Drawing.Size(121, 21);
            this.boxPriority.TabIndex = 15;
            this.boxPriority.ValueMember = "ID_PRIORITY";
            // 
            // prioritiesBindingSource
            // 
            this.prioritiesBindingSource.DataMember = "Priorities";
            this.prioritiesBindingSource.DataSource = this.databaseDataSet;
            // 
            // applicationsTableAdapter
            // 
            this.applicationsTableAdapter.ClearBeforeFill = true;
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataMember = "Types";
            this.typesBindingSource.DataSource = this.databaseDataSet;
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // prioritiesTableAdapter
            // 
            this.prioritiesTableAdapter.ClearBeforeFill = true;
            // 
            // boxDescription
            // 
            this.boxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationsBindingSource, "Description", true));
            this.boxDescription.Location = new System.Drawing.Point(196, 153);
            this.boxDescription.Name = "boxDescription";
            this.boxDescription.Size = new System.Drawing.Size(235, 106);
            this.boxDescription.TabIndex = 16;
            this.boxDescription.Text = "";
            // 
            // boxWorker
            // 
            this.boxWorker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationsBindingSource, "ID_Worker", true));
            this.boxWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.registrationsBindingSource, "ID_Worker", true));
            this.boxWorker.DataSource = this.workersBindingSource;
            this.boxWorker.DisplayMember = "Firstname";
            this.boxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxWorker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxWorker.FormattingEnabled = true;
            this.boxWorker.Location = new System.Drawing.Point(196, 290);
            this.boxWorker.Name = "boxWorker";
            this.boxWorker.Size = new System.Drawing.Size(121, 21);
            this.boxWorker.TabIndex = 17;
            this.boxWorker.ValueMember = "ID_WORKER";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.databaseDataSet;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(136, 428);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(200, 34);
            this.butSave.TabIndex = 26;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(239, 399);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(97, 23);
            this.butDelete.TabIndex = 25;
            this.butDelete.Text = "Удалить";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(136, 399);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(97, 23);
            this.butAdd.TabIndex = 24;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butLast
            // 
            this.butLast.Location = new System.Drawing.Point(342, 371);
            this.butLast.Name = "butLast";
            this.butLast.Size = new System.Drawing.Size(97, 23);
            this.butLast.TabIndex = 23;
            this.butLast.Text = "Последняя";
            this.butLast.UseVisualStyleBackColor = true;
            this.butLast.Click += new System.EventHandler(this.butLast_Click);
            // 
            // butNext
            // 
            this.butNext.Location = new System.Drawing.Point(239, 371);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(97, 23);
            this.butNext.TabIndex = 22;
            this.butNext.Text = "Следующая";
            this.butNext.UseVisualStyleBackColor = true;
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(136, 371);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(97, 23);
            this.butBack.TabIndex = 21;
            this.butBack.Text = "Предыдущая";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butFirst
            // 
            this.butFirst.Location = new System.Drawing.Point(33, 371);
            this.butFirst.Name = "butFirst";
            this.butFirst.Size = new System.Drawing.Size(97, 23);
            this.butFirst.TabIndex = 20;
            this.butFirst.Text = "Первая";
            this.butFirst.UseVisualStyleBackColor = true;
            this.butFirst.Click += new System.EventHandler(this.butFirst_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(470, 479);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butLast);
            this.Controls.Add(this.butNext);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butFirst);
            this.Controls.Add(this.boxWorker);
            this.Controls.Add(this.boxDescription);
            this.Controls.Add(this.boxPriority);
            this.Controls.Add(this.boxNumber);
            this.Controls.Add(dateStartLabel);
            this.Controls.Add(this.textDate);
            this.Controls.Add(iD_WorkerLabel);
            this.Controls.Add(uniqueNumberLabel);
            this.Controls.Add(this.textUniqueNumber);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(iD_PriorityLabel);
            this.Controls.Add(iD_ApplicationLabel);
            this.Controls.Add(this.registrationsBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistration";
            this.Text = "FormRegistration";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingNavigator)).EndInit();
            this.registrationsBindingNavigator.ResumeLayout(false);
            this.registrationsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioritiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource registrationsBindingSource;
        private DatabaseDataSetTableAdapters.RegistrationsTableAdapter registrationsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator registrationsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox textUniqueNumber;
        private System.Windows.Forms.DateTimePicker textDate;
        private System.Windows.Forms.ComboBox boxNumber;
        private System.Windows.Forms.ComboBox boxPriority;
        private System.Windows.Forms.BindingSource applicationsBindingSource;
        private DatabaseDataSetTableAdapters.ApplicationsTableAdapter applicationsTableAdapter;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private DatabaseDataSetTableAdapters.TypesTableAdapter typesTableAdapter;
        private System.Windows.Forms.BindingSource prioritiesBindingSource;
        private DatabaseDataSetTableAdapters.PrioritiesTableAdapter prioritiesTableAdapter;
        private System.Windows.Forms.RichTextBox boxDescription;
        private System.Windows.Forms.ComboBox boxWorker;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private DatabaseDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butLast;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butFirst;
    }
}