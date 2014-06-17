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
        Interval
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
                {QuestionType.Interval, "Interval"}
            };

        public static IEnumerable<QuestionType> GetQuestionTypes()
        {
            return Enum.GetValues(typeof(QuestionType)).Cast<QuestionType>();
        }

        public ObjectId Id { get; set; }
        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public int Weight { get; set; }
        public QuestionType QuestionType { get; set; }
        public List<string> PossibleAnswers { get; set; }
        public List<string> RightAnswers { get; set; }

        public string GetPossibleAnswers()
        {
            return PossibleAnswers == null ? "" : String.Join("; ", PossibleAnswers);
        }

        public string GetRightAnswers()
        {
            return RightAnswers == null ? "" : String.Join("; ", RightAnswers);
        }

        public override string ToString()
        {
            return "Question for question #" + QuestionNumber + " of type " + QuestionType;
        }

        public static QuestionType GetByName(string questionTypeName)
        {
            foreach (var pair in QuestionDictionary)
            {
                if (questionTypeName.Equals(pair.Value)) return pair.Key;
            }
            throw new ArgumentException("Cannot find question by name "+questionTypeName);
        }

        // Indicates percentage of answers that show that this question is HARDER than it weights
        private int MinComplexityBound()
        {
            //less people answer to this question than expected
            return ExpectedCorrectAnswerPercentage() - 10;
        }

        // Indicates percentage of answers that show that this question is EASIER than it weights
        private int MaxComplexityBound()
        {
            // more people answer to this question correctly than expected
            return ExpectedCorrectAnswerPercentage() + 10;
        }

        private int ExpectedCorrectAnswerPercentage()
        {
            // Weight from 0 to 10. Questions with weight 10 are the hardest.
            // The harder the question is the less people answer to it correctly.
            return (10 - Weight)*10;
        }

        public void UpdateWeight(List<Answer> answers)
        {
            var correctAnswers = answers.Count(x => x.IsCorrect());
            var totalAnswers = answers.Count();

            // Percentage of correct answers
            var answerRate = 100*correctAnswers/totalAnswers;

            // If there are too few correct answers, increase question weight
            if (answerRate < MinComplexityBound()) Weight = Math.Max(Weight + 1, 0);  // INCREASE weight. Weight cannot be more than 10

            // If there are too many correct answers, decrease question weight
            else if (answerRate > MaxComplexityBound()) Weight = Math.Min(Weight - 1, 10);  // DECREASE Weight. Weight cannot be less than 0
        }
    }
}
