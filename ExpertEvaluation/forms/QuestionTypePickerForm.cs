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
    public partial class QuestionTypePickerForm : Form
    {
        private List<String> _questionTypeNames; 

        public QuestionTypePickerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_questionTypeNames.Contains(comboBox1.Text))
            {
                MessageBox.Show(@" Please choose question type from the list", @"Wrong question type",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var questionType = Question.GetByName(comboBox1.Text);
            if (Dao.GetQuestions().Where(x => x.QuestionType.Equals(questionType)).Count() == 0)
                MessageBox.Show(@" Please choose another question type", @"No questions of chosen type",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.Hide();
                var answerForm = new AnswerForm(questionType);
                answerForm.Show();
            }
        }

        private void QuestionTypePicker_Load(object sender, EventArgs e)
        {
            _questionTypeNames = new List<string>();
            foreach (var pair in Question.QuestionDictionary)
            {
                comboBox1.Items.Add(pair.Value);
                _questionTypeNames.Add(pair.Value);
            }
        }
    }
}
