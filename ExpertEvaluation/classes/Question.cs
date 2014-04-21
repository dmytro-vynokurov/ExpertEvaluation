using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;

namespace ExpertEvaluation.classes
{

    public enum QuestionType
    {
        BooleanQuestion,
        OneOfMany,
        ManyOfMany,
        NumberQuestion,
        Interval, 
        FuzzyInterval
    };

    public class Question
    {
        public static readonly Dictionary<QuestionType,String> QuestionDictionary = 
            new Dictionary<QuestionType, string>
            {
                {QuestionType.BooleanQuestion, "Boolean"},
                {QuestionType.OneOfMany, "One of many"},
                {QuestionType.ManyOfMany, "Many of many"},
                {QuestionType.NumberQuestion, "Number"},
                {QuestionType.Interval, "Interval"},
                {QuestionType.FuzzyInterval, "Fuzzy interval"}
            };

        public static IEnumerable<QuestionType> GetQuestionTypes()
        {
            return Enum.GetValues(typeof(QuestionType)).Cast<QuestionType>();
        }

        public ObjectId Id { get; set; }
        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public QuestionType QuestionType { get; set; }
        public List<string> PossibleAnswers { get; set; }
        public List<string> RightAnswers { get; set; }

        public string GetPossibleAnswers()
        {
            if (PossibleAnswers == null) return "";
            else return String.Join("; ", PossibleAnswers);
        }

        public string GetRightAnswers()
        {
            if (RightAnswers == null) return "";
            else return String.Join("; ", RightAnswers);
        }

        public override string ToString()
        {
            return "Question for question #" + QuestionNumber + " of type " + QuestionType;
        }
    }
}
