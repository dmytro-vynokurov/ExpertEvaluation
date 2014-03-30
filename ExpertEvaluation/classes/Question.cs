using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace ExpertEvaluation.classes
{

    public enum QuestionType
    {
        BooleanQuestion,
        OneOfMany
    };

    public class Question
    {
        public static Dictionary<QuestionType,String> QuestionDictionary = 
            new Dictionary<QuestionType, string>()
            {
                {QuestionType.BooleanQuestion, "Boolean"},
                {QuestionType.OneOfMany, "One of many"}
            };

        public static IEnumerable<QuestionType> GetQuestionTypes()
        {
            return Enum.GetValues(typeof(QuestionType)).Cast<QuestionType>();
        } 

        public ObjectId Id { get; set; }


        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public QuestionType QuestionType { get; set; }
        public string[] PossibleAnswers { get; set; }
        public string RightAnswer { get; set; }

        public string GetPossibleAnswers()
        {
            if (PossibleAnswers == null) return "";
            return String.Join("; ", PossibleAnswers);
        }

        public override string ToString()
        {
            return "Question for question #" + QuestionNumber + " of type " + QuestionType;
        }
    }
}
