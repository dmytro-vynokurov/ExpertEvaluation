using System;
using System.Windows.Forms;
using ExpertEvaluation.classes;
using MongoDB.Bson;

namespace ExpertEvaluation.forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            base.Show();
            RefillFormWithData();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            RefillFormWithData();
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var questionForm = new QuestionForm(this);
            questionForm.Show(); 
        }

        private void EditQuestionButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = GetSelectedQuestionNumber();
                Question question = Dao.GetQuestionByNumber(id);
                this.Hide();
                var questionForm = new QuestionForm(this, question);
                questionForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Cannot extract selected question", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteQuestionButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = GetSelectedQuestionNumber();
                Dao.DeleteQuestion(id);
                RefillFormWithData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Cannot extract selected question", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefillFormWithData()
        {
            RefillQuestionGrid();
            RefillUsersGrid();
        }

        private void RefillQuestionGrid()
        {
            var questions = Dao.GetQuestions();
            questionsDGV.Rows.Clear();
            foreach (var question in questions)
            {
                questionsDGV.Rows.Add(question.QuestionNumber, question.QuestionText,
                    question.QuestionType, question.GetPossibleAnswers(),
                    question.GetRightAnswers());
            }
        }

        private int GetSelectedQuestionNumber()
        {
            return (int) questionsDGV.CurrentRow.Cells[0].Value;
        }

        private void deleteExpertButton_Click(object sender, EventArgs e)
        {
            var id = (ObjectId)usersDGV.CurrentRow.Cells[0].Value;
            Dao.DeleteUser(id);
            RefillUsersGrid();
        }

        private void editExpertButton_Click(object sender, EventArgs e)
        {
            var id = (ObjectId)usersDGV.CurrentRow.Cells[0].Value;
            var user = Dao.GetUserById(id);
            var userForm = new UserForm(this, user);
            userForm.Show();
        }

        private void addExpertButton_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm(this);
            userForm.Show();
        }

        private void RefillUsersGrid()
        {
            var users = Dao.GetUsers();
            usersDGV.Rows.Clear();
            foreach (var user in users)
            {
                usersDGV.Rows.Add(user.Id,user.Login, user.Type);
                //TODO: add user details here
            }
        }
    }
}
