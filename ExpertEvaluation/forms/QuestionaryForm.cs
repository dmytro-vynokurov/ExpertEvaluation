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
            InitializeQuestionPanelDictionary();
            InitializeQuestionsLV();
        }
        private static Dictionary<QuestionType, Panel> _answerPanelDictionary;
        private void InitializeQuestionPanelDictionary()
        {
            _answerPanelDictionary = new Dictionary<QuestionType, Panel>()
            {
                {QuestionType.BooleanQuestion, booleanAP},
                {QuestionType.OneOfMany, manyOfManyAP},
                {QuestionType.NumberQuestion, numberAP},
                {QuestionType.ManyOfMany, manyOfManyAP},
                {QuestionType.Interval, intervalAP}

                // TODO: add Fuzzy interval mapping
            };
        }


        private void questionsLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedId = 2;
            try
            {
                var selectedIndex = questionsLV.SelectedIndices[0];
                selectedId = int.Parse(questionsLV.Items[selectedIndex].Text);
            }
            catch (Exception exception)
            {}
                _selectedQuestion = Dao.GetQuestionByNumber(selectedId);
                RedrawQuestion();
            
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
                    foreach (var rightAnswer in _selectedQuestion.RightAnswers)
                    {
                        var index = manyOfManyCLB.Items.IndexOf(rightAnswer);
                        manyOfManyCLB.SetItemChecked(index, true);
                    }
                    break;
                case QuestionType.ManyOfMany:
                    manyOfManyCLB.SelectionMode = SelectionMode.MultiSimple;
                    manyOfManyCLB.Items.Clear();
                    manyOfManyCLB.Items.AddRange(items: _selectedQuestion.PossibleAnswers.ToArray());
                    foreach (var rightAnswer in _selectedQuestion.RightAnswers)
                    {
                        var index = manyOfManyCLB.Items.IndexOf(rightAnswer);
                        manyOfManyCLB.SetItemChecked(index, true);
                    }
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
