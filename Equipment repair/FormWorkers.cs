using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipment_repair
{
    public partial class FormWorkers : Form
    {
        public FormWorkers()
        {
            InitializeComponent();
        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void FormWorkers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Posts". При необходимости она может быть перемещена или удалена.
            this.postsTableAdapter.Fill(this.databaseDataSet.Posts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.databaseDataSet.Workers);

        }

        private void butFirst_Click(object sender, EventArgs e)
        {
            workersBindingSource.MoveFirst();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            workersBindingSource.MovePrevious();
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            workersBindingSource.MoveNext();
        }

        private void butLast_Click(object sender, EventArgs e)
        {
            workersBindingSource.MoveLast();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            workersBindingSource.AddNew();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            workersBindingSource.RemoveCurrent();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }
    }
}
