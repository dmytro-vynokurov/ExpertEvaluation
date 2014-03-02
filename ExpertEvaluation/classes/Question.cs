using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace ExpertEvaluation.classes
{

    internal enum QuestionType
    {
        BooleanQuestion,
        OneOfMany
    };

    class Question
    {
        public Question(int questionNumber, QuestionType questionType)
        {
            QuestionNumber = questionNumber;
            QuestionType = questionType;
        }

        public ObjectId Id { get; set; }


        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public QuestionType QuestionType { get; set; }
        public string[] PossibleAnswers { get; set; }
        public string RightAnswer { get; set; }


        public override string ToString()
        {
            return "Question for question #" + QuestionNumber + " of type " + QuestionType;
        }
    }
}
