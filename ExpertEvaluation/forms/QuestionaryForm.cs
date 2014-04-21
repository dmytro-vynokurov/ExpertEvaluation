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
    public partial class QuestionaryForm : Form
    {
        private Question _selectedQuestion;

        public QuestionaryForm()
        {
            InitializeComponent();
            InitializeQuestionsLV();
        }

        private void questionsLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = questionsLV.SelectedIndices[0];
            var selectedId = int.Parse(questionsLV.Items[selectedIndex].Text);
            _selectedQuestion = Dao.GetQuestionByNumber(selectedId);
            RedrawQuestion();
        }

        private void RedrawQuestion()
        {
            questionNumberLabel.Text = @"Question #" + _selectedQuestion.QuestionNumber;
            questionTextRTB.Text = _selectedQuestion.QuestionText;
            // TODO: add output for question-type-specific data here
        }
        
        private void QuestionaryForm_Load(object sender, EventArgs e)
        {
            InitializeQuestionsLV();
        }

        private void InitializeQuestionsLV()
        {
            var questions = Dao.GetQuestions();
            Console.WriteLine(questions);
            foreach (var question in questions)
            {
                questionsLV.Items.Add(question.QuestionNumber.ToString());
            }
            if (questions.Count() > 0) questionsLV.Items[0].Selected = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
