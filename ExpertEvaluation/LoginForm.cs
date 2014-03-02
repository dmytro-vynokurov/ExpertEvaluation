using System;
using System.Windows.Forms;
using ExpertEvaluation.classes;

namespace ExpertEvaluation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            var userDao = new UserDao();
            var userFound = userDao.GetUserByLogin(login);
            Console.WriteLine(@"userFound: "+userFound);

            if (userFound == null)
            {
                MessageBox.Show(@"Cannot find user: " + login, @"Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (userFound.Password != password)
                {
                    MessageBox.Show(@"Incorrect password", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (userFound.Type == UserType.Admin)
                    {
                        this.Hide();
                        var adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    else
                    {
                        //TODO: Add Expert form    
                        throw new NotImplementedException();
                    }
                }
            }


        }
    }
}
