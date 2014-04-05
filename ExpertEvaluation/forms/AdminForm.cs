using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ExpertEvaluation.classes;

namespace ExpertEvaluation
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

    
        private void AdminForm_Load(object sender, EventArgs e)
        {
            RefillQuestionGrid();
            // TODO: add loading experts
        }

        private void RefillQuestionGrid()
        {
            IEnumerable<Question> questions = Dao.GetQuestions();
            QuestionGrid.Rows.Clear();
            foreach (var question in questions)
            {
                QuestionGrid.Rows.Add(question.QuestionNumber, question.QuestionText,
                    question.QuestionType, question.GetPossibleAnswers(),
                    question.GetRightAnswers());
            }
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
                Question question = Dao.GetQuestionById(id);
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

        public new void Show()
        {
            base.Show();
            RefillQuestionGrid();
        }

        private void DeleteQuestionButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = GetSelectedQuestionNumber();
                Dao.DeleteQuestion(id);
                RefillQuestionGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Cannot extract selected question", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedQuestionNumber()
        {
            return (int) QuestionGrid.CurrentRow.Cells[0].Value;
        }
    }
}
