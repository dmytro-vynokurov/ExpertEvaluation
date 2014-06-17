using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace ExpertEvaluation.classes
{
    public class Answer
    {
        public Answer(int questionNumber, QuestionType questionType)
        {
            QuestionNumber = questionNumber;
            QuestionType = questionType;
        }

        public ObjectId Id { get; set; }
        public int QuestionNumber { get; set; }
        public QuestionType QuestionType { get; set; }
        public List<String> Answers { get; set; }
 
        
        public Boolean IsCorrect()
        {
            var question = Dao.GetQuestionByNumber(QuestionNumber);
            return GetAnswers().Equals(question.GetRightAnswers());
        }

        private string GetAnswers()
        {
            return Answers == null ? "" : String.Join("; ", Answers);
        }

        public override string ToString()
        {
            return "Answer for question #" + QuestionNumber + " of type " + QuestionType + ": " + GetAnswers();
        }

    }
}
