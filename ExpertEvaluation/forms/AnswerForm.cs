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
        }
        private static Dictionary<QuestionType, Panel> _answerPanelDictionary;
        private void InitializeQuestionPanelDictionary()
        {
            _answerPanelDictionary = new Dictionary<QuestionType, Panel>()
            {
                {QuestionType.BooleanQuestion, booleanAP},
                {QuestionType.OneOfMany, manyOfManyAP},
                {QuestionType.ManyOfMany, manyOfManyAP},
                {QuestionType.NumberQuestion, numberAP},
                {QuestionType.Interval, intervalAP}
            };
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!FormVerified()) return;
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
                MessageBox.Show(@"No right answer chosen", @"Cannot create question",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
//            if (_questionType == QuestionType.OneOfMany && !oneOfManyRTB.Lines.Contains(oneOfManyCB.Text))
//            {
//                MessageBox.Show(@"Right answer chosen is not one of possible answers", @"Cannot create question",
//                    MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return false;
//            }
//            if (_questionType == QuestionType.ManyOfMany && !ManyOfManyIsValid())
//            {
//                MessageBox.Show(@"No right answer chosen", @"Cannot create question",
//                    MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return false;
//            }
            if (_questionType == QuestionType.NumberQuestion && !int.TryParse(numberTB.Text, out a))
            {
                MessageBox.Show(@"Incorrect right answer", @"Cannot create question",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_questionType == QuestionType.Interval && !(int.TryParse(intervalStartTB.Text, out a) && int.TryParse(intervalEndTB.Text, out b)))
            {
                MessageBox.Show(@"Incorrect right answer", @"Cannot create question",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void SaveAnswer()
        {
            // TODO: question weight update
            //TODO: implement
        }

        private void RedrawQuestion()
        {
            questionNumberLabel.Text = @"Question #" + _selectedQuestion.QuestionNumber;
            questionTextRTB.Text = _selectedQuestion.QuestionText;

            PrepareTypeSpecificData();
        }

        private void PrepareTypeSpecificData()
        {
            SelectAnswerPanel();
            switch (_selectedQuestion.QuestionType)
            {

                case QuestionType.OneOfMany:
                    manyOfManyCLB.SelectionMode = SelectionMode.One;
                    manyOfManyCLB.Items.Clear();
                    manyOfManyCLB.Items.AddRange(items: _selectedQuestion.PossibleAnswers.ToArray());
                    break;
                case QuestionType.ManyOfMany:
                    manyOfManyCLB.SelectionMode = SelectionMode.MultiSimple;
                    manyOfManyCLB.Items.Clear();
                    manyOfManyCLB.Items.AddRange(items: _selectedQuestion.PossibleAnswers.ToArray());
                    break;
                //TODO: finish here
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
