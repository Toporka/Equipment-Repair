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
    public partial class FormlStatisticApplications : Form
    {
        public FormlStatisticApplications()
        {
            InitializeComponent();
        }

        private void FormlStatisticApplications_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.CountEnter". При необходимости она может быть перемещена или удалена.
            this.countEnterTableAdapter.Fill(this.databaseDataSet.CountEnter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.DateCountEnter". При необходимости она может быть перемещена или удалена.
            this.dateCountEnterTableAdapter.Fill(this.databaseDataSet.DateCountEnter);

        }
    }
}
