using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertEvaluation.classes;

namespace ExpertEvaluation.forms
{
    public partial class UserForm : Form
    {
        private Form _parentForm ;
        private User _user;

        public UserForm(AdminForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _user = new User();
        }

        public UserForm(AdminForm parentForm, User user)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _user = user;
        }

//        private void InitializeFormElements()
//        {
//            
//        }

        private void BindEntityToAttributes()
        {
            loginTB.Text = _user.Login;
            passwordTB.Text = _user.Password;
//            userTypeCB.SelectedIndex = userTypeCB.
        }
    }
}
