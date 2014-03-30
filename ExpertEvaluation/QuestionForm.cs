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
    public partial class QuestionForm : Form
    {
        private Dictionary<QuestionType, System.Windows.Forms.Panel> questionPanelDictionary;
        private Form parentForm;

        public QuestionForm(Form parentForm)
        {
            InitializeComponent();
            InitializeQuestionPanelDictionary();
            this.question = new Question();
            this.parentForm = parentForm;
        }

        public QuestionForm(Form parentForm,Question question)
        {
            InitializeComponent();
            InitializeQuestionPanelDictionary();
            this.question = question;
            this.parentForm = parentForm;
        }

        private Question question;
        private QuestionType selectedQuestionType;

        private void InitializeQuestionPanelDictionary()
        {
            questionPanelDictionary = new Dictionary<QuestionType, Panel>()
            {
                {QuestionType.BooleanQuestion, booleanQuestionPanel},
                {QuestionType.OneOfMany,oneOfManyQuestionPanel}
            };
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            foreach (var questionType in Question.GetQuestionTypes().Reverse())
            {
                var questionTypeName = Question.QuestionDictionary[questionType];
                questionTypeCB.Items.Add(questionTypeName);
            }
        }

        private void questionTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedText = questionTypeCB.SelectedItem.ToString().TrimEnd();
            selectedQuestionType = 
                Question.QuestionDictionary.First(x => x.Value.Equals(selectedText)).Key;
            foreach (var panel in questionPanelDictionary.Values)
            {
                panel.Visible = false;
            }
            var selectedPanel = questionPanelDictionary[selectedQuestionType];
            selectedPanel.Visible = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            parentForm.Show();
        }

    }
}
