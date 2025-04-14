using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Equipment_repair
{
    public partial class Cheque : Form
    {
        public Cheque()
        {
            InitializeComponent();
        }

        private void Cheque_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Reports". При необходимости она может быть перемещена или удалена.
            this.reportsTableAdapter.Fill(this.databaseDataSet.Reports);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Registrations". При необходимости она может быть перемещена или удалена.
            this.registrationsTableAdapter.Fill(this.databaseDataSet.Registrations);

            SearchDatas();
        }

        private void SearchDatas()
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;";

            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                OleDbCommand command = new OleDbCommand("SELECT Registrations.UniqueNumber, Reports.Description, Registrations.DateStart, Reports.DateEnd, Reports.Price, States.StateName, Workers.FirstName & \" \" & Workers.SecondName AS Worker, DateDiff(\"d\",Registrations.DateStart,Reports.DateEnd) AS MiddleDay\r\nFROM Reports, Registrations, States, Workers\r\nWHERE Reports.ID_Registration=Registrations.ID_REGISTRATION And Reports.ID_State=States.ID_STATE And Workers.ID_WORKER = Registrations.ID_Worker;\r\n", connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if(reader[0].ToString() == boxNumber.Text)
                    {
                        textPrice.Text = reader[4].ToString();
                        textWorker.Text = reader[6].ToString();
                    }
                }
            }
        }

        private void boxNumber_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SearchDatas();
        }
    }
}
