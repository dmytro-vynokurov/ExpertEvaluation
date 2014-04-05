using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ExpertEvaluation.classes;

namespace ExpertEvaluation
{
    public partial class QuestionForm : Form
    {
        private static Dictionary<QuestionType, System.Windows.Forms.Panel> _questionPanelDictionary;
        private readonly AdminForm _parentForm;
        private readonly Question _question;
        private QuestionType _selectedQuestionType;

        public QuestionForm(AdminForm parentForm)
        {
            InitializeComponent();
            InitializeQuestionPanelDictionary();
            this._question = new Question {QuestionNumber = Dao.MaxQuestionNumber()};
            this._parentForm = parentForm;
        }

        public QuestionForm(AdminForm parentForm, Question question)
        {
            InitializeComponent();
            InitializeQuestionPanelDictionary();
            this._question = question;
            this._parentForm = parentForm;

            BindEntityToAttributes();
        }

        private void InitializeQuestionPanelDictionary()
        {
            _questionPanelDictionary = new Dictionary<QuestionType, Panel>()
            {
                {QuestionType.BooleanQuestion, booleanQuestionPanel},
                {QuestionType.OneOfMany,oneOfManyQuestionPanel}
                // TODO: add mappings between new question types and panels
            };
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            foreach (var questionType in Question.GetQuestionTypes())
            {
                var questionTypeName = Question.QuestionDictionary[questionType];
                questionTypeCB.Items.Add(questionTypeName);
            }
            questionTypeCB.SelectedIndex = questionTypeCB.Items.IndexOf(Question.QuestionDictionary[_selectedQuestionType]);
        }

        private void questionTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedText = questionTypeCB.SelectedItem.ToString().TrimEnd();
            _selectedQuestionType = 
                Question.QuestionDictionary.First(x => x.Value.Equals(selectedText)).Key;
            foreach (var panel in _questionPanelDictionary.Values)
            {
                panel.Visible = false;
            }
            var selectedPanel = _questionPanelDictionary[_selectedQuestionType];
            selectedPanel.Visible = true;
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
            if (ValidateFields())
            {
                BindAttributesToEntity();
                Dao.SaveQuestion(_question);
                ReturnToParent();
            }
        }

        private bool ValidateFields()
        {
            if (_selectedQuestionType==QuestionType.BooleanQuestion && !trueRB.Checked && !falseRB.Checked)
            {
                MessageBox.Show(@"No right answer chosen", @"Cannot create question",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_selectedQuestionType==QuestionType.OneOfMany && !oneOfManyRTB.Lines.Contains(oneOfManyCB.Text))
            {
                MessageBox.Show(@"Right answer chosen is not one of possible answers", @"Cannot create question",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //TODO: add validation for new questions input here
            return true;
        }

        private void BindEntityToAttributes()
        {
            QuestionTextBox.Text = _question.QuestionText;
            _selectedQuestionType = _question.QuestionType;
            switch (_selectedQuestionType)
            {
                case QuestionType.BooleanQuestion:
                    if (_question.RightAnswers.Contains("True"))
                    {
                        trueRB.Checked = true;
                        falseRB.Checked = false;
                    }
                    else
                    {
                        trueRB.Checked = false;
                        falseRB.Checked = true;
                    }
                    break;
                case QuestionType.OneOfMany:
                    oneOfManyRTB.Lines = _question.PossibleAnswers.ToArray();
                    UpdateOneOfManyCB();
                    oneOfManyCB.Text = _question.RightAnswers[0];
                    break;
                // TODO: add binding for new question types here
            }
        }

        private void BindAttributesToEntity()
        {
            _question.QuestionText = QuestionTextBox.Text;
            _question.QuestionType = _selectedQuestionType;
            switch (_selectedQuestionType)
            {
                case QuestionType.BooleanQuestion:
                    _question.PossibleAnswers = new List<string>() { "True", "False" };
                    _question.RightAnswers = new List<string>() { trueRB.Checked ? "True" : "False" };
                    break;
                case QuestionType.OneOfMany:
                    _question.PossibleAnswers = new List<string>();
                    foreach (var line in oneOfManyRTB.Lines.Where(line => line.Length > 0))
                    {
                        _question.PossibleAnswers.Add(line);
                    }
                    _question.RightAnswers = new List<string>(){oneOfManyCB.Text};
                    break;
                // TODO: add binding for new entity fields here
            }
        }

        private void oneOfManyRTB_TextChanged(object sender, EventArgs e)
        {
            UpdateOneOfManyCB();
        }

        private void UpdateOneOfManyCB()
        {
            oneOfManyCB.Items.Clear();
            foreach (var line in oneOfManyRTB.Lines.Where(line => line.Length > 0))
            {
                oneOfManyCB.Items.Add(line);
            }
        }
    }
}
