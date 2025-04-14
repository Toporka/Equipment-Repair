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
    public partial class FormApplications : Form
    {
        public FormApplications()
        {
            InitializeComponent();
        }

        private void applicationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.applicationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void FormApplications_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Fails". При необходимости она может быть перемещена или удалена.
            this.failsTableAdapter.Fill(this.databaseDataSet.Fails);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.databaseDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Types". При необходимости она может быть перемещена или удалена.
            this.typesTableAdapter.Fill(this.databaseDataSet.Types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter.Fill(this.databaseDataSet.Applications);
        }

        private void butFirst_Click(object sender, EventArgs e)
        {
            applicationsBindingSource.MoveFirst();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            applicationsBindingSource.MovePrevious();
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            applicationsBindingSource.MoveNext();
        }

        private void butLast_Click(object sender, EventArgs e)
        {
            applicationsBindingSource.MoveLast();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            applicationsBindingSource.AddNew();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            applicationsBindingSource.RemoveCurrent();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.applicationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }
    }
}
