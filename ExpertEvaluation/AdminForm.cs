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
            foreach (var question in Dao.GetQuestions())
            {
                QuestionGrid.Rows.Add(question.QuestionNumber, question.QuestionText, 
                    question.QuestionType, question.GetPossibleAnswers(),
                    question.RightAnswer);
            }
            
            

        }



        private void ShowQuestionForm()
        {
            this.Hide();
            var questionForm = new QuestionForm(this);
            questionForm.Show(); 
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            ShowQuestionForm();
        }

        private void EditQuestionButton_Click(object sender, EventArgs e)
        {
            int id = (int) QuestionGrid.CurrentRow.Cells[0].Value;
            Question question = Dao.GetQuestionByID(id);
            ShowQuestionForm();


        }


    }
}
