using System;

namespace ExpertEvaluation.classes
{
   

    class Answer
    {
        public Answer(int questionNumber, QuestionType questionType)
        {
            QuestionNumber = questionNumber;
            QuestionType = questionType;
        }

        public int QuestionNumber { get; set; }
        public QuestionType QuestionType { get; set; }
        public bool BooleanAnswer { get; set; }
        public int OneOfManyAnswer { get; set; }

        public string GetStringAnswer()
        {
            switch (QuestionType)
            {
                case QuestionType.BooleanQuestion:
                    return BooleanAnswer.ToString();
                case QuestionType.OneOfMany:
                    return OneOfManyAnswer.ToString();
                default:
                    return "No Answer";
            }
        }
        public override string ToString()
        {
            return "Answer for question #" + QuestionNumber + " of type " + QuestionType + ": " + GetStringAnswer();
        }

    }
}
