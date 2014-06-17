using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ExpertEvaluation.classes;

namespace ExpertEvaluation.forms
{
    public partial class AnswerForm : Form
    {
        private Question _selectedQuestion;
        private readonly QuestionType _questionType;
        private readonly IEnumerator<Question> _questionsEnumerator;  

        public AnswerForm(QuestionType questionType)
        {
            InitializeComponent();
            InitializeQuestionPanelDictionary();
            _questionType = questionType;
            _questionsEnumerator = Dao.GetQuestions().Where(x=>x.QuestionType.Equals(_questionType)).OrderBy(x=>x.Weight).GetEnumerator();
            NextQuestion();
            SelectAnswerPanel();
        }
        private static Dictionary<QuestionType, Panel> _answerPanelDictionary;
        private void InitializeQuestionPanelDictionary()
        {
            _answerPanelDictionary = new Dictionary<QuestionType, Panel>
            {
                {QuestionType.BooleanQuestion, booleanAP},
                {QuestionType.OneOfMany, someOfManyAP},
                {QuestionType.ManyOfMany,someOfManyAP},
                {QuestionType.NumberQuestion, numberAP},
                {QuestionType.Interval, intervalAP}
            };
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!FormVerified()) return;
            UpdateQuestionWeight();
            SaveAnswer();
            NextQuestion();
        }

        private void NextQuestion()
        {
            if (_questionsEnumerator.MoveNext())
            {
                _selectedQuestion = _questionsEnumerator.Current;
                RedrawQuestion();
            }
            else
            {
                this.Hide();
                var questionTypePickerForm = new QuestionTypePickerForm();
                questionTypePickerForm.Show();
            }
        }

        private Boolean FormVerified()
        {
            int a, b; // used for int.TryParse method only
            if (_questionType == QuestionType.BooleanQuestion && !trueRB.Checked && !falseRB.Checked)
            {
                MessageBox.Show(@"No right answer chosen", @"Cannot save answer",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_questionType == QuestionType.OneOfMany && someOfManyLB.CheckedItems.Count!=1)
            {
                MessageBox.Show(@"Please choose single right answer", @"Cannot save answer",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_questionType == QuestionType.NumberQuestion && !int.TryParse(numberTB.Text, out a))
            {
                MessageBox.Show(@"Incorrect answer", @"Cannot save answer",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_questionType == QuestionType.Interval && !(int.TryParse(intervalStartTB.Text, out a) && int.TryParse(intervalEndTB.Text, out b)))
            {
                MessageBox.Show(@"Incorrect interval", @"Cannot save answer",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private Answer ParseAnswer()
        {
            var answer = new Answer(_selectedQuestion.QuestionNumber,_selectedQuestion.QuestionType);
            switch (_selectedQuestion.QuestionType)
            {
                case QuestionType.BooleanQuestion:
                    answer.Answers = new List<string> { trueRB.Checked ? "True" : "False" };
                    break;
                case QuestionType.OneOfMany:
                case QuestionType.ManyOfMany:
                    answer.Answers = new List<string>();
                    foreach (ListViewItem checkedItem in someOfManyLB.CheckedItems)
                    {
                        answer.Answers.Add(checkedItem.Text);
                    }
                    break;
                case QuestionType.NumberQuestion:
                    answer.Answers = new List<string> {numberTB.Text};
                    break;
                case QuestionType.Interval:
                    answer.Answers = new List<string>
                    {
                        intervalStartTB.Text,
                        intervalEndTB.Text
                    };
                    break;
            }
            return answer;
        }

        private void UpdateQuestionWeight()
        {
            var answersForQurrentQuestion = Dao.GetAnswers().Where(x => x.QuestionNumber.Equals(_selectedQuestion.QuestionNumber)).ToList();
            var answer = ParseAnswer();
            answersForQurrentQuestion.Add(answer);
            _selectedQuestion.UpdateWeight(answersForQurrentQuestion);
            Dao.SaveQuestion(_selectedQuestion);
        }

        private void SaveAnswer()
        {
            var answer = ParseAnswer();
            Dao.SaveAnswer(answer);
        }

        private void RedrawQuestion()
        {
            questionNumberLabel.Text = @"Question #" + _selectedQuestion.QuestionNumber;
            questionTextRTB.Text = _selectedQuestion.QuestionText;
            questionWeightLabel.Text = @"Weight: " + _selectedQuestion.Weight;

            PrepareTypeSpecificData();
        }

        private void PrepareTypeSpecificData()
        {
            switch (_selectedQuestion.QuestionType)
            {
                case QuestionType.BooleanQuestion:
                    trueRB.Checked = false;
                    falseRB.Checked = false;
                    break;
                case QuestionType.OneOfMany:
                case QuestionType.ManyOfMany:
                    someOfManyLB.Items.Clear();
                    foreach (var answer in _selectedQuestion.PossibleAnswers.ToArray())
                    {
                        someOfManyLB.Items.Add(new ListViewItem(answer,0));
                    }
                    break;
                case QuestionType.NumberQuestion:
                    numberTB.Text = "";
                    break;
                case QuestionType.Interval:
                    intervalStartTB.Text = "";
                    intervalEndTB.Text = "";
                    break;
            }
        }

        private void SelectAnswerPanel()
        {
            foreach (var panel in _answerPanelDictionary.Values)
            {
                panel.Visible = false;
            }
            var selectedPanel = _answerPanelDictionary[_selectedQuestion.QuestionType];
            selectedPanel.Visible = true;
        }
    }
}
