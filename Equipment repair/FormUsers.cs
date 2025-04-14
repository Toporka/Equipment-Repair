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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.databaseDataSet.Users);

        }

        private void butFirst_Click(object sender, EventArgs e)
        {
            usersBindingSource.MoveFirst();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            usersBindingSource.MovePrevious();
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            usersBindingSource.MoveNext();
        }

        private void butLast_Click(object sender, EventArgs e)
        {
            usersBindingSource.MoveLast();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            usersBindingSource.AddNew();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            usersBindingSource.RemoveCurrent();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }
    }
}
