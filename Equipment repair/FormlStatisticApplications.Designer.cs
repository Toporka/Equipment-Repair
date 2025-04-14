namespace Equipment_repair
{
    partial class FormlStatisticApplications
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
            System.Windows.Forms.Label countEnterLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormlStatisticApplications));
            this.databaseDataSet = new Equipment_repair.DatabaseDataSet();
            this.dateCountEnterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateCountEnterTableAdapter = new Equipment_repair.DatabaseDataSetTableAdapters.DateCountEnterTableAdapter();
            this.tableAdapterManager = new Equipment_repair.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.dateCountEnterBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dateCountEnterBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dateCountEnterDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countEnterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countEnterTableAdapter = new Equipment_repair.DatabaseDataSetTableAdapters.CountEnterTableAdapter();
            this.countEnterTextBox = new System.Windows.Forms.TextBox();
            countEnterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCountEnterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCountEnterBindingNavigator)).BeginInit();
            this.dateCountEnterBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateCountEnterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countEnterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // countEnterLabel
            // 
            countEnterLabel.AutoSize = true;
            countEnterLabel.Location = new System.Drawing.Point(12, 267);
            countEnterLabel.Name = "countEnterLabel";
            countEnterLabel.Size = new System.Drawing.Size(192, 13);
            countEnterLabel.TabIndex = 2;
            countEnterLabel.Text = "Общее кол-во выполненных заявок:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateCountEnterBindingSource
            // 
            this.dateCountEnterBindingSource.DataMember = "DateCountEnter";
            this.dateCountEnterBindingSource.DataSource = this.databaseDataSet;
            // 
            // dateCountEnterTableAdapter
            // 
            this.dateCountEnterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApplicationsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FailsTableAdapter = null;
            this.tableAdapterManager.PostsTableAdapter = null;
            this.tableAdapterManager.PrioritiesTableAdapter = null;
            this.tableAdapterManager.RegistrationsTableAdapter = null;
            this.tableAdapterManager.ReportsTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.TypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Equipment_repair.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // dateCountEnterBindingNavigator
            // 
            this.dateCountEnterBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dateCountEnterBindingNavigator.BindingSource = this.dateCountEnterBindingSource;
            this.dateCountEnterBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dateCountEnterBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dateCountEnterBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dateCountEnterBindingNavigatorSaveItem});
            this.dateCountEnterBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dateCountEnterBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dateCountEnterBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dateCountEnterBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dateCountEnterBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dateCountEnterBindingNavigator.Name = "dateCountEnterBindingNavigator";
            this.dateCountEnterBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dateCountEnterBindingNavigator.Size = new System.Drawing.Size(428, 25);
            this.dateCountEnterBindingNavigator.TabIndex = 0;
            this.dateCountEnterBindingNavigator.Text = "bindingNavigator1";
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
            // dateCountEnterBindingNavigatorSaveItem
            // 
            this.dateCountEnterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dateCountEnterBindingNavigatorSaveItem.Enabled = false;
            this.dateCountEnterBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dateCountEnterBindingNavigatorSaveItem.Image")));
            this.dateCountEnterBindingNavigatorSaveItem.Name = "dateCountEnterBindingNavigatorSaveItem";
            this.dateCountEnterBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dateCountEnterBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // dateCountEnterDataGridView
            // 
            this.dateCountEnterDataGridView.AutoGenerateColumns = false;
            this.dateCountEnterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dateCountEnterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dateCountEnterDataGridView.DataSource = this.dateCountEnterBindingSource;
            this.dateCountEnterDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateCountEnterDataGridView.Location = new System.Drawing.Point(0, 25);
            this.dateCountEnterDataGridView.Name = "dateCountEnterDataGridView";
            this.dateCountEnterDataGridView.Size = new System.Drawing.Size(428, 220);
            this.dateCountEnterDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "YearMonth";
            this.dataGridViewTextBoxColumn1.HeaderText = "год.месяц";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn2.HeaderText = "Кол-во выполненных заявок";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // countEnterBindingSource
            // 
            this.countEnterBindingSource.DataMember = "CountEnter";
            this.countEnterBindingSource.DataSource = this.databaseDataSet;
            // 
            // countEnterTableAdapter
            // 
            this.countEnterTableAdapter.ClearBeforeFill = true;
            // 
            // countEnterTextBox
            // 
            this.countEnterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countEnterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countEnterBindingSource, "CountEnter", true));
            this.countEnterTextBox.Location = new System.Drawing.Point(210, 267);
            this.countEnterTextBox.Name = "countEnterTextBox";
            this.countEnterTextBox.ReadOnly = true;
            this.countEnterTextBox.Size = new System.Drawing.Size(206, 13);
            this.countEnterTextBox.TabIndex = 3;
            // 
            // FormlStatisticApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(428, 308);
            this.Controls.Add(countEnterLabel);
            this.Controls.Add(this.countEnterTextBox);
            this.Controls.Add(this.dateCountEnterDataGridView);
            this.Controls.Add(this.dateCountEnterBindingNavigator);
            this.Name = "FormlStatisticApplications";
            this.Text = "FormlStatisticApplications";
            this.Load += new System.EventHandler(this.FormlStatisticApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCountEnterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCountEnterBindingNavigator)).EndInit();
            this.dateCountEnterBindingNavigator.ResumeLayout(false);
            this.dateCountEnterBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateCountEnterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countEnterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource dateCountEnterBindingSource;
        private DatabaseDataSetTableAdapters.DateCountEnterTableAdapter dateCountEnterTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dateCountEnterBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dateCountEnterBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dateCountEnterDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource countEnterBindingSource;
        private DatabaseDataSetTableAdapters.CountEnterTableAdapter countEnterTableAdapter;
        private System.Windows.Forms.TextBox countEnterTextBox;
    }
}