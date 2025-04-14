namespace Equipment_repair
{
    partial class Cheque
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxNumber = new System.Windows.Forms.ComboBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textWorker = new System.Windows.Forms.TextBox();
            this.databaseDataSet = new Equipment_repair.DatabaseDataSet();
            this.registrationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationsTableAdapter = new Equipment_repair.DatabaseDataSetTableAdapters.RegistrationsTableAdapter();
            this.reportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsTableAdapter = new Equipment_repair.DatabaseDataSetTableAdapters.ReportsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "СЕРВИС - \"ООО Техносервис\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Услугу оказал:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Идентификатор услуги:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Итоговая цена:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Equipment_repair.Properties.Resources.qr;
            this.pictureBox1.Location = new System.Drawing.Point(153, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(150, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Спасибо за ваш отзыв!";
            // 
            // boxNumber
            // 
            this.boxNumber.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reportsBindingSource, "ID_Registration", true));
            this.boxNumber.DataSource = this.registrationsBindingSource;
            this.boxNumber.DisplayMember = "UniqueNumber";
            this.boxNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxNumber.FormattingEnabled = true;
            this.boxNumber.Location = new System.Drawing.Point(189, 63);
            this.boxNumber.Name = "boxNumber";
            this.boxNumber.Size = new System.Drawing.Size(195, 21);
            this.boxNumber.TabIndex = 11;
            this.boxNumber.ValueMember = "ID_REGISTRATION";
            this.boxNumber.SelectionChangeCommitted += new System.EventHandler(this.boxNumber_SelectionChangeCommitted);
            // 
            // textPrice
            // 
            this.textPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPrice.Location = new System.Drawing.Point(132, 173);
            this.textPrice.Name = "textPrice";
            this.textPrice.ReadOnly = true;
            this.textPrice.Size = new System.Drawing.Size(92, 14);
            this.textPrice.TabIndex = 10;
            // 
            // textWorker
            // 
            this.textWorker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textWorker.Location = new System.Drawing.Point(132, 142);
            this.textWorker.Name = "textWorker";
            this.textWorker.ReadOnly = true;
            this.textWorker.Size = new System.Drawing.Size(207, 14);
            this.textWorker.TabIndex = 5;
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
            // reportsBindingSource
            // 
            this.reportsBindingSource.DataMember = "Reports";
            this.reportsBindingSource.DataSource = this.databaseDataSet;
            // 
            // reportsTableAdapter
            // 
            this.reportsTableAdapter.ClearBeforeFill = true;
            // 
            // Cheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(470, 478);
            this.Controls.Add(this.boxNumber);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textWorker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cheque";
            this.Text = "Cheque";
            this.Load += new System.EventHandler(this.Cheque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boxNumber;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textWorker;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource registrationsBindingSource;
        private DatabaseDataSetTableAdapters.RegistrationsTableAdapter registrationsTableAdapter;
        private System.Windows.Forms.BindingSource reportsBindingSource;
        private DatabaseDataSetTableAdapters.ReportsTableAdapter reportsTableAdapter;
    }
}