using System;
using System.Linq;
using System.Windows.Forms;
using ExpertEvaluation.classes;

namespace ExpertEvaluation.forms
{
    public partial class UserForm : Form
    {
        private AdminForm _parentForm ;
        private User _user;

        public UserForm(AdminForm parentForm)
        {
            InitializeComponent();
            InitializeUserTypeCB();
            _parentForm = parentForm;
            _user = new User();
        }

        public UserForm(AdminForm parentForm, User user)
        {
            InitializeComponent();
            InitializeUserTypeCB();
            _parentForm = parentForm;
            _user = user;

            BindEntityToAttributes();
        }

        private void InitializeUserTypeCB()
        {
            userTypeCB.Items.Clear();
            foreach (var userType in Enum.GetNames(typeof (UserType)))
            {
                userTypeCB.Items.Add(userType);
            }
        }

        private bool ValidateAttributes()
        {
            if (!IsLoginValid())
            {
                MessageBox.Show(@"Login must not be empty and must not contain spaces", @"Wrong login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsPasswordValid())
            {
                MessageBox.Show(@"Password must not be empty and must not contain spaces", @"Wrong password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsPasswordValid())
            {
                MessageBox.Show(@"Password must not be empty and must not contain spaces", @"Wrong password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsUserTypeValid())
            {
                MessageBox.Show(@"Please choose correct user type", @"Wrong user type",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsLoginValid()
        {
            var login = loginTB.Text;
            if (login.Length < 1) return false;
            if(login.Contains(" ")) return false;
            return true;
        }

        private bool IsPasswordValid()
        {
            var password = passwordTB.Text;
            if (password.Length < 1) return false;
            if (password.Contains(" ")) return false;
            return true;
        }

        private bool IsUserTypeValid()
        {
            var userType = userTypeCB.SelectedText;
            return Enum.GetNames(typeof (UserType)).Contains(userType);
        }

        private void BindEntityToAttributes()
        {
            loginTB.Text = _user.Login;
            passwordTB.Text = _user.Password;
            userTypeCB.SelectedIndex = userTypeCB.Items.IndexOf(_user.Type.ToString());
        }

        private void BindAttributesToEntity()
        {
            _user.Login = loginTB.Text;
            _user.Password = passwordTB.Text;
            var userTypeName = userTypeCB.Items[userTypeCB.SelectedIndex].ToString();
            _user.Type = (UserType) Enum.Parse(typeof (UserType), userTypeName);
        }

        private void ReturnToParent()
        {
            this.Hide();
            _parentForm.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ReturnToParent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateAttributes())
            {
                BindAttributesToEntity();
                Dao.SaveUser(_user);
                ReturnToParent();
            }
        }
    }
}
