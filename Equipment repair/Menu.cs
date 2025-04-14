using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Equipment_repair
{
    public partial class Menu : Form
    {
        private FormApplications applications;
        private FormUsers users;
        private FormRegistration registration;
        private FormWorkers workers;
        private FormReports reporters;
        private Analysis analysis;
        private FormlStatisticFails statistics;
        private FormlStatisticApplications statisticsApplications;
        private Cheque cheque;
        private User user = User.Instance;

        public Menu()
        {
            InitializeComponent();

            AccessControl();
        }

        private void AccessControl()
        {
            switch(user.post)
            {
                case User.Post.Engineer:
                    butUser.Visible = false;
                    butApplications.Visible = false;
                    butWorkers.Visible = false;
                    butReports.Visible = false;
                    groupStatistics.Visible = false;
                    groupPrint.Visible = false;
                    break;
                case User.Post.Manager:
                    break;
                default:
                    break;
            }
        }

        private void butApplications_Click(object sender, EventArgs e)
        {
            applications = new FormApplications();
            applications.Visible = true;
        }

        private void butUser_Click(object sender, EventArgs e)
        {
            users = new FormUsers();
            users.Visible = true;
        }

        private void butWorkers_Click(object sender, EventArgs e)
        {
            workers = new FormWorkers();
            workers.Visible = true;
        }

        private void butReports_Click(object sender, EventArgs e)
        {
            reporters = new FormReports();
            reporters.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            analysis = new Analysis();
            analysis.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            statistics = new FormlStatisticFails();
            statistics.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            statisticsApplications = new FormlStatisticApplications();
            statisticsApplications.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cheque = new Cheque();
            cheque.Visible = true;
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            registration = new FormRegistration();
            registration.Visible = true;
        }
    }
}
