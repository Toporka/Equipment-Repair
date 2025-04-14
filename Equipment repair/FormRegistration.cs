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
    public partial class FormRegistration : Form
    {
        private User user = User.Instance;

        public FormRegistration()
        {
            InitializeComponent();

            AccessControl();
        }

        private void AccessControl()
        {
            switch (user.post)
            {
                case User.Post.Engineer:
                    butAdd.Visible = false;
                    butDelete.Visible = false;
                    butSave.Visible = false;
                    break;
                case User.Post.Manager:
                    break;
                default:
                    break;
            }
        }

        private void registrationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registrationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.databaseDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Priorities". При необходимости она может быть перемещена или удалена.
            this.prioritiesTableAdapter.Fill(this.databaseDataSet.Priorities);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Types". При необходимости она может быть перемещена или удалена.
            this.typesTableAdapter.Fill(this.databaseDataSet.Types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter.Fill(this.databaseDataSet.Applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Registrations". При необходимости она может быть перемещена или удалена.
            this.registrationsTableAdapter.Fill(this.databaseDataSet.Registrations);

        }

        private void butFirst_Click(object sender, EventArgs e)
        {
            registrationsBindingSource.MoveFirst();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            registrationsBindingSource.MovePrevious();
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            registrationsBindingSource.MoveNext();
        }

        private void butLast_Click(object sender, EventArgs e)
        {
            registrationsBindingSource.MoveLast();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            registrationsBindingSource.AddNew();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            registrationsBindingSource.RemoveCurrent();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registrationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }
    }
}
