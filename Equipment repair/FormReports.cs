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
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }

        private void reportsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reportsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.States". При необходимости она может быть перемещена или удалена.
            this.statesTableAdapter.Fill(this.databaseDataSet.States);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Registrations". При необходимости она может быть перемещена или удалена.
            this.registrationsTableAdapter.Fill(this.databaseDataSet.Registrations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Reports". При необходимости она может быть перемещена или удалена.
            this.reportsTableAdapter.Fill(this.databaseDataSet.Reports);

        }

        private void butFirst_Click(object sender, EventArgs e)
        {
            reportsBindingSource.MoveFirst();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            reportsBindingSource.MovePrevious();
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            reportsBindingSource.MoveNext();
        }

        private void butLast_Click(object sender, EventArgs e)
        {
            reportsBindingSource.MoveLast();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            reportsBindingSource.AddNew();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            reportsBindingSource.RemoveCurrent();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reportsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }
    }
}
