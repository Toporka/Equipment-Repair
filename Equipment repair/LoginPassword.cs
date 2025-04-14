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

namespace Equipment_repair
{
    public partial class LoginPassword : Form
    {
        private Menu menu;

        public LoginPassword()
        {
            InitializeComponent();
        }

        private bool checkDate()
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;";

            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                OleDbCommand command = new OleDbCommand("SELECT Login, Password, PostName FROM Workers, Posts WHERE Posts.ID_POST=Workers.ID_post", connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0].ToString() == textLogin.Text && reader[1].ToString() == textPassword.Text)
                    {
                        User user = User.Instance;
                        user.setPost(reader[2].ToString());

                        return true;
                    }
                }
            }

            return false;
        }

        private void butEnter_Click(object sender, EventArgs e)
        {
            if (checkDate() == true)
            {
                using (Menu menu = new Menu())
                {
                    this.Visible = false;
                    menu.ShowDialog(this);
                }
                this.Visible = true;
            }
        }
    }
}
