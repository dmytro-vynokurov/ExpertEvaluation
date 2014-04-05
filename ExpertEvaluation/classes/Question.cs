﻿using System;
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
        // TODO: add new question types to enum here
    };

    public class Question
    {
        public static readonly Dictionary<QuestionType,String> QuestionDictionary = 
            new Dictionary<QuestionType, string>()
            {
                {QuestionType.BooleanQuestion, "Boolean"},
                {QuestionType.OneOfMany, "One of many"}
                // TODO: add mappings for new question types to their text representation
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
